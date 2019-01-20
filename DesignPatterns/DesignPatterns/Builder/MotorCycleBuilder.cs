using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        public override void BuidDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuilderEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuilderWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }
    }
}
