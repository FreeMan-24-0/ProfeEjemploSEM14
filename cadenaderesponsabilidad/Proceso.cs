using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenaderesponsabilidad {
    internal interface Proceso {
        void SigProceso(Proceso sig);
        void Procesar(Solicitud solic);
    }
}
