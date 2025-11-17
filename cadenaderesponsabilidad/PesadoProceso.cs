using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenaderesponsabilidad {
    internal class PesadoProceso : Proceso {
        private Proceso siguiente;
        public void Procesar(Solicitud solic) {
            if (solic.Tipo == TipoSolicitud.Normal) {
                if (solic.Peso > 20) {
                    Console.WriteLine("Peso excesivo");
                    return;
                }
            }
            Console.WriteLine("Peso Aprobado");
            if (this.siguiente == null) {
                Console.WriteLine("Proceso OK");
            } else {
                this.siguiente.Procesar(solic);
            }
        }

        public void SigProceso(Proceso sig) {
            this.siguiente = sig;
        }
    }
}
