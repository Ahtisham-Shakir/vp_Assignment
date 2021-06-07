using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flag = new bool[3];
            flag[0]= true;
            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[1]);
            Console.WriteLine(flag[2]);

            var names = new string [3] { "Ahtisham", "Shakir", "Waleed"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
