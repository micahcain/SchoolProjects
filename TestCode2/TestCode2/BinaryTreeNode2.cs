using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class BinaryTreeNode2
	{
		public BinaryTreeNode2(IComparable nodeData)
		{
			Data = nodeData;
			LeftNode = RightNode = null;
		}

		public BinaryTreeNode2 LeftNode { get; set; }
		public IComparable Data { get; set; }
		public BinaryTreeNode2 RightNode { get; set; }

		public void Insert(IComparable insertValue)
		{
			if (insertValue.CompareTo(Data) < 0)
			{
				if (LeftNode == null)
					LeftNode = new BinaryTreeNode2(insertValue);
				else
					LeftNode.Insert(insertValue);
			}
			else if (insertValue.CompareTo(Data) > 0)
			{
				if (RightNode == null)
					RightNode = new BinaryTreeNode2(insertValue);
				else
					RightNode.Insert(insertValue);
			}
		}
	}
}