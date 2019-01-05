using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class CocheDiesel : ICoche
    {
        public string CrearCoche()
        {
            var motorDiesel = new MotorDiesel();
            return motorDiesel.CrearMotor();
        }
    }
}
