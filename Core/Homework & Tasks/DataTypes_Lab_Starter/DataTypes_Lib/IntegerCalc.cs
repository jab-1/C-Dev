﻿using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0 )
            {
                throw new OverflowException();
            }
            return num1 + num2;

        }

        public static int Subtract(int num1, int num2)
        {
             throw new NotImplementedException();
        }

        public static int Multiply(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public static int Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public static int Modulus(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}