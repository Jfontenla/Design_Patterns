using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Fluent_Builder
{
    public class CarBuilder
    {
        private Car _car;
        

        private CarBuilder()
        {
            _car = new Car();
        }

        public static CarBuilder CreateBuilder()
        {
           return new CarBuilder();
        }

        public CarBuilder AddName(string name)
        {
            _car.Name = name;
            return this;
        }
        public CarBuilder AddModel (string model)
        {
            _car.Model = model;
            return this;
        }
        public Car Build()
        {
            return _car;
        }
    }

    public class Car
    {
        #region Construnctors
        public Car()
        {
        }

        public Car(string name, string model)
        {
            Name = name;
            Model = model;
        }
        #endregion
        #region Properties

        public string Name { get; set; }
        public string Model { get; set; } 
        #endregion

    }
}
