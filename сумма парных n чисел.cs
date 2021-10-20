using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int S = 0;

            for (int i = 1; i <= n; i++)

            {
                if (i % 2 == 0)
                    S += i;

            }

            Console.WriteLine(S);

            Console.ReadKey();


        }
    }


}
