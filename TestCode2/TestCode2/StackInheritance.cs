using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class StackInheritance
		: SinglyLinkedList
	{
		public StackInheritance()
			: base("stack")
		{
		}

		public void Push(object dataValue)
		{
			InsertAtFront(dataValue);
		}

		public object Pop()
		{
			return RemoveFromFront();
		}
	}
}