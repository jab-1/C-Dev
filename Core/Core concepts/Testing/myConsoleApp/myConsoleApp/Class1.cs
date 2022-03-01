using System;

namespace Greeting;
public class Program
{
    public static void Main(string[] args)
    {
        int time = 6;
        var greeting = Greeting(time);
        Console.WriteLine(greeting);
    }
    public static string Greeting(int time) {
        string greeting = "";
        if (time >= 5 && time <= 12)
        {
            greeting = "It is the morning.";
        }
        else if (time > 12 && time <= 18)
        {
            greeting = "It is the afternoon.";
        }
        else {
            greeting = "It is the evening.";
        }
        return greeting;

    }

    
}
