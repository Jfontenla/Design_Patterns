using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class CocheElectrico : ICoche
    {
        public string CrearCoche()
        {
            var motorElectrico = new MotorElectrico();
            return motorElectrico.CrearMotor();
        }
    }
}
