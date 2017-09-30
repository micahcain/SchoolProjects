using System;
using System.Linq;
using System.Text;


namespace IntsAndFloats
{
    class Program
    {
        static void Main()
        {
            var numberOfnumbers = 0;
            var conversionExceptionText = "You entered a non numeric value.";
            while (numberOfnumbers == 0)
            {
                try
                {
                    Console.Write("How many numbers will you be entering? -->");
                    numberOfnumbers = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(conversionExceptionText);
                    Console.WriteLine();
                }
            }

            double[] numbersToAdd = new Double[numberOfnumbers];
            double total = new double();
            for (int i = 0; i < numbersToAdd.Length; i++)
            {
                
                Console.Write("Enter number " + (i + 1) + " -->");
                try
                {
                    numbersToAdd[i] = Convert.ToDouble(Console.ReadLine());
                    if(Convert.ToInt32(numbersToAdd[i]) <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than zero.");
                        Console.WriteLine();
                        i--;
                    }
                    else
                    total += numbersToAdd[i];
                }
                catch
                {
                    Console.WriteLine(conversionExceptionText);
                    Console.WriteLine();
                    i--;
                }
            }
            Console.WriteLine("The total of your numbers is: " + String.Format("{0:C}",Convert.ToDouble(total)));
            Console.WriteLine("The product of your numbers is: " + String.Format("{0:C}",multiplyNumbers(numbersToAdd)));
        }

        static double multiplyNumbers(double[] numbersToMultiply)
        {
            double total = 1;

            for (int i = 0; i < numbersToMultiply.Length; i++)
            {
                total *= numbersToMultiply[i];
            }
            return total;
        }
    }

     
}
