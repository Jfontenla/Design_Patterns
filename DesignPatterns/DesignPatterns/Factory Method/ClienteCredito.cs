using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory_Method
{
    public class ClienteCredito : Cliente
    {
        protected override Pedido crearPedido(double importe)
        {
            return new PedidoCredito(importe);
        }
    }
}
