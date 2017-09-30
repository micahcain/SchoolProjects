using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class InsertionSort
	{
		private int[] data;
		private static Random generator = new Random();

		public InsertionSort(int size)
		{
			data = new int[size];

			for (int i = 0; i < size; i++)
				data[i] = generator.Next(10, 100);
		}

		public void Sort()
		{
			int insert;

			for (int next = 1; next < data.Length; next++)
			{
				insert = data[next];

				int moveItem = next;

				while (moveItem > 0 && data[moveItem - 1] > insert)
				{
					data[moveItem] = data[moveItem - 1];
					moveItem--;
				}

				data[moveItem] = insert;
				PrintPass(next, moveItem);
			}
		}

		public void PrintPass(int pass, int index)
		{
			Console.WriteLine("after pass {0}: ", pass);

			for (int i = 0; i < index; i++)
				Console.WriteLine(data[i] + "  ");

			Console.Write(data[index] + "* ");

			for (int i = index + 1; i < data.Length; i++)
				Console.Write(data[i] + "  ");

			Console.Write("\n        ");

			for (int i = 0; i <= pass; i++)
				Console.Write("--  ");

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