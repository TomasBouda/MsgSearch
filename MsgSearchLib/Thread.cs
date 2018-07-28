using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgSearchLib
{
	public class MsgThread
	{
        public string Name { get; set; }
        public string FileName { get; set; }

        public LinkedList<Message> Messages { get; set; }

		public MsgThread(string name, string fileName)
		{
            Name = name;
            FileName = fileName;
        }

		public MsgThread(LinkedList<Message> messages)
		{
			Messages = messages;
		}

        public override string ToString()
        {
            return $"{FileName} - {Name}";
        }
    }
}
