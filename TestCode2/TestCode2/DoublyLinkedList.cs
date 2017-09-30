using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class DoublyLinkedList
	{
		private DoublyLinkedListNode firstNode;
		private DoublyLinkedListNode lastNode;
		private string name;

		public DoublyLinkedList(string listName)
		{
			name = listName;
			firstNode = lastNode = null;
		}

		public DoublyLinkedList()
			: this("list")
		{
		}

		public void InsertAtFront(object insertItem)
		{
			if (IsEmpty())
				firstNode = lastNode = new DoublyLinkedListNode(insertItem);
			else
			{
				firstNode = new DoublyLinkedListNode(insertItem, firstNode, null);
				firstNode.Next.Previous = firstNode;
			}
		}

		public void InsertAtBack(object insertItem)
		{
			if (IsEmpty())
				firstNode = lastNode = new DoublyLinkedListNode(insertItem);
			else
			{
				lastNode = new DoublyLinkedListNode(insertItem, null, lastNode);
				lastNode.Previous.Next = lastNode;
			}
		}

		public object RemoveFromFront()
		{
			if (IsEmpty())
				throw new EmptyListException(name);

			object removeItem = firstNode.Data;

			if (firstNode == lastNode)
				firstNode = lastNode = null;
			else
			{
				firstNode = firstNode.Next;
				firstNode.Previous = null;
			}

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
				lastNode = lastNode.Previous;
				lastNode.Next = null;
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

			DoublyLinkedListNode current = firstNode;

			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}

			Console.WriteLine("\n");
		}

		public void DisplayBackwards()
		{
			if (IsEmpty())
				Console.WriteLine("Empty " + name);
			else
				Console.Write("The " + name + " is: ");

			DoublyLinkedListNode current = lastNode;

			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Previous;
			}

			Console.WriteLine("\n");
		}
	}
}