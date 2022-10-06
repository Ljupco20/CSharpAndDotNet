using System;
using static System.Console;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");

            string? input = ReadLine();

            try
            {
                byte age = byte.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch(OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
                
            }
            WriteLine("After parsing");



        }
    }
}