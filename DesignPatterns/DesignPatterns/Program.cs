using DesignPatterns.Abstract_Factory;
using DesignPatterns.Builder;
using DesignPatterns.Fluent_Builder;
using DesignPatterns.Prototype;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {

        public static void ExecuteBuilder()
        {
            var builder = new MainBuilder();
            builder.ExecuteBuilder();
        }
        public static void ExecuteFluentBuilder()
        {
            var fluentBuilder = new MainFluentBuilder();
            fluentBuilder.ExecuteFuentBuilder();
        }
        public static void ExecuteStrategy()
        {
            Console.WriteLine("ESTO ES UNA PRUEBA DEL PATRON Estrategia");
            var strategy = new ShoppingCart(new CreditCardPayment()).Pay();
            Console.WriteLine(strategy);
            Console.ReadLine();
            var PayPalStrategy = new ShoppingCart(new PaypalPayment()).Pay();
            Console.WriteLine(PayPalStrategy);
            Console.ReadLine();
        }

        public static void ExecuteFactory()
        {
            Console.WriteLine("ESTO ES UNA PRUEBA DEL PATRON ABSTRACT FACTORY");

            ICoche iCoche = new CocheGas();
            Console.WriteLine(iCoche.CrearCoche());

            Console.ReadLine();
        }

        public static void ExecuteFactoryMethod()
        {

        }

        public static void ExecutePrototype()
        {
            var prototype = new MainPrototipe();
            prototype.ExecutePrototype();
        }

        public static void ChooseTypePattern()
        {
            Console.Clear();
            Console.WriteLine("1.- Patrones Creacionales");
            Console.WriteLine("2.- Patrones Estructurales");
            Console.WriteLine("3.- Patrones de comportamiento");
            Console.WriteLine("S.- Salir del programa");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Program.CreationalPatterns();
                    break;
                case "2":
                    Program.StructuralPatterns();
                    break;
                case "3":
                    Program.ConductPatterns();
                    break;
                case "S":
                    break;
                default:
                    ChooseTypePattern();
                    break;
            }
        }

        public static void CreationalPatterns()
        {
            Console.Clear();
            Console.WriteLine("1.Abstract Factory :");
            Console.WriteLine("2.Factory Method :");
            Console.WriteLine("3.Builder :");
            Console.WriteLine("4.Fluent Builder");
            Console.WriteLine("5.Singleton");
            Console.WriteLine("6.Prototype");
            Console.WriteLine("P.-Escoger tipo de patron");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Program.ExecuteFactory();
                    break;
                case "2":
                    Program.ExecuteFactoryMethod();
                    break;
                case "3":
                    Program.ExecuteBuilder();
                    break;
                case "4":
                    Program.ExecuteFluentBuilder();
                    break;
                case "5":
                    Console.WriteLine("Sin desarrollar");
                    break;
                case "6":
                    Program.ExecutePrototype();
                    break;
                case "P":
                    ChooseTypePattern();
                    break;
                default:
                    CreationalPatterns();
                    break;
            }
        }

        public static void StructuralPatterns()
        {
            Console.Clear();
            Console.WriteLine(" 1. Adapter ");
            Console.WriteLine(" 2. Bride ");
            Console.WriteLine(" 3. Composite ");
            Console.WriteLine(" 4. Decorator ");
            Console.WriteLine(" 5. Facade ");
            Console.WriteLine(" 6. Flyweight ");
            Console.WriteLine(" 7. Proxy ");
            Console.WriteLine("Escoja una opcion de las que salen por pantalla");
            var choice = Console.ReadLine();

            switch (choice)
            {
                default:
                    ChooseTypePattern();
                    break;
            }
        }

        public static void ConductPatterns()
        {
            Console.Clear();
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
            var choice = Console.ReadLine();
            switch (choice)
            {
                default:
                    ChooseTypePattern();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program.ChooseTypePattern();
        }
    }
}
