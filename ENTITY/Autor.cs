using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Autor
    {
        public int idautor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Autor()
        { 
        }

        public Autor(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
