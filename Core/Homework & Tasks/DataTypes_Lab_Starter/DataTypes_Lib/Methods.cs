using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {
            if (n > 0) 
            {
                long sum = 1;
                for (int i = 1; i <= n; i++)
                {
                    sum *= i;
                }
                return sum;
            }
            return 0;
            //throw new NotImplementedException();
        }

        public static decimal Mult(float num1, float num2)
        {
            return (decimal)num1 * (decimal)num2;
        }
    }
}
