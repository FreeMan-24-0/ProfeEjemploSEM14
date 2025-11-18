using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estado
{
    internal class ModeracionEstado : EstadoDoc
    {
        private Documento documento;
        public ModeracionEstado(Documento documento)
        {
            this.documento = documento;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Imprime {documento.Nombre} en Moderacion");
        }
        public void Publicar()
        {
            documento.CambiaEstado(new PublicadoEstadoDoc(documento));
            Console.WriteLine($"Se aceptó y se envia {documento.Nombre} a Publicacion");
        }
    }
}
