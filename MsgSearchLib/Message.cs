using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgSearchLib
{
	public class Message
	{
		public DateTime Posted { get; private set; }
		public string From { get; private set; }
		public string Text { get; private set; }
		public MsgThread Thread { get; set; }

		public Message(string posted, string from, string text)
		{
			DateTime p;
			posted = posted.Replace(" v", "").Replace(" UTC+02", "");//TODO
			if (DateTime.TryParse(posted, CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal, out p))
				Posted = p;

			From = from;
			Text = text;
		}

		public List<Message> Next(int numberOfMessages = 1)
		{
			return Thread.Messages.Find(this).NextX(numberOfMessages);
		}

		public List<Message> Previous(int numberOfMessages = 1)
		{
			return Thread.Messages.Find(this).PrevX(numberOfMessages);
		}
	}
}
