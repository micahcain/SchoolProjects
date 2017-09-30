using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class BubbleSort
	{
		private int[] data;
		private static Random generator = new Random();

		public BubbleSort(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public void Sort()
		{
			int n = data.Length - 1;

			for (int i = 0; i < n; i++)
			{
				for (int j = n; j > i; j--)
				{
					if (data[j - 1].CompareTo(data[j]) > 0)
					{
						int temp = data[j - 1];
						data[j - 1] = data[j];
						data[j] = temp;
					}
				}
			}
		}

		public override string ToString()
		{
			string temporary = string.Empty;

			foreach (int element in data)
				temporary += element + "  ";

			temporary += "\n";
			return temporary;
		}
	}
}