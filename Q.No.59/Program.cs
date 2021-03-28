using System;

namespace Q.No._59
{
    class Program
    {
        static void Main(string[] args)
        {
            // (a)
            int a= 22/8;
            Console.WriteLine(a);

            // (b)
            int b= 99/8+21/11*7;
            Console.WriteLine(b);

            // (c)
            double c= 2/4 - 8/3;
            Console.WriteLine(c);

            // (d)
            double d= 8/6 + 2/3;
            Console.WriteLine(d);

            // (e)
             a= (int) 3.3 ;
            b= (int) 2.7  ;
          int  p= (int) 8.7;
          int q= (int) 5.4;
          double n= p/b +q/a;
            Console.WriteLine(n);

            // (f)
            int f= 11+7/4+98%6*3;
            Console.WriteLine(f);

            // (g)
            int g= 11/31%8*5-12;
            Console.WriteLine(g);

            // (h);
            double h=8;
            int i=5;
            a=(int) (h*i+3.0*h*h-(i%3)*h*h*h);
            Console.WriteLine(a);

            // (i)
            h=5;
            i=9;
            a= (int) ((i%2)*h+6.0*h*(i%3)+(i%4)*h*h*h);
            Console.WriteLine(a);

            // (j)
            a=6;
            b=2;
            c=3;
            c*=a+b;
            a--;
            c%=a;
            Console.WriteLine(c);

            // (k)
            b=5;
            a=0;
            ++b;
            a=--b;
            b=b-a;
            Console.WriteLine(b);
        }
    }
}
