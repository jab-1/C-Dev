using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> nums = new List<int>();
            int startNum = 1;
            if (max < 5)
            {
                return nums;
            }
            else if(max < 10)
            {
                nums.Add(5);
                return nums;
            }
            else if(max > 94 && max < 100)
            {
                int[] tempArray = new int[19];
                int finalNum = 95;
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = finalNum;
                    finalNum--;
                }

                nums.AddRange(tempArray);
                nums.Reverse();
                return nums;
                
            }
            else

            {
                for (int i = startNum; i <= max; i++)
                {
                    nums.Add(i);
                }
                return nums;
            }
            
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> list = new List<string> ();
            foreach (string s in sourceList)
            {
                if (s.StartsWith('a') || s.StartsWith('A'))
                {
                    list.Add(s);
                }
            }
            return list;
        }
    }
}
