using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; } 
        }

        public abstract void BuildFrame();
        public abstract void BuilderEngine();
        public abstract void BuilderWheels();
        public abstract void BuidDoors();
    }
}
