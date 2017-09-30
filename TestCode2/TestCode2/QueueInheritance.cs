using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class QueueInheritance
		: SinglyLinkedList
	{
		public QueueInheritance()
			: base("queue")
		{
		}

		public void Enqueue(object dataValue)
		{
			InsertAtBack(dataValue);
		}

		public object Dequeue()
		{
			return RemoveFromFront();
		}
	}
}