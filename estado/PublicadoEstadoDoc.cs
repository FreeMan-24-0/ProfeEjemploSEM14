using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estado {
    internal class PublicadoEstadoDoc : EstadoDoc {
        private Documento documento;
        public PublicadoEstadoDoc(Documento documento) {
            this.documento = documento;
        }
        public void Mostrar() {
            Console.WriteLine($"Imprime {documento.Nombre} en Publicado");
        }

        public void Publicar() {
            Console.WriteLine($"Ya esta publicado {documento.Nombre}");
        }
    }
}
