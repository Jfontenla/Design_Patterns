using DesignPatterns.Abstract_Factory;
using DesignPatterns.Builder;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MainBuilder();
            builder.ExecuteBuilder();
        }

        public void ExecuteStrategy()
        {
            Console.WriteLine("ESTO ES UNA PRUEBA DEL PATRON Estrategia");
            var strategy = new ShoppingCart(new CreditCardPayment()).Pay();
            Console.WriteLine(strategy);
            Console.ReadLine();
            var PayPalStrategy = new ShoppingCart(new PaypalPayment()).Pay();
            Console.WriteLine(PayPalStrategy);
            Console.ReadLine();
        }
        
        public void ExecuteFactiry()
        {
            Console.WriteLine("ESTO ES UNA PRUEBA DEL PATRON ABSTRACT FACTORY");

            ICoche iCoche = new CocheGas();
            Console.WriteLine(iCoche.CrearCoche());

            Console.ReadLine();
        }

        public void ChooseTypePattern()
        {
            Console.WriteLine("1.- Patrones Creacionales");
            Console.WriteLine("2.- Patrones Estructurales");
            Console.WriteLine("3.- Patrones de comportamiento");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var chice=Console.ReadLine();
        }

        public void CreationalPatterns()
        {
            Console.WriteLine("1.Abstract Factory :");
            Console.WriteLine("2.Factory Method :");
            Console.WriteLine("3.Builder :");
            Console.WriteLine("4.Fluent Builder");
            Console.WriteLine("5.Singleton");
            Console.WriteLine("6.Prototype");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var chice = Console.ReadLine();
        }

        public void StructuralPatterns()
        {
            Console.WriteLine(" 1. Adapter ");
            Console.WriteLine(" 2. Bride ");
            Console.WriteLine(" 3. Composite ");
            Console.WriteLine(" 4. Decorator ");
            Console.WriteLine(" 5. Facade ");
            Console.WriteLine(" 6. Flyweight ");
            Console.WriteLine(" 7. Proxy ");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var chice = Console.ReadLine();
        }

        public void ConductPattern()
        {
            Console.WriteLine(" 1.  Command");
            Console.WriteLine(" 2.  Chain of responsability ");
            Console.WriteLine(" 3.  Interpreter");
            Console.WriteLine(" 4.  Iterator ");
            Console.WriteLine(" 5.  Mediator ");
            Console.WriteLine(" 6.  Memento ");
            Console.WriteLine(" 7.  Observer ");
            Console.WriteLine(" 8.  State ");
            Console.WriteLine(" 9.  Strategy ");
            Console.WriteLine(" 10. Template Method ");
            Console.WriteLine(" 11. Visitor ");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var chice = Console.ReadLine();
        }
    }
}
