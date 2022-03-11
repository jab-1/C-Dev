using System;
namespace CodeKata6;

class Program
{
    public static void Main(String[] args)
    {
        int[] list = {-1, -22, 23, 44, 2, 100, -101, 1 };
        List<int> arr = ClosestFromZero(list);
        foreach (int i in list)
        {
            Console.WriteLine(arr[0]);
        }
    }

    public static List<int> ClosestFromZero(int[] arr)
    {
        List<int> list = new List<int> { };

        int lowest = int.MaxValue;
        for(int i = 0; i < arr.Length; i++)
        {
            int value = Math.Abs(arr[i]);
            if (value < lowest)
            {
                lowest = arr[i];
                list.Add(i);
            }
            else if (value == lowest)
            {
                list.Add(i);


            }
        }
        return list;
    }
}