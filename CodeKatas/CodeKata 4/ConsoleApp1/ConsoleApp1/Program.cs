//Create a method which takes a string and returns an array of duplicate letters
using System;
namespace CodeKata4;

class Program
{
    public static void Main(String[] args)
    {
        char[] arr = ReturnArrayOfDuplicateLetters("Nishant Mandal");
        foreach(char c in arr)
        {
            Console.WriteLine(c);
        }
            
    }

    private static char[] ReturnArrayOfDuplicateLetters(string s)
    {
        String doesContain = "";
        for(int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < s.Length; j++)
            {
                if(s[i] == s[j]){
                    count++;
                }
                if(count == 2)
                {
                    if(!doesContain.Contains(s[i]))
                        doesContain += s[i];
                }

            }
        }
        char[] arr = doesContain.ToCharArray();
        return arr;
    }
}
