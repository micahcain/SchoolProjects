using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class LinearArray
	{
		private int[] data;
		private static Random generator = new Random();

		public LinearArray(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public int LinearSearch(int searchKey)
		{
			for (int index = 0; index < data.Length; index++)
				if (data[index] == searchKey)
					return index;

			return -1;
		}

		public override string ToString()
		{
			string temporary = string.Empty;

			foreach (int element in data)
				temporary += element + " ";

			temporary += "\n";
			return temporary;
		}
	}
}