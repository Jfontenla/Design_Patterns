using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Aqui se esta aplicando un Singleton con el objetivo de asegurar que una clase solo tiene una instancia de esta clase.
    /// </summary>
    public class DocumentacionEnBlanco : Documentacion
    {
        private static DocumentacionEnBlanco _instance = null;

        private DocumentacionEnBlanco()
        {
            ListaDocumentos = new List<Documento>();
        }

        public static DocumentacionEnBlanco Instance()
        {
            if (_instance == null)
            {
                _instance = new DocumentacionEnBlanco();
            }
            return _instance;
        }

        public void incluye (Documento doc)
        {
            ListaDocumentos.Add(doc);
        }

        public void excluye (Documento doc)
        {
            ListaDocumentos.Remove(doc);
        }
    }
}
