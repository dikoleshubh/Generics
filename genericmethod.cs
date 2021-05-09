using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class GenericMethod<T>
    {
        public T[] Number;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Number"></param>
        public generics(T[] Number)
        {
            this.Number = Number;

        }

        public T[] Sort(T[] Number)
        {
            Array.Sort(Number);
            return Number;
        }
        void add(params int[] a) //specify a method parameter
        {

        }

        
        public T MaximumValue(params T[] Number)
        {
            var Sorte_Number = Sort(Number);
            return Sorte_Number[Sorte_Number.Length - 1];
        }

        /// <summary>
        /// This method is created calling MaximumValue method
        />
        public T MaxMethod()
        {
            var MaxValue = MaximumValue(this.Number);
            return MaxValue;
        }

        /// <summary>
        /// This method is printing maximum generic value
        /// </summary>
        public void PrintValue()
        {
            var max = MaximumValue(this.Number);
            Console.Write(max);

        }
    }
}
