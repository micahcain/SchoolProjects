using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var classSize = 0;
            var counter = 0;
            var output = new StringBuilder();
            
            Console.Write("How many students would you like to enter? -->");
            classSize = Convert.ToInt32(Console.ReadLine());
            String[] students = new String[classSize];
            var nullStudents = 0;

            for(counter = 0; counter < classSize; counter++)
            {
                Console.Write("What is student number " + (counter + 1) + "'s name? -->");
                students[counter] = Console.ReadLine();
            }

            for (counter = 0; counter < classSize; counter++)
            {
                if (String.IsNullOrEmpty(students[counter]))
                {
                    nullStudents++;
                }
            }


            if (nullStudents == classSize)
            {
                output.AppendLine("There are no valid students in this class.");
            }
            else
            {
                output.AppendLine("+-----------------------------------------+");
                output.AppendLine("+           Class Roster:                 +");
                output.AppendLine("+-----------------------------------------+");
                output.AppendLine();
                output.AppendLine("The class has " + classSize + " students.");                

                output.AppendLine("The students in this class are:");
                output.AppendLine();

                for (counter = 0; counter < students.Length; counter++)
                {
                    if (!String.IsNullOrEmpty(students[counter]))
                    {
                       output.AppendLine(students[counter]);                        
                    }
                }
                output.AppendLine();
            }

            if(nullStudents != 0)
                output.Replace("The class has " + classSize + " students.", "This class has " + (classSize - nullStudents) + " students.");

            Console.WriteLine(output.ToString());
        }
    }
}
