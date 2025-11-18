using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estado {
    internal class Documento {
        public string Nombre { get; set; }
        private EstadoDoc estado;

        public Documento(string nombre) {
            Nombre = nombre;
            CambiaEstado(new BorradorEstadoDoc(this));
        }

        public void Mostrar() {
            estado.Mostrar();
        }
        public void Publicar() {
            estado.Publicar();
        }
        public void CambiaEstado(EstadoDoc nuevoEstado) {
            this.estado = nuevoEstado;
        }
    }
}
