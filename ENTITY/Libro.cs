using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
   public class Libro
   {     

        public int idlibro { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idautor { get; set; }
        public int ideditorial { get; set; }
        public int idgenero { get; set; }
        public byte[] imagen_portada { get; set; }
        public byte[] archivo_pdf { get; set; }
        public string nombre_archivo { get; set; }

        public Libro() { 
        
        }
        public Libro(int idlibro, string codigo, string nombre, string descripcion, int idautor, int ideditorial, int idgenero, byte[] imagen_portada, byte[] archivo_pdf, string nombre_archivo)
        {
            this.idlibro = idlibro;
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.idautor = idautor;
            this.ideditorial = ideditorial;
            this.idgenero = idgenero;
            this.imagen_portada = imagen_portada;
            this.archivo_pdf = archivo_pdf;
            this.nombre_archivo = nombre_archivo;
        }
    }
}
