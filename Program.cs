using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics");
            
            Console.WriteLine(MaximumNumbers.MaxNumber(64, 53, 32));
            Console.WriteLine(MaximumNumbers.MaxNumber(43, 443, 32));
            Console.WriteLine(MaximumNumbers.MaxtNumber(33, 53, 93));


        }
    }
}
