using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 6;
            for (int i =2; i <= n; i++)
            {
                for (int j=2; j <= n; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                    
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }


}
