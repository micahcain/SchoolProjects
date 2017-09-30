using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class SinglyLinkedListNode
	{
		public SinglyLinkedListNode(object dataValue)
			: this(dataValue, null)
		{
		}

		public SinglyLinkedListNode(object dataValue, SinglyLinkedListNode nextNode)
		{
			Data = dataValue;
			Next = nextNode;
		}

		public object Data { get; private set; }
		public SinglyLinkedListNode Next { get; set; }
	}
}