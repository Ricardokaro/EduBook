using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public int idusuario { get; set; }        
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string genero { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public byte[] fotoPerfil { get; set; }
        public string tipoUsuario { get; set; }
        public string password { get; set; }


        public Usuario(string tipoDocumento, string numeroDocumento, string nombre, string apellidos, string genero
            , int edad, string email,byte[] fotoPerfil, string tipoUsuario, string password)
        {
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.genero = genero;
            this.edad = edad;
            this.email = email;
            this.fotoPerfil = fotoPerfil;
            this.tipoUsuario = tipoUsuario;
            this.password = password;
        }
        public Usuario()
        {
                
        }
    }
}
