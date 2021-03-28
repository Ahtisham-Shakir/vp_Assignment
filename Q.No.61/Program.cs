using System;

namespace Q.No._61
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=20, c=15, d=8, e=40, n;
            // 1
            n=(a+5/(c-5))/ ((d+7)/e-37)%3;
            Console.WriteLine(n);

            // (2)
            n=a+b/c-5/d+7/e-37%3;
            Console.WriteLine(n);

            // (3)
            n=a*(b*b)-(c*b)+d;
            Console.WriteLine(n);
        }
    }
}
