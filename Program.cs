// See https://aka.ms/new-console-template for more information
using System;

namespace firstappconsole
{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Introduce Nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Holaaa, " + Nombre );

            string time =  DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine(time);
        }
        
    }
}
