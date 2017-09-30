using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class SinglyLinkedList
	{
		private SinglyLinkedListNode firstNode;
		private SinglyLinkedListNode lastNode;
		private string name;

		public SinglyLinkedList(string listName)
		{
			name = listName;
			firstNode = lastNode = null;
		}

		public SinglyLinkedList()
			: this("list")
		{
		}

		public void InsertAtFront(object insertItem)
		{
			if (IsEmpty())
				firstNode = lastNode = new SinglyLinkedListNode(insertItem);
			else
				firstNode = new SinglyLinkedListNode(insertItem, firstNode);
		}

		public void InsertAtBack(object insertItem)
		{
			if (IsEmpty())
				firstNode = lastNode = new SinglyLinkedListNode(insertItem);
			else
				lastNode = lastNode.Next = new SinglyLinkedListNode(insertItem);
		}

		public object RemoveFromFront()
		{
			if (IsEmpty())
				throw new EmptyListException(name);

			object removeItem = firstNode.Data;

			if (firstNode == lastNode)
				firstNode = lastNode = null;
			else
				firstNode = firstNode.Next;

			return removeItem;
		}

		public object RemoveFromBack()
		{
			if (IsEmpty())
				throw new EmptyListException(name);

			object removeItem = lastNode.Data;

			if (firstNode == lastNode)
				firstNode = lastNode = null;
			else
			{
				SinglyLinkedListNode current = firstNode;

				while (current.Next != lastNode)
					current = current.Next;

				lastNode = current;
				current.Next = null;
			}

			return removeItem;
		}

		public bool IsEmpty()
		{
			return firstNode == null;
		}

		public void Display()
		{
			if (IsEmpty())
				Console.WriteLine("Empty " + name);
			else
				Console.Write("The " + name + " is: ");

			SinglyLinkedListNode current = firstNode;

			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}

			Console.WriteLine("\n");
		}
	}

	public class EmptyListException
		: Exception
	{
		public EmptyListException()
			: base("The list is empty")
		{
		}

		public EmptyListException(string name)
			: base("The " + name + " is empty")
		{
		}

		public EmptyListException(string exception, Exception inner)
			: base(exception, inner)
		{
		}
	}
}