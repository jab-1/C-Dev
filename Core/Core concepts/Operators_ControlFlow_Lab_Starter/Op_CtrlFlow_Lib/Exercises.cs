using System.Collections.Generic;
using System;
namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            
            double sum = 0;
            if (nums.Count != 0)
            {
                foreach (double i in nums)
                {
                    sum = sum + i;
                }
                sum /= nums.Count;
            }

            return sum;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            switch (age)
            {
                case < 5:
                    ticketType = "Free";
                    break;
                case >= 5 when age <= 12:
                    ticketType = "Child";
                    break;
                case >= 13 when age <= 17:
                    ticketType = "Student";
                    break;
                default:
                    ticketType = "Standard";
                    break;
                case >= 60:
                    ticketType = "OAP";
                    break;               
            }
            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";
            if (mark >= 0 && mark <= 100) {
                if (mark < 40)
                {
                    grade = "Fail";
                }
                else if (mark < 60)
                {
                    grade = "Pass";
                }
                else if (mark < 75) 
                {
                    grade = "Pass with Merit";
                }
                else if (mark <= 100)
                {
                    grade = "Pass with Distinction";
                }
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            if (covidLevel >= 0 && covidLevel <= 4)
            {
                switch (covidLevel)
                {
                    case 0:
                        return 200;
                    case 1:
                        return 100;
                    case 2:
                        return 50;
                    case 3:
                        return 50;
                    case 4:
                        return 20;

                }
                return 0;
            }
            else {
                Console.WriteLine("Value entered is not within acceptable bounds.");
                return -1; 
            }
        }
    }
}
