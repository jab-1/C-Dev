//Write a method which takes a number of day, and returns the number of weeks and leftover days it represents as a string.
using System;
using System.Text;
namespace CodeKata2;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(NumberOfWeeksAndDays(8)); 
    }
    
    public static String NumberOfWeeksAndDays(int num)
    {
        int weeks = num / 7;
        int days = num % 7;
        return $"{weeks} week(s) and {days} day(s).";


    }
}