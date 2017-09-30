using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class BinaryTree
	{
		private BinaryTreeNode root;

		public BinaryTree()
		{
			root = null;
		}

		public void InsertNode(int insertValue)
		{
			if (root == null)
				root = new BinaryTreeNode(insertValue);
			else
				root.Insert(insertValue);
		}

		public void PreorderTraversal()
		{
			PreorderHelper(root);
		}

		private void PreorderHelper(BinaryTreeNode node)
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

		private void InorderHelper(BinaryTreeNode node)
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

		private void PostorderHelper(BinaryTreeNode node)
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