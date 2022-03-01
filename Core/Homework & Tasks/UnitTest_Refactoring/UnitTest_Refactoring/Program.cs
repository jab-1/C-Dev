using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        var greeting = Greeting(timeOfDay);
        Console.WriteLine(greeting);
    }

    public static string Greeting(int timeOfDay)
    {

        string greeting;
        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay > 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else
        {
            greeting = "Good evening!";
        }
        return greeting;
    }
    //U, PG, 12A/12, 15, 18
    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;

        if (ageOfViewer >= 0 && ageOfViewer < 12)
        {
            result = "U & PG films are available.";
        }

        else if (ageOfViewer >= 12 && ageOfViewer < 15)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer >= 15 && ageOfViewer < 18)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}
