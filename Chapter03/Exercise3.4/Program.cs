using System;


namespace Exercise3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			

            
			try
			{
                Console.WriteLine("Please enter a number between 0 and 255");
                byte num1 = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Please enter another number between 0 and 255");
                byte num2 = Convert.ToByte(Console.ReadLine());
                double num3 = num1 / num2;

                Console.WriteLine($"{num1} divided by {num2} equals {num3}");
            }
			catch (FormatException)
			{

				Console.WriteLine("Input string was not in a correct format.");
			};

            
        }
    }
}