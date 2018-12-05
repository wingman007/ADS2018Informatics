using System;

namespace GroupsQueueList
{
	class Program
	{
		static void Main(string[] args)
		{
			QueuedList list = new QueuedList();
			list.add("a");
			list.add(true);
			list.add(1.1);
			list.add(5);
			list.add(3.14);
			list.add("b");
			list.add(false);
			list.printQueue();


			list.get();
			list.printQueue();
			list.get();
			list.printQueue();
			list.get();
			list.printQueue();
			list.get();
			list.printQueue();
			list.get();
			list.printQueue();

		}
	}
}
