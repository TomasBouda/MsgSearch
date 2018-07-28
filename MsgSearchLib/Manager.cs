using HtmlAgilityPack;
using LinqKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MsgSearchLib
{
    public class Manager
    {
		public string PathToMessagesHtml { get; set; }

		public HtmlDocument MessagesDocument { get; set; }

		public List<MsgThread> Threads { get; set; }


		public Manager()
		{
            MessagesDocument = new HtmlDocument();
            Threads = new List<MsgThread>();
        }

        public void AddFile(string pathToMessagesHtml)
        {
            if (File.Exists(pathToMessagesHtml))
            {
                MessagesDocument.Load(pathToMessagesHtml, Encoding.UTF8, true);
                Init(Path.GetFileName(pathToMessagesHtml));
            }
            else
                throw new Exception("Cannot find messages html file.");
        }

		private void Init(string fileName)
		{
			var threads = MessagesDocument.DocumentNode.SelectNodes("//*[@class='thread']");

			foreach(var thread in threads)
			{
				LinkedList<Message> messages = new LinkedList<Message>();
				var msgThread = new MsgThread(thread.SelectSingleNode("./h3").InnerText, fileName);

				var messageNodes = thread.SelectNodes("./div[@class='message']");
				foreach(var message in messageNodes.Reverse())
				{
					string posted = message.SelectSingleNode("./div/span[@class='meta']")?.InnerText;
					string from = message.SelectSingleNode("./div/span[@class='user']")?.InnerText;
					string messageText = message.NextSibling?.InnerText;

					messages.AddLast(new Message(posted, from, messageText) {  Thread = msgThread });
				}

				msgThread.Messages = messages;
				Threads.Add(msgThread);
			}
		}

		public List<Message> Search(string text, string from = null, int limit = 1000, int skip = 0)
		{
            Expression<Func<Message, bool>> fromEx = PredicateBuilder.New<Message>(true);
            if (!string.IsNullOrEmpty(from))
            {
                if (from.Contains("|"))
                {
                    var froms = from.Split('|');

                    foreach (var f in froms)
                    {
                        Expression<Func<Message, bool>> ex = m => m.From.Contains(f);
                        fromEx = fromEx.Or(ex);
                    }
                }
                else
                {
                    fromEx = m => m.From.Contains(from);
                }
            }
                
            List<Message> results = new List<Message>();
			foreach(var thread in Threads)
			{
                var messages = thread.Messages
                    .Where(m => m.Text.Contains(text))
                    .Where(fromEx.Compile())
                    .Skip(skip)
                    .Take(limit);

                results.AddRange(messages);
			}

			return results;
		}
    }
}
