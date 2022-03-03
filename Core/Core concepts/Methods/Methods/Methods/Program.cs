using System;
namespace Methods;

class Program
{
    public static void Main(String[] args)
    {

        //////seed with the current time in ticks
        ////var rand = new Random();
        ////var randSeeded = new Random(42);
        ////var between1and10 = randSeeded.Next(1,11);
        //////Console.WriteLine(between1and10); 


        ////var rollDice1 = rand.Next(1, 7);


        ////Console.WriteLine($"{rollDice1}");
        var myPizza = OrderPizza(anchovies: true, pineapple: false);
        var myPizza2 = OrderPizza2(anchovies: true, pineapple: false);
        Console.WriteLine(myPizza2);

    }


    public static String OrderPizza(bool anchovies, bool pineapple, bool mushroom = false)
    {
        var pizza = "Pizza with base of tomato sauce, cheese";

        if (anchovies) pizza += "anchovies, ";
        if (pineapple) pizza += "pineapple, ";
        if (mushroom) pizza += "mushroom";

        return pizza;
    }

    public static string OrderPizza2(bool anchovies, bool pineapple, bool mushroom = false)
    {
        ConsoleKeyInfo c;
        var myPizza = "Pizza with base of tomato sauce, cheese, ";

        Console.WriteLine("Please enter the numbers accordingly to select toppings, and press Esc when you're finished. : ");
        Console.WriteLine("1: Anchovies");
        Console.WriteLine("2: Pineapple");
        Console.WriteLine("3. Mushroom");
        do
        {
            int toppings = int.Parse(Console.ReadLine());
            c = Console.ReadKey();
            
            switch (toppings)
            {
                case 1:
                    myPizza += "anchovies, ";
                    break;
                case 2:
                    myPizza += "pineapple, ";
                    break;
                case 3:
                    myPizza += "mushroom";
                    break;

            }
            return myPizza;
        }
        while (c.Key != ConsoleKey.Escape);


    }
}