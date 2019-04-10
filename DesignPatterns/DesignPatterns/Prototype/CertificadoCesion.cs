using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class CertificadoCesion : Documento
    {
        public override void imprime()
        {
            Console.WriteLine("Muestra el certificado de cesion " + contenido);
        }

        public override void visualiza()
        {
            Console.WriteLine("Imprime el certificado de cesion " + contenido);
        }
    }
}
