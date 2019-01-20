using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuilderEngine();
            vehicleBuilder.BuilderWheels();
            vehicleBuilder.BuidDoors();
        }
    }
}
