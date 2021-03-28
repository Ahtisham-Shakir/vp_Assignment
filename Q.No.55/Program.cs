using System;

namespace Q.No._55
{
    class Program
    {
        static void Main(string[] args)
        {
            // (a)
            int a=3, b=4;
            a=++a*b++;
            Console.WriteLine(a);

            // (b)
            int x=3, y=4;
            x=++x*++y;
            Console.WriteLine(x);

        }
    }
}
