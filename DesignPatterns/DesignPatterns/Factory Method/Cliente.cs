using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory_Method
{
    public abstract class Cliente
    {
        protected List<Pedido> pedidos = new List<Pedido>();

        protected abstract Pedido crearPedido(double importe);

        public void nuevoPedido (double importe)
        {
            var pedido = crearPedido(importe);
            if (pedido.IsValid())
            {
                pedido.Pay();
                pedidos.Add(pedido);
            }
            else
            {
                Console.WriteLine("SE RECHAZA EL PEDIDO");
            }
        }
    }
}
