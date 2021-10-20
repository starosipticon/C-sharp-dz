using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                S += i;

            }

            Console.WriteLine(S);

            Console.ReadKey();


        }
    }


}
