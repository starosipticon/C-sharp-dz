using System;

namespace _1._12._21
{
    class Program
    {
        static void Perimeter(int x, int y, int z)
        {
            int Per;
            Per = x + y + z;
            Console.WriteLine(Per);
            return;
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Perimeter(x, y, z);
        }
    }
}
