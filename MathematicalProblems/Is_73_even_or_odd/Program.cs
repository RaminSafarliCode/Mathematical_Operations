using System;

namespace Is_73_even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 73 % 2;

            if (x == 0)
            {
                Console.WriteLine("73 is even!");
            }
            else
            {
                Console.WriteLine("73 is odd!");
            }
        }
    }
}
