using System;
using static System.Console;

namespace Exercise3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
             
                if (i>254)
                {
                    WriteLine($"The byte value of i can be max value of {i}");
                    break;
                }
                WriteLine($"The byte value of i is {i}");
            }

            // byte can have max value of 255 so it will cause overflow and go in infinite loop
        }
    }
}