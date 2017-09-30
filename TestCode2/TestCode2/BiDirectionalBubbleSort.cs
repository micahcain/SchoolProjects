using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class BiDirectionalBubbleSort
	{
		private int[] data;
		private static Random generator = new Random();

		public BiDirectionalBubbleSort(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public void Sort()
		{
			int limit = data.Length;
			int st = -1;
			bool swapped = false;

			do
			{
				swapped = false;
				st++;
				limit--;

				for (int j = st; j < limit; j++)
				{
					if (data[j].CompareTo(data[j + 1]) > 0)
					{
						int temp = data[j];
						data[j] = data[j + 1];
						data[j + 1] = temp;
						swapped = true;
					}
				}

				for (int j = limit - 1; j >= st; j--)
				{
					if (data[j].CompareTo(data[j + 1]) > 0)
					{
						int temp = data[j];
						data[j] = data[j + 1];
						data[j + 1] = temp;
					}
				}
			} while (st < limit && swapped);
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