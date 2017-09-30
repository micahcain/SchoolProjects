using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class StackComposition
	{
		// composition, as opposed to inheritance, allows you to methods of the SinglyLinkedList class
		// that should not be in this classes public interface
		private SinglyLinkedList stack;

		public StackComposition()
		{
			stack = new SinglyLinkedList("stack");
		}

		public void Push(object dataValue)
		{
			stack.InsertAtFront(dataValue);
		}

		public object Pop()
		{
			return stack.RemoveFromFront();
		}

		public bool IsEmpty()
		{
			return stack.IsEmpty();
		}

		public void Display()
		{
			stack.Display();
		}
	}
}