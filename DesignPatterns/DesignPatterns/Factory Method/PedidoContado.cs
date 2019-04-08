using System;

namespace DesignPatterns.Factory_Method
{
    public class PedidoContado : Pedido
    {
        public PedidoContado(double Importe) : base(Importe)
        {
        }

        public override bool IsValid()
        {
            return true;
        }

        public override void Pay()
        {
            Console.WriteLine("El pago del pedido por impore de : "+ Importe +" se ha realizado.");
        }
    }
}
