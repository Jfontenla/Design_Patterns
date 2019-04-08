using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory_Method
{
    public class PedidoCredito : Pedido
    {
        public PedidoCredito(double Importe) : base(Importe)
        {
        }

        public override bool IsValid()
        {
            return (Importe <= 5000.0) && (Importe >= 1000.0);
        }

        public override void Pay()
        {
            Console.WriteLine("El pago del pedido a crédito de : "+ Importe +" se ha realizado.");
        }
    }
}
