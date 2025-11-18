using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estado {
    internal class BorradorEstadoDoc : EstadoDoc {
        private Documento documento;

        public BorradorEstadoDoc(Documento documento) {
            this.documento = documento;
        }

        public void Mostrar() {
            Console.WriteLine($"Imprime {documento.Nombre} en Borrador"); 
        }

        public void Publicar() {
            documento.CambiaEstado(new ModeracionEstado(documento));
            Console.WriteLine($"Se envió {documento.Nombre} a Moderacion");
        }
    }
}
