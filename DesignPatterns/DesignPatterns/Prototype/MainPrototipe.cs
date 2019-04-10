using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class MainPrototipe
    {
        public void ExecutePrototype()
        {
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            documentacionEnBlanco.incluye(new OrdenDePedido());
            documentacionEnBlanco.incluye(new CertificadoCesion());
            documentacionEnBlanco.incluye(new SolicitudDeMatriculacion());
            //creacion de documentacion nueva para los dos clientes
            DocumentacionCliente documentacionCliente1 = new DocumentacionCliente("Martin");
            DocumentacionCliente documentacionCliente2 = new DocumentacionCliente("Alberto");
            documentacionCliente1.visualiza();
            documentacionCliente2.visualiza();
        }
    }
}
