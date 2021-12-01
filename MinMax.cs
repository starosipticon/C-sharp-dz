using System;

namespace _1._12._21
{
    class Program
    {
        static void MinmaxSeq(ref int ma,ref  int mi)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                if (a > ma)
                { ma = a; }
                if (a < mi)
                { mi = a; }
                a = Convert.ToInt32(Console.ReadLine());
            }
            return;
        }
        static void Main(string[] args)
        {
            int ma = -100000, mi = 100000;
            MinmaxSeq(ref ma, ref mi);
            Console.WriteLine("minimum="+mi +" maximum="+ ma);
            return;
        }
    }
}
