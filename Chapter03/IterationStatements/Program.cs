using System;
using static System.Console;

namespace IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while(x < 10)
            {
                WriteLine(x);
                x++;
            }

            string? password;
            do
            {
                Write("Enter your password: ");
                password = Console.ReadLine();

            } while (true);

            for(int y = 0; y <= 10; y++)
            {
                WriteLine(y);   
            }

            string[] names = { "Adam","Barry", "Charlie"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

        }
    }
}
