using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgSearchLib
{
	public class MsgThread
	{
		public LinkedList<Message> Messages { get; set; }

		public MsgThread()
		{

		}

		public MsgThread(LinkedList<Message> messages)
		{
			Messages = messages;
		}
	}
}
