using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenaderesponsabilidad {
    internal class CantidadProceso : Proceso {
        private Proceso siguiente;
        public void Procesar(Solicitud solic)
        {
            if (solic.Tipo == TipoSolicitud.Barata)
            {
                if(solic.Cantidad < 30)
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }
            Console.WriteLine("Cantidad Aprobada");
            if(this.siguiente == null)
            {
                Console.WriteLine("Proceso OK");
            } else
            {
                this.siguiente.Procesar(solic);
            }
        }
        public void SigProceso(Proceso sig)
        {
            this.siguiente = sig;
        }
    }
}
