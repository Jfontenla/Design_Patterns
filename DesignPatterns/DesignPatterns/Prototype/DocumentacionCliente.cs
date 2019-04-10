using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class DocumentacionCliente : Documentacion
    {
        public DocumentacionCliente(string informacion)
        {
            ListaDocumentos = new List<Documento>();
            DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
            IList<Documento> documentosEnBlanco = documentacionEnBlanco.ListaDocumentos;
            foreach (Documento documento in documentosEnBlanco)
            {
                Documento copiaDocumento = documento.Duplica();
                copiaDocumento.Relleno(informacion);
                ListaDocumentos.Add(copiaDocumento);
            }
        }

        public void visualiza()
        {
            foreach(Documento documento in ListaDocumentos)
            {
                documento.visualiza();
            }
        }

        public void imprime()
        {
            foreach(var documento in ListaDocumentos)
            {
                documento.imprime();
            }
        }
    }
}
