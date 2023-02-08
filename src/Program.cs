using System;
using Primo.Aplication.Class;

namespace Primo.Aplication;

public static class Program
{
    public static void Main()
    {
        var result = new PrimoClass().ToString(11);
        Console.WriteLine(result);
    }
}