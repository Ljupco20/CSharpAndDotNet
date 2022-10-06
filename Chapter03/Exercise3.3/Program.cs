namespace Exercise3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" fizzbuzz,");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" buzz,");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" fizz,");
                }
                else
                {
                    Console.Write($" {i},");
                }
                    
            }
        }
    }
}