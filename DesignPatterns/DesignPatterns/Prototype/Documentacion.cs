using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public abstract class Documentacion
    {
        public IList<Documento> ListaDocumentos { get;protected set; }
    }
}
