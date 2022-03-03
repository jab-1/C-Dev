using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            else
            {
                int weeks = totalDays / 7;
                int days = totalDays % 7;
                return (weeks, days);
            }
        }
        public static (int square, int cube, double squareRoot) PowersRoot(int num)

        {
            return (num*num, num*num*num, Math.Sqrt(num));
        }
        public static int RollDice(Random rng)
        {
            rng = new Random(100);
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            if(num1+num2 > 12)
            {
                throw new ArgumentException("Values should be between 1-12.");
            }
            return num1 + num2;
        }

    }
}
