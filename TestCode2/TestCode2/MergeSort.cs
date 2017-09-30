using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class MergeSort
	{
		private int[] data;
		private static Random generator = new Random();

		public MergeSort(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public void Sort()
		{
			SortArray(0, data.Length - 1);
		}

		private void SortArray(int low, int high)
		{
			if ((high - low) >= 1)
			{
				int middle1 = (low + high) / 2;
				int middle2 = middle1 + 1;

				Console.WriteLine("split:    " + Subarray(low, high));
				Console.WriteLine("          " + Subarray(low, middle1));
				Console.WriteLine("          " + Subarray(middle2, high));
				Console.WriteLine();

				SortArray(low, middle1);
				SortArray(middle2, high);

				Merge(low, middle1, middle2, high);
			}
		}

		private void Merge(int left, int middle1, int middle2, int right)
		{
			int leftIndex = left;
			int rightIndex = middle2;
			int combinedIndex = left;
			int[] combined = new int[data.Length];

			Console.WriteLine("merge:   " + Subarray(left, middle1));
			Console.WriteLine("         " + Subarray(middle2, right));

			while (leftIndex <= middle1 && rightIndex <= right)
			{
				if (data[leftIndex] <= data[rightIndex])
					combined[combinedIndex++] = data[leftIndex++];
				else
					combined[combinedIndex++] = data[rightIndex++];
			}

			if (leftIndex == middle2)
				while(rightIndex <= right)
					combined[combinedIndex++] = data[rightIndex++];
			else
				while (leftIndex <= middle1)
					combined[combinedIndex++] = data[leftIndex++];

			for (int i = left; i <= right; i++)
				data[i] = combined[i];

			Console.WriteLine("          " + Subarray(left, right));
			Console.WriteLine();
		}

		public string Subarray(int low, int high)
		{
			string temporary = string.Empty;

			for (int i = 0; i < low; i++)
				temporary += "   ";

			for (int i = low; i <= high; i++)
				temporary += " " + data[i];

			return temporary;
		}

		public override string ToString()
		{
			return Subarray(0, data.Length - 1);
		}
	}
}