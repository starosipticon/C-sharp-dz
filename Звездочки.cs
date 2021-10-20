using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int m = int.Parse(Console.ReadLine());
            
            for ( i = 1; i <= m; i++)
            {
                for ( j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();

        }
    }


}
