using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenaderesponsabilidad {
    internal class CalidadProceso : Proceso {
        private Proceso siguiente;
        public void Procesar(Solicitud solic) {
            if (solic.Tipo != TipoSolicitud.Urgente) {
                if (solic.Calidad <= 2) {
                    Console.WriteLine("Calidad muy baja");
                    return;
                }
            }
            Console.WriteLine("Calidad Aprobada");
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
