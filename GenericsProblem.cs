﻿using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class MaxNumbers
    {   
        //// UC-2 Given 3 flaot find  the maximum
        //// FOLLWOING METHOD WILL RETURN MAXMIMUM NUMBER


        public static float MaxNumber(float firstnumb, float secondnumb, float thirdnumb)
        {
            if (firstnumb.CompareTo(secondnumb) > 0 && firstnumb.CompareTo(thirdnumb) > 0)
            {
                Console.WriteLine("First number is the largest number");
                return firstnumb;
            }
            else if (secondnumb.CompareTo(firstnumb) > 0 && secondnumb.CompareTo(thirdnumb) > 0)
            {
                Console.WriteLine("Second number is the largest number");
                return secondnumb;
            }
            else if (thirdnumb.CompareTo(firstnumb) > 0 && thirdnumb.CompareTo(secondnumb) > 0)
            {
                Console.WriteLine("Third number is the largest number");
                return thirdnumb;
            }
            else
            {
                Console.WriteLine("ALL ARE EQUAL");
                return 0;
            }
        }
    }


}
