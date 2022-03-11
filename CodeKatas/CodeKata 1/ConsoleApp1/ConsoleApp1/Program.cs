//Create a method which takes a String and returns the number of vowels in that string.
using System;
namespace CodeKata1;

class Program 
{
    public static void Main(String[] args)
    {
        Console.WriteLine(NumberOfVowelsInString("This is a string of text")); 
    }
    public static int NumberOfVowelsInString(String text)
    {
        int amountOfVowels = 0;
        text = text.ToLower();
        foreach (char c in text)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                amountOfVowels++;
            }
        }
        return amountOfVowels;
    }
}