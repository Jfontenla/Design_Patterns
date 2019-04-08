using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory_Method
{
    public class ClienteContado : Cliente
    {
        public ClienteContado()
        {
        }

        protected override Pedido crearPedido(double importe)
        {
            return new PedidoContado(importe);
        }
    }
}
