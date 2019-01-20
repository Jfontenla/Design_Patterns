using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class MainBuilder
    {
        public void ExecuteBuilder()
        {
            //create director
            var shop = new Shop();
            //create builders
            var carBuilder = new CarBuilder();
            var motorCycle = new MotorCycleBuilder();

            //Construct products
            shop.Construct(carBuilder);
            carBuilder.Vehicle.Show();
            Console.ReadLine();
            shop.Construct(motorCycle);
            motorCycle.Vehicle.Show();
            Console.ReadLine();

        }
    }
}
