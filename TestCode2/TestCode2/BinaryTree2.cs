using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class BinaryTree2
	{
		private BinaryTreeNode2 root;

		public BinaryTree2()
		{
			root = null;
		}

		public void InsertNode(IComparable insertValue)
		{
			if (root == null)
				root = new BinaryTreeNode2(insertValue);
			else
				root.Insert(insertValue);
		}

		public void PreorderTraversal()
		{
			PreorderHelper(root);
		}

		private void PreorderHelper(BinaryTreeNode2 node)
		{
			if (node != null)
			{
				Console.Write(node.Data + " ");
				PreorderHelper(node.LeftNode);
				PreorderHelper(node.RightNode);
			}
		}

		public void InorderTraversal()
		{
			InorderHelper(root);
		}

		private void InorderHelper(BinaryTreeNode2 node)
		{
			if (node != null)
			{
				InorderHelper(node.LeftNode);
				Console.Write(node.Data + " ");
				InorderHelper(node.RightNode);
			}
		}

		public void PostorderTraversal()
		{
			PostorderHelper(root);
		}

		private void PostorderHelper(BinaryTreeNode2 node)
		{
			if (node != null)
			{
				PostorderHelper(node.LeftNode);
				PostorderHelper(node.RightNode);
				Console.Write(node.Data + " ");
			}
		}
	}
}