using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class MotorDiesel : MotorCoche
    {
        public override string CrearMotor()
        {
            return "Mi motor es DIESEL";
        }
    }
}
