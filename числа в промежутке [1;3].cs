using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Введите три числа");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if ((1 <= n1) & (n1 <= 3))
                Console.WriteLine($"\n{n1}");

            if ((1 <= n2) & (n2 <= 3))
                Console.WriteLine($"\n{n2}");

            if ((1 <= n3) & (n3 <= 3))
                Console.WriteLine($"\n{n3}");
            
            Console.ReadKey();
           
            




        }
    }
}
