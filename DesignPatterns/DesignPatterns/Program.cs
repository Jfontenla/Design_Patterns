using DesignPatterns.Abstract_Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESTO ES UNA PRUEBA DEL PATRON ABSTRACT FACTORY");

            ICoche iCoche = new CocheGas();
            Console.WriteLine( iCoche.CrearCoche());

            Console.ReadLine();
        }
    }
}
