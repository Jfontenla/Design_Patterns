using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class SolicitudDeMatriculacion : Documento
    {
        public override void imprime()
        {
            Console.WriteLine("Muestra la solicitud de matriculacion " + contenido);
        }

        public override void visualiza()
        {
            Console.WriteLine("Imprime el certificado de cesión " + contenido);
        }
    }
}
