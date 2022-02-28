using ControlFlowApp;
using System;


public class Program
{


    public static void Main(string[] args) {

        var nums = new List<int> { 10, 6, 22, -7, 3 };

        Console.WriteLine("Highest foreach: " + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
        Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));

    }
}

