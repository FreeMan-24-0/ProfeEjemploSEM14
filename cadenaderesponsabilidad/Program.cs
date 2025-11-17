// See https://aka.ms/new-console-template for more information

using cadenaderesponsabilidad;

Proceso p = new PesadoProceso();
Proceso p2 = new CantidadProceso();
Proceso p3 = new CalidadProceso();
p.SigProceso(p2);
p2.SigProceso(p3);

Solicitud s = new Solicitud("pedido 1",TipoSolicitud.Barata,25, 10, 1);
p.Procesar(s);

