using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class PrintArray
    {
        public static void ToPrintInteger(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + "\t");
            }
        }
        public static void ToPrintDouble(double[] arr)
        {
            foreach (double element in arr)
            {
                Console.Write(element + "\t");
            }
        }

        public static void ToPrintCharacter(char[] arr)
        {
            foreach (char element in arr)
            {
                Console.Write(element + "\t");
            }
        }
    }
}
