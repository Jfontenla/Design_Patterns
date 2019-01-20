using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuidDoors()
        {
            vehicle["doors"] = "5";
        }

        public override void BuilderEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuilderWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }
    }
}
