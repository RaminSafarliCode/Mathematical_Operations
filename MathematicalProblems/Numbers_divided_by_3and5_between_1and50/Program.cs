using System;

namespace Numbers_divided_by_3and5_between_1and50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)   
            
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                } 
        }
    }
}
