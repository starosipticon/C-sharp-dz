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
            int P = 1;
            int i = 1;

            do

            {

                P *= i;
                ++i;

            }
            while (i <= n);

            Console.WriteLine(P);

            Console.ReadKey();


        }
    }


}
