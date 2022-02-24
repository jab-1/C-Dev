using System;
using System.Collections.Generic;

namespace TestFirstExercises
{
    public class Methods
    {
        // implement this method so that it returns true if x is greater than or equal to y
        public static bool GreaterEqual(int x, int y)
        {
            if (x >= y)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        // Implement this method so that it take an int as an input,
        // squares it, adds 101, divides the result by 7, then subtracts 4.  
        // Return a double rounded to 3 decimal places.
        public static double BODMAS(int inputNumber)
        {
            //using Math.Round which takes an integer and another number which represents how many digits after the decimal point.
            double squared = Math.Pow(inputNumber, 2);
            double formula = ((squared + 101) / 7) - 4;
            return Math.Round(formula, 3);
            
        }

        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            // using % = the modulus, checking if a remainder exists. if 0 then even.
            if (num % 2 == 0)
            {
                return true;
            }
            else {
                return false;
            }
            
        }

        // implement this method so that it returns 
        // the sum of all numbers between 1 and n inclusive 
        // that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            // again using math operator for the modulus, if it is divisble by 2 or 5 it would add to the counter.
            var counter = 0;
            if (max < 0)
            {
                return counter;
            }
            else
            {
                var arr = new int[max];
                for (int i = 1; i <= max; i++)
                {
                    if (i % 2 == 0)
                    {
                        counter += i;
                    }
                    else if (i % 5 == 0)
                    {
                        counter += i;
                    }
                }
            }
            return counter;
        }

        // implement this method so it returns true if input is "password"
        // regardless of case
        public static bool CheckInput(string input)
        {
            // checks if the input is == "password" by forcing all lowercase whilst doing so. 
            if (input.ToLower().Equals("password")){
                return true;
            }
            return false;
        }

        // implement this method so it returns the sum
        // of all the numbers in the list
        public static int SumList(List<int> list)
        {
            // iterates through the arraylist and adds each to integer sum.
            int sum = 0;
            foreach (int i in list){
                sum += i;
            }

            return sum;
        }
    }
}