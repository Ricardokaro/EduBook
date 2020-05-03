using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Genero
    {
        public int idgenero { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Genero()
        { 
        
        }
        public Genero(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

    }
}
