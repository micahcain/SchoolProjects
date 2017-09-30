using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make tiny console window bigger!!!
            Console.WindowHeight = 40;

            // Flashy introduction with magic sparkles.
            Console.WriteLine("/**********************************************/");
            Console.WriteLine("/*           Welcome to some kind of          */");
            Console.WriteLine("/*             Temperature Machine            */");
            Console.WriteLine("/**********************************************/");

            fancyPantsOutputRobot("75 31 75 80 82 73 70");
            fancyPantsOutputRobot("20 100 50 10 75 75 -30");
            fancyPantsOutputRobot("95 88 76 79 90 85 91");
            fancyPantsOutputRobot("75 88 31");
            
        }

        public static void fancyPantsOutputRobot(String weekOfTemps)
        {
            Console.Clear();
            Console.WriteLine("/**********************************************/");
            Console.WriteLine("/*           Welcome to some kind of          */");
            Console.WriteLine("/*             Temperature Machine            */");
            Console.WriteLine("/**********************************************/");
            Console.WriteLine("*****************************************INNABOX****************************\n");
            // Instantiating a Temps object with some outlandish tempertatures.
            Temps newTemps = new Temps(weekOfTemps);

            if (newTemps.temperatures.Count() != 7)
            Console.WriteLine("I guess weeks don't have seven days on your planet!");

            // Printing out the temperatures
            Console.Out.WriteLine("The temperatures for the week are as follows:");
            foreach (double t in newTemps.temperatures)
                Console.Write(t + " ");
            Console.WriteLine("\n\n");

            // Displaying the maximum temperature
            newTemps.getMaxTemp();
            Console.WriteLine("Out of all the temperatures this week, " + newTemps.maxTemp + " was certainly the hottest!");

            // Displaying the minimum temperature
            newTemps.getMinTemp();
            Console.WriteLine("Out of all the temperatures this week, " + newTemps.minTemp + " was certainly the coldest!");

            // Displaying the average temperature
            newTemps.getAverageTemp();

            if (newTemps.averageTemp <= 50)
                Console.WriteLine("With an average temperature of " + newTemps.averageTemp + " we had a pretty cold week. Brrrrr!\n");
            else if (newTemps.averageTemp >= 51 && newTemps.averageTemp <= 70)
                Console.WriteLine("With an average temperature of " + newTemps.averageTemp + " we had a pretty average week. Meh!\n");
            else if (newTemps.averageTemp >= 71)
                Console.WriteLine("With an average temperature of " + newTemps.averageTemp + " we had a pretty hot week. AHHHHHHHH!\n");

            // Displaying the average temperature minus the lowest temperature
            newTemps.getAverageLessMinTemp();
            Console.WriteLine("If you completely ignore that freakishly cold day\nour average temperature was " + newTemps.averageLessMin + "\n");

            // Checking for days that were colder than a given temperature
            Console.Write("Give me a temperature\nand I'll tell you how many days were colder than that. -->");
            Console.WriteLine(newTemps.numberOfDaysTempWasLower(Convert.ToDouble(Console.ReadLine())) + " day(s) had a lower tempeature.\n");

            // For your viewing pleasure, the famous ToString() method of the Temps class LIVE!!!
            Console.WriteLine(newTemps.ToString());
            Console.WriteLine("****************************************************************************\n");

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }
    }
}
