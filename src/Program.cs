using System;
using Primo.Aplication.Class;

namespace Primo.Aplication
{
    public static class Program
    {
        public static void Main()
        {
            const string msg = "Hello, World!";
            var primo = new PrimoClass();

            var result = primo.CheckPrimo(5);

            Console.WriteLine(msg);
            Console.WriteLine(result);
        }
    }
}
