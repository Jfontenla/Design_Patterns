using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class MotorGas : MotorCoche
    {
        public override string CrearMotor()
        {
            return "Mi motor funciona con GAS";
        }
    }
}
