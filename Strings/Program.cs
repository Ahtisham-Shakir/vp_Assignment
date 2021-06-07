using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstName = "Ahtisham";
            var LastName = "Shakir";
            var FullName= FirstName + " " + LastName;
            Console.WriteLine(FullName);

            var myFullName = string.Format("My name is {0} {1}", FirstName , LastName );
            Console.WriteLine(myFullName);

            var names = new string[3] { "Ahtisham", "Shakir", "Waleed"};
            var fomattedNames = string.Join(",", names);
            Console.WriteLine(fomattedNames);

            var text = "Hi, Ahtisham\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
        }
    }
}
