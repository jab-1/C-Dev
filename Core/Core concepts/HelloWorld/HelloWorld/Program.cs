using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World");

            //var f = Add(1, 1);
            //var g = (Add(2,2));

            //int x = 100;
            //x += 10;
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    x += i;
            //}

            //Console.WriteLine("Writing out command line arguments");
            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Enter num 1");
                var num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num 2");
                var num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Press esc to leave");
                Console.WriteLine(num1 - num2);
                key = Console.ReadKey();
                Console.WriteLine();

            } while (key.Key != ConsoleKey.Escape);

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

// camleCase: C# variable names
// _camelCase: C# private fields
// Pascal Case: Class and Method names
// kekbab-case: HTML
// name_case: SQL
