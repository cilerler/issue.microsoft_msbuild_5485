using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new ClassLibrary1.Class1();
            Console.WriteLine(class1.GetFile());
            Console.ReadLine();
        }
    }
}
