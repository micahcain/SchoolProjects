using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Temperatures
{
    class Temps
    {
        public Collection<double> temperatures { get; set; }
        public double maxTemp { get; set; }
        public double minTemp { get; set; }
        public double averageTemp { get; set; }
        public double averageLessMin { get; set; }

        public Temps() { }

        public Temps(String listOfTemps)
        {
            String[] temps = listOfTemps.Split(' ');
            temperatures = new Collection<double>();


            foreach (String s in temps)
            {
                temperatures.Add(Convert.ToDouble(s));
            }

        }

        public void getMaxTemp()
        {
            if (temperatures == null)
                return;
            double currentMax = temperatures[0];

            for (int i = 1; i < temperatures.Count(); i ++)
            {
                if (temperatures[i] > currentMax)
                    currentMax = temperatures[i];
            }
            maxTemp = currentMax;
        }

        public void getMinTemp()
        {
            if (temperatures == null)
                return;

            if (temperatures == null)
                return;
            double currentMin = temperatures[0];

            for (int i = 1; i < temperatures.Count(); i++)
            {
                if (temperatures[i] < currentMin)
                    currentMin = temperatures[i];
            }
            minTemp = currentMin;
        }

        public void getAverageTemp()
        {
            if (temperatures == null)
                return;
            double total = 0.0;

            foreach (double t in temperatures)
                total += t;
            averageTemp = Convert.ToDouble(String.Format("{0:f2}", total / temperatures.Count()));
        }

        public void getAverageLessMinTemp()
        {
            if (temperatures == null)
                return;

            double total = 0.0;

            foreach (double t in temperatures)
                total += t;
            total -= minTemp;

            averageLessMin = Convert.ToDouble(String.Format("{0:f2}", total / (temperatures.Count() - 1)));

        }

        public int numberOfDaysTempWasLower(double tempToCheck)
        {
            if (temperatures == null)
                return -1;

            int numberOfDays = 0;

            foreach (double t in temperatures)
                if (t < tempToCheck)
                    numberOfDays += 1;

            return numberOfDays;
        }

        public override String ToString()
        {
            if (temperatures == null)
                return "";

            var sb = new StringBuilder();

            sb.AppendLine("For the week of: " + DateTime.Today.Month + "/" + DateTime.Today.Day + "/" + DateTime.Today.Year);
            sb.AppendLine("The mathematical range of temperatures was: " + (maxTemp - minTemp));
            sb.AppendLine("The high was: " + maxTemp);
            sb.AppendLine("The low was: " + minTemp);
            sb.AppendLine("And now sports!");

            return sb.ToString();
        }
    }
}
