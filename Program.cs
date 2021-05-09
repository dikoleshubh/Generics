using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Generics");
            //string INPUT = MaxNumbers.StringMax("NIFTY", "NASDAQ", "SENSEX");
            //Console.Write(INPUT);

            int[] Output = { 11, 22, 50, 60, 90 };
            Generic<int> genericInt = new Generic<int>(Output);//create object using int data type
            genericInt.PrintValue();
            Console.WriteLine();

            double[] Output1 = { 11.2, 22.5, 50.45, 55.92 };
            Generic<double> genericdouble = new Generic<double>(Output1);
            genericdouble.PrintValue();
            Console.WriteLine( );
            //String array
            string[] stringArray = { "11s1", "222", "333", "55", "913213" };
            Generic<string> genericString = new Generic<string>(stringArray);
            genericString.PrintValue();
            Console.Read();

        }
    }
}
