using System;

namespace DesignPatterns.Fluent_Builder
{
    public class MainFluentBuilder
    {
        public void ExecuteFuentBuilder()
        {
            var car = CarBuilder
                .CreateBuilder()
                .AddName("Ford")
                .AddModel("Focus")
                .Build();

            Console.WriteLine("El coche es "+ car.Name + " y el modelo del coche es " + car.Model);
            Console.ReadLine();
        }
    }
}
