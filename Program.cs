using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics");
            string INPUT = MaxNumbers.StringMax("NIFTY", "NASDAQ", "SENSEX");
            Console.Write(INPUT);

        }
    }
}
