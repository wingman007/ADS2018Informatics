using System;
using System.Collections.Generic;
namespace GroupsQueueList
{
	public class QueuedList
	{
		List<object> list = new List<object>();

		public void add(object o)
		{
			foreach( var item in list)
			{
				if( item.GetType() == o.GetType() )
				{
					list.Insert(list.IndexOf(item) +1, o);
					return;
				}
			}
			
			list.Insert(list.Count, o);
		}

		public object get()
		{
			if (list.Count == 0)
				return null;

				object o = list[0];
			Console.WriteLine("Removing ( {0} ) from Queue.", o);
				list.RemoveAt(0);
				return o;
		}

		public void printQueue()
		{
			if(list.Count == 0)
			{
				Console.WriteLine("The queue is empty");
				return;
			}

			Console.Write("list:\t");
			foreach(var item in list)
			{
				Console.Write( item  + " ");
			}
			Console.WriteLine();
		}


	}
}
