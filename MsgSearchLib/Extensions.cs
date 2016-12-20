using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgSearchLib
{
	public static class Extensions
	{
		public static List<T> NextX<T>(this LinkedListNode<T> node, int numberOfNodes)
		{
			List<T> result = new List<T>();
			var curentNode = node;
			for(int i=0; i< numberOfNodes; i++)
			{
				curentNode = curentNode.Next;
				if (curentNode == null) break;
				result.Add(curentNode.Value);
			}
			return result;
		}

		public static List<T> PrevX<T>(this LinkedListNode<T> node, int numberOfNodes)
		{
			List<T> result = new List<T>();
			var curentNode = node;
			for (int i = 0; i < numberOfNodes; i++)
			{
				curentNode = curentNode.Previous;
				if (curentNode == null) break;
				result.Add(curentNode.Value);
			}
			return result;
		}
	}
}
