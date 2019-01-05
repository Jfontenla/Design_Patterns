using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    class MotorElectrico : MotorCoche
    {
        public override string CrearMotor()
        {
            return "Mi motor es ELECTRICO";
        }
    }
}
