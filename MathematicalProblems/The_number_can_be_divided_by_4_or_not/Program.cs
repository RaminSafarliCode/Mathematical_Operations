using System;

namespace The_number_can_be_divided_by_4_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 48;

            int x = a % 4;

            if (x == 0)
            {
                Console.WriteLine(a + " can be divided by 4!");
            }
            else
            {
                Console.WriteLine(a + " cannot be divided by 4!");
            }
        }
    }
}
