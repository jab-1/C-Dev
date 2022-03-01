using System;

namespace MoreTesting;
public class Program{

    public static void Main(String[] args)
    {

    }
    public static string GetGrade(int mark)
    {
        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }

   
} 