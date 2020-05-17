using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class LibroVisto
    {
        public int idlibro_visto { get; set; }
        public int idlibro { get; set; }
        public int idusuario { get; set; }
        public DateTime fecha { get; set; }

        public LibroVisto()
        { 
        
        }
        public LibroVisto(int idlibro_visto, int idlibro, int idusuario, DateTime fecha)
        {
            this.idlibro_visto = idlibro_visto;
            this.idlibro = idlibro;
            this.idusuario = idusuario;
            this.fecha = fecha;
        }
    }
}
