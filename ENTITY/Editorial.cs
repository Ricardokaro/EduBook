using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Editorial
    {
        public int ideditorial { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Editorial()
        {
        }

        public Editorial(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
