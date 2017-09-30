using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class BinaryTreeNode
	{
		public BinaryTreeNode(int nodeData)
		{
			Data = nodeData;
			LeftNode = RightNode = null;
		}

		public BinaryTreeNode LeftNode { get; set; }
		public int Data { get; set; }
		public BinaryTreeNode RightNode { get; set; }

		public void Insert(int insertValue)
		{
			if (insertValue < Data)
			{
				if (LeftNode == null)
					LeftNode = new BinaryTreeNode(insertValue);
				else
					LeftNode.Insert(insertValue);
			}
			else if (insertValue > Data)
			{
				if (RightNode == null)
					RightNode = new BinaryTreeNode(insertValue);
				else
					RightNode.Insert(insertValue);
			}
		}
	}
}