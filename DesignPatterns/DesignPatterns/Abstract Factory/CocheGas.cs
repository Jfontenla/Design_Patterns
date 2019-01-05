using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class CocheGas : ICoche
    {
        public string CrearCoche()
        {
            var cocheGas = new MotorGas();
            return cocheGas.CrearMotor();
        }
    }
}
