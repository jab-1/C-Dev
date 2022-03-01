using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            try
            {
                if (num > short.MaxValue) {
                    throw new OverflowException();
                }
                return (short)num;
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
                throw e;
            }
            
        }

        public static long FloatToLong(float num)
        {

            float a = (float)Math.Round(num);
            return (long)a;
        }
    }
}
