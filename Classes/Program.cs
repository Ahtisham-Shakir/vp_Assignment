using System;
namespace ClassesIntro
{

    class Program
    {
        static void Main(string[] args)
        {
             person person = new person();
            person.FirstName="Ahtisham";
            person.LastName="Shakir";
            person.introduce();

            calculator calculator = new calculator();
            var result = calculator.add(1,3);
            Console.WriteLine(result);
        }
    }
}
