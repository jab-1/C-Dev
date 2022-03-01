using System;
namespace ExceptionApp;
public class Program
{
    public static void Main(String[] args)
    {
        //string text;
        //string fileName = "";

        //try
        //{
        //    text = File.ReadAllText(fileName);
        //    Console.WriteLine(text);
        //}

        //catch (FileNotFoundException e)
        //{
        //    Console.WriteLine("Unable to locate " + fileName);
        //}
        //catch (ArgumentException e)
        //{
        //    Console.WriteLine("File is empty.");
        //}
        //finally
        //{
        //    Console.WriteLine("I'm always run whatever happens");
        //}
        try
        {
            Console.WriteLine("Mark 1: 82" + Grade(82));
            // Console.WriteLine("Mark 2: -83" + Grade(-83));

        }
        catch (GradeException e)
        {

            Console.WriteLine("Invalid data");
            Console.WriteLine(e.Message);
        }

        catch (ExceptionGreaterThanMaxValue ex) { 
            
        }
    }

    public static string Grade(int mark) {
        if (mark > 0 || mark > 100) throw new GradeException("allowed range = 0-100");
        if (mark > 100) throw new ExceptionGreaterThanMaxValue("Value above 100");
        return mark >= 65 ? (mark  >= 85 ? "Distinction" : "Pass") : "Fail";
    }




}
