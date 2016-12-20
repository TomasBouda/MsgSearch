using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgSearchLib
{
    public class Manager
    {
		public string PathToMessagesHtml { get; set; }

		public HtmlDocument MessagesDocument { get; set; }

		public List<MsgThread> Threads { get; set; }


		public Manager(string pathToMessagesHtml)
		{
			if (File.Exists(pathToMessagesHtml))
			{
				MessagesDocument = new HtmlDocument();
				Threads = new List<MsgThread>();
				MessagesDocument.Load(pathToMessagesHtml, Encoding.UTF8, true);
				Init();
			}
			else
				throw new Exception("Cannot find messages html file.");
		}

		private void Init()
		{
			var threads = MessagesDocument.DocumentNode.SelectNodes("//*[@class='thread']");

			foreach(var thread in threads)
			{
				LinkedList<Message> messages = new LinkedList<Message>();
				var msgThread = new MsgThread();

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

		public List<Message> Search(string text)
		{
			List<Message> results = new List<Message>();
			foreach(var thread in Threads)
			{
				results.AddRange(thread.Messages.Where(m => m.Text.Contains(text)));
			}

			return results;
		}
    }
}
