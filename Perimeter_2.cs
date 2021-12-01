using System;

namespace _1._12._21
{
    class Program
    {
        static int Perimeter(int x, int y, int z)
        {
            int Per;
            Per = x + y + z;
            return(Per);
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(Perimeter(x, y, z));
        }
    }
}
