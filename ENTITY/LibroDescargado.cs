using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class LibroDescargado
    {
        public int idlibro_descargado { get; set; }
        public int idlibro { get; set; }
        public int idusuario { get; set; }
        public DateTime fecha { get; set; }
    }
}
