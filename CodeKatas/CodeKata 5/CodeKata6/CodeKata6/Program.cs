using System;
namespace CodeKata6;

class Program
{
    public static void Main(String[] args)
    {
        int[] list = {-1, -22, 23, 44, 2, 100, -101 };
        Console.WriteLine(ClosestFromZero(list));
    }

    public static int ClosestFromZero(int[] arr)
    {
        int lowest = int.MaxValue;
        for(int i = 0; i < arr.Length; i++)
        {
            int value = Math.Abs(arr[i]);
            if(value < lowest)
            {
                lowest = arr[i];
            }
        }
        return lowest;
    }
}