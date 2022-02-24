using System;

namespace myConsoleApp;
public class Program2
{
    public static void NotMain(string[] args)
    {
        Console.WriteLine("Test");
        var val = 10;
        var finalCount = NestedForLoopSquared(val);
        // should output 10^2

      
    }
    public static int NestedForLoopSquared(int val)
    {
        var num = 0;
        for (int i = 0; i < val; i++)
        {
            for (int x = 0; x < val; x++)
            {
                num++;

            }
        }
        return num;
    }


}

