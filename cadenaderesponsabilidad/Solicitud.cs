using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenaderesponsabilidad {
    internal class Solicitud {
        public string Descripcion {  get; set; }
        public TipoSolicitud Tipo { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }
        public int Calidad{ get; set; }

        public Solicitud(string descripcion, TipoSolicitud tipo, int cantidad, double peso, int calidad) {
            Descripcion = descripcion;
            Tipo = tipo;
            Cantidad = cantidad;
            Peso = peso;
            Calidad = calidad;
        }
    }
}
