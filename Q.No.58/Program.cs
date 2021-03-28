using System;

namespace Q.No._58
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2, b=3, c=5;
            // (a)
          //  ++a;
           // Console.WriteLine(a + "," + b +","+ c);

           // (c)
          // a++;
          //  Console.WriteLine(a + "," + b +","+ c);

          // (d)
         // b+=a;
          //  Console.WriteLine(a + "," + b +","+ c);

          // (e)
         // b+=a*c;
          //  Console.WriteLine(a + "," + b +","+ c);

          // (g)
         // a+=2;
          //b=2/2;
           // Console.WriteLine(a + "," + b +","+ c);

           // (i)
           b= a++ + b++;
            Console.WriteLine(a + "," + b +","+ c);
        }
    }
}
