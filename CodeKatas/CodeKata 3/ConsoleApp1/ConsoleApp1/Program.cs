using System;
namespace CodeKata3;
public static class Kata
{
    public static void Main()
    {
        Console.WriteLine(Likes(new string[] { "Max", "John", "Mark" })); 
    }
    public static string Likes(string[] name)
    {
        String names = "";
        switch (name.Length)
        {
            case 0:
                names = "no one likes this";
                break;
            case 1:
                names = name[0]+" likes this";
                break;
            case 2:
                names = name[0]+" and "+name[1] + " like this";
                break;
            case 3:
                names = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                break;
            case > 3:
                names = name[0] + ", " + name[1]+" and"+" "+(name.Length-2)+" others like this";
                break;
        }


        return names;
    }
}