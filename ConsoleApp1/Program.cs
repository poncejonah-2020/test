using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Persona p = new Persona();
            p.setNombre("jonah");
            p.setEdad(30);
            p.presentar();
            Console.ReadLine();
        }
    }
}
