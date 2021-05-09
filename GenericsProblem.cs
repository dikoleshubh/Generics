using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class MaxNumbers
    {   
        //// UC-2 Given 3 string find  the maximum
        //// FOLLWOING METHOD WILL RETURN MAXMIMUM STRING
                public static string StringMax(string S1, string S2, string S3) //static method
                {
                    if (S1.CompareTo(S2) > 0 && S1.CompareTo(S3) > 0)
                    { 
                
                        Console.WriteLine("First number is the largest STRING");

                        return S1;
                    }
                    else if (S2.CompareTo(S1) > 0 && S2.CompareTo(S3) > 0)
                    {
                        Console.WriteLine("SECOND number is the largest STRING");
                        return S2;
                    }
                    else if (S3.CompareTo(S1) > 0 && S3.CompareTo(S2) > 0)
                    { 
                      Console.WriteLine("THIRD number is the largest  STRING");
                      return S3;
                    }
                    else
                    {
                        
                    Console.writeline("S1,S2,S3 are Same ");
                    }
                }

             
            
        
    }


}
