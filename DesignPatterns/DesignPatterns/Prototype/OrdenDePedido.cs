using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class OrdenDePedido : Documento
    {
        public override void imprime()
        {
            Console.WriteLine("Muestra la orden de pedido " + contenido);
        }

        public override void visualiza()
        {
            Console.WriteLine("Imprime la orden de pedido " + contenido);
        }
    }
}
