using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Collection<int>();
            var generator = new Random();
            var sb = new StringBuilder();

            for (int i = 1; i < 101; i++)
            {
                numbers.Add(generator.Next(0, 1001));
            }

            sb.AppendLine("-------------------------------------------------------------------------------");
            sb.AppendLine("-----------------------------List of All Numbers---------------------------");
            sb.AppendLine("-------------------------------------------------------------------------------");
            foreach (int number in numbers)
            {
                    sb.Append(number + ",");
            }
            sb.Replace(",", String.Empty, (sb.Length - 1), 1);
            sb.AppendLine();


            //foreach(int number in numbers)
            //    Console.WriteLine(number);

            sb.AppendLine("-------------------------------------------------------------------------------");
            sb.AppendLine("-----------------------------List of Even Numbers---------------------------");
            sb.AppendLine("-------------------------------------------------------------------------------");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    sb.Append(number + ",");
            }
            sb.Replace(",", String.Empty, (sb.Length - 1), 1);
            sb.AppendLine();
            sb.AppendLine("-------------------------------------------------------------------------------");
            sb.AppendLine("-------------------------------------------------------------------------------");

            var maxValue = numbers[0];
            var minValue = numbers[0];
            var total = 0;

            for (int i = 1; i < 100; i++ )
            {
                if (numbers[i] > maxValue)
                    maxValue = numbers[i];

                if (numbers[i] < minValue)
                    minValue = numbers[i];

                total += numbers[i - 1];
            }

            sb.AppendLine("Max number generated is: " + maxValue);
            sb.AppendLine("Min number generated is: " + minValue);
            sb.AppendLine("Total of the numbers is: " + total);
            sb.AppendLine("The average of the numbers is: " + (total / 100));
            sb.AppendLine("The range of the numbers is: " + (maxValue - minValue));

            System.Windows.Forms.MessageBox.Show(sb.ToString());
        }
    }
}
