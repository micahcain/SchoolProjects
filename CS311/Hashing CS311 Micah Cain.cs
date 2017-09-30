using System;
using System.IO;

public class Class1
{
	public Class1()
	{
        int chaining = new int[100];
        int linearProbing = new int[100];
        int doubleHashing = new int[100];

        Console.WriteLine("Begin entering numbers to be inserted into the hashing arrays.");
        Console.WriteLine("Enter any text to stop entering numbers.");

        var numberOfValues = 0;
        var currentValue = 0;

        while (int.TryParse(currentValue) && numberOfValues < 100)
        {
            chaining[numberOfValues] = currentValue;
            linearProbing[numberofvalues] = currentValue;
            doubleHashing[numberofvalues] = currentValue;
        }
        

    }

}
