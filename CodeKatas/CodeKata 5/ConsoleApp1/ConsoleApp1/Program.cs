using System;
namespace CodeKata5;

class CodeKata5{
    public static void Main(String[] args)
    {
        int[] arr = { 1, 3, 10, 2, 0, 88 };
        int secondLargest = SecondLargestInArray(arr);
        Console.WriteLine(secondLargest);
    }

    public static int SecondLargestInArray(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length-2];
    }
}