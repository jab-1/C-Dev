using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string s = "";
            if (num > queue.Count)
            {
                int count  = queue.Count;
                for (int i = 0; i <= count-1; i++)
                {
                    s = s + queue.Peek();
                    queue.Dequeue();
                    s = s + ", ";

                }
                return s.Substring(0, s.Length - 2);
            }
            if (num == 0)
            {
                return s;
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    s = s + queue.Peek();
                    queue.Dequeue();
                    s = s + ", ";
                }

                return s.Substring(0, s.Length - 2);
            }
            
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> stack = new Stack<int>(original.Length);
            foreach(int i in original)
            {
                stack.Push(i);
            }
            return stack.ToArray();
            //COULD ALSO create for-loop & newArrayReversed[i] = stack.Pop();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            String s = "";
            var dict = new Dictionary<char, int>();
            var charArray = input.ToCharArray();
            foreach(char c in charArray)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                    
                }
                else if(Char.IsDigit(c))
                {
                    dict.Add(c, 1);
                }
                
            }

            foreach(var k in dict)
            {
                s = s + k;
            }

            return s;
        }
    }
}
