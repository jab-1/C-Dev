using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            input = input.Trim().ToUpper();
            for(int i = 0; i < num; i++)
            {
                input += i;
            }
            return input;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            String input = number.ToString();
            String finalInput = input + " " + street + ", " + city + " " + postcode+".";
            return finalInput;
            
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            String input = $"You got {score} out of {outOf}: {score / (double)outOf:P1}";
            return input;
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
    
            bool isParsed = Double.TryParse(numString, out double doubleValue);

            if(!isParsed)
            {
                return -999;
            }
            return doubleValue;
            
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            throw new NotImplementedException();
        }
    }
}
