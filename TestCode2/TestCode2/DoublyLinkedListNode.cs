using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class DoublyLinkedListNode
	{
		public DoublyLinkedListNode(object dataValue)
			: this(dataValue, null, null)
		{
		}

		public DoublyLinkedListNode(object dataValue, DoublyLinkedListNode nextNode, DoublyLinkedListNode previousNode)
		{
			Data = dataValue;
			Next = nextNode;
			Previous = previousNode;
		}

		public object Data { get; private set; }
		public DoublyLinkedListNode Next { get; set; }
		public DoublyLinkedListNode Previous { get; set; }
	}
}