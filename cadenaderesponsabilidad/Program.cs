// See https://aka.ms/new-console-template for more information

using cadenaderesponsabilidad;

Proceso p = new PesadoProceso();
Proceso p2 = new CalidadProceso();
p.SigProceso(p2);

Solicitud s = new Solicitud("pedido 1",TipoSolicitud.Barata,10, 15, 1);
p.Procesar(s);

