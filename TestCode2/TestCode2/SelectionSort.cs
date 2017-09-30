using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class SelectionSort
	{
		private int[] data;
		private static Random generator = new Random();

		public SelectionSort(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public void Sort()
		{
			int smallest;

			for (int i = 0; i < data.Length - 1; i++)
			{
				smallest = i;

				for (int index = i + 1; index < data.Length; index++)
					if (data[index] < data[smallest])
						smallest = index;

				Swap(i, smallest);
				PrintPass(i + 1, smallest);
			}
		}

		public void Swap(int first, int second)
		{
			int temporary = data[first];
			data[first] = data[second];
			data[second] = temporary;
		}

		public void PrintPass(int pass, int index)
		{
			Console.Write("after pass {0}: ", pass);

			for (int i = 0; i < index; i++)
				Console.Write(data[i] + " ");

			Console.Write(data[index] + "* ");

			for (int i = index + 1; i < data.Length; i++)
				Console.Write(data[i] + "  ");

			Console.Write("\n        ");

			for (int j = 0; j < pass; j++)
				Console.Write("-- ");

			Console.WriteLine("\n");
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