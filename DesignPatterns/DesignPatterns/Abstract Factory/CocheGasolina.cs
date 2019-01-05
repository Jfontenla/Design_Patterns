using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{

    /// <summary>
    /// Fabrica Concreta
    /// </summary>
    public abstract class CocheGasolina : ICoche
    {
        public string CrearCoche()
        {
            var motorGasolina = new MotorGasolina();
            return motorGasolina.CrearMotor();
        }
    }
}
