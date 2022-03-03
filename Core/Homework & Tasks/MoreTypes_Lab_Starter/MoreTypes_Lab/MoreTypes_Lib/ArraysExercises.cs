using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            //return contents.ToArray()

            // OR 


            string[] arr = new string[contents.Count];
            for(int i =0;i<contents.Count;i++)
            {
                arr[i] = contents[i];
            }
            return arr;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {

            String[,,] arr = new String[length1, length2, length3];
            
            if (contents.Count != length1+length2+length3){
                throw new ArgumentException("Number of elements in list must match array size");
            }
            else
            {
                try
                {
                    for (int i = 0; i < length3; i++)
                    {
                        arr[0, 0, i] = contents[i];
                    }
                    for (int j = 1; j <= length2; j++)
                    {
                        arr[j, 0, 0] = contents[length3 + length2 - 1];

                    }
                    int counter = 0;
                    for (int k = 0; k < length1; k++)
                    {

                        arr[1, 0, k + 1] = contents[length3 + length2 + k]; ;
                        counter++;

                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new ArgumentException("Number of elements in list must match array size");
                }
                
            }
            return arr;
        }


        //for(int i=0;i<length1;i++)
        //{   
        //    arr[0,0,i] = contents.FirstOrDefault();
        //    contents.RemoveAt(0);
        //    for(int j = 0; j < length2; j++)
        //    {
        //        arr[j, 0, 0] = contents.FirstOrDefault();
        //        contents.RemoveAt(0);
        //        for (int k = 0; k < length3; k++)
        //        {
        //            arr[1, 0, k] = contents.FirstOrDefault();
        //            contents.RemoveAt(0);
        //        }
        //    }
        //}

        //for(int i = 0;i<contents.Count;i++)
        //{
        //    try
        //    {
        //        arr[i, 0, 0] = contents[i];
        //    }
        //    catch (IndexOutOfRangeException e)
        //    {
        //        for (int j = 0; j < contents.Count; j++)
        //        {
        //            try
        //            {
        //                arr[0, j, 0] = contents[j];
        //            }

        //            catch (IndexOutOfRangeException ex)
        //            {
        //                for (int k = 0; k < contents.Count; k++)
        //                {
        //                    try
        //                    {
        //                        arr[0, 0, k] = contents[k];
        //                    }

        //                    catch (IndexOutOfRangeException exc)
        //                    {
        //                        return arr;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}



        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            string[][] arr = new string[countRow1][];

            if (contents.Count > countRow1 + countRow2)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            else
            {
                try
                {
                    for (int i = 0; i < countRow1; i++)
                    {
                        arr[0][i] = contents[i];
                    }
                    for (int j = 0; j < countRow2; j++)
                    {
                        arr[1][j] = contents[j];
                    }
                }
                catch(IndexOutOfRangeException)
                {
                    throw new ArgumentException("Number of elements in list must match array size");
                }
            }
            return arr;
        }
    }
}
