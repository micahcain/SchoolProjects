using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TestCode2
{
	public class BucketSort
	{
		private int[] data;
		private static Random generator = new Random();

		public BucketSort(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public void Sort()
		{
			int max = data[0];
			int min = data[0];

			for (int i = 0; i < data.Length; i++)
			{
				if (data[i].CompareTo(max) > 0)
				{
					max = data[i];
				}

				if (data[i].CompareTo(min) < 0)
				{
					min = data[i];
				}
			}

			var holder = new ArrayList[max - min + 1];

			for (int i = 0; i < holder.Length; i++)
			{
				holder[i] = new ArrayList();
			}

			for (int i = 0; i < data.Length; i++)
			{
				holder[data[i] - min].Add(data[i]);
			}

			int k = 0;

			for (int i = 0; i < holder.Length; i++)
			{
				if (holder[i].Count > 0)
				{
					for (int j = 0; j < holder[i].Count; j++)
					{
						data[k] = (int)holder[i][j];
						k++;
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