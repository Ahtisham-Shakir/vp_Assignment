using System;

namespace Q.No._53
{
    class Program
    {
        static void Main(string[] args)
        {
            //  (a)
            int x=20, y=35;
            x=y++ + x++;
            y=++y + ++x;
            Console.Write(x);
            Console.WriteLine(y);
            
            //  (b)
            int a=10, b=15;
            a=a++;
            b=++b;
            Console.WriteLine(a + ","+ b);
            //  (c)

            int c=10;
            c++;
            Console.WriteLine(c);

            // (d)
            int d=10;
            Console.WriteLine(d++);

            // (e)
            int e=10, f=0;
            f= e--;
            Console.WriteLine(f);

            // (f)
            int i=5, j=6, k=7, n=3;
            Console.WriteLine(i+j*k-k%n);
            Console.WriteLine(i/n);

            //  (g)
            int g;
            float h=3.8F;
            g=(int) h;
            Console.WriteLine("g=" + g);

            // (h)
            int m=6;
            Console.Write(m);
            m=m+3;
            Console.Write(m);
            m-=5;
            Console.Write(m);
            m++;
            Console.WriteLine(m);

        }
    }
}
