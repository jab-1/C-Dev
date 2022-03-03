using System;
using System.Text;
namespace MoreDataTypes;

class Program
{
 

    public static void Main(String[] args) 
    { 
        var myString = (" C# list fundamentals");
        //Console.WriteLine(StringExercise(myString));
        Console.WriteLine(StringBuilderExercise(myString));

    }
    //trim off any leading spaces from myString
    //all characters to uppercase
    //replace L and T with *
    //find index of n occurs and remove all characters after 
    private static String StringExercise(String myString)
    {
        int indexOfN = myString.IndexOf("n");

        myString = myString.ToUpper();
        myString = myString.Trim();
        myString = myString.Substring(0, indexOfN);
        myString = myString.Replace('L', '*');
        myString = myString.Replace('T', '*');

        Console.WriteLine(myString);
        return myString;
    }

    public static String StringBuilderExercise(String myString) 
    {
        var myTrimmedUpperString = myString.Trim().ToUpper();
        var indexOfn = myTrimmedUpperString.IndexOf("N");
        StringBuilder sb = new StringBuilder(myTrimmedUpperString);
        sb.Replace('L', '*').Replace('T', '*');
        sb.Remove(indexOfn + 1, sb.Length - indexOfn - 1);
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }
}
