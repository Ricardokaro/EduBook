using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class UsuarioRepository
    {
        private SqlConnection Conexion;
        private SqlDataAdapter reader;
        private SqlCommand Comando;
        List<Usuario> lista;
        public UsuarioRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string GuardarUsuario(Usuario usuario)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            { 
                Comando.CommandText = "Insert Into Usuario (tipo_documento, num_documento, nombre, apellidos, genero, edad, email, foto_perfil, tipo_usuario, password) values " +
                    "(@tipo_documento, @num_documento, @nombre, @apellidos, @genero, @edad, @email, @foto_perfil, @tipo_usuario,@password)";
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = usuario.tipoDocumento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = usuario.numeroDocumento;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.nombre;
                Comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = usuario.apellidos;
                Comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = usuario.genero;
                Comando.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.edad;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.email;
                Comando.Parameters.Add("@foto_perfil", SqlDbType.Image).Value = usuario.fotoPerfil;
                Comando.Parameters.Add("@tipo_usuario", SqlDbType.VarChar).Value = usuario.tipoUsuario;
                Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = usuario.password;      

                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO guardo el usuario";
                
            }
            return respuesta;
        }
        private Usuario MapearUsuario(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.idusuario = (int)reader["idusuario"];
            usuario.tipoDocumento = (string)reader["tipo_documento"];
            usuario.numeroDocumento = (string)reader["num_documento"];
            usuario.nombre = (string)reader["nombre"];
            usuario.apellidos = (string)reader["apellidos"];
            usuario.genero = (string)reader["genero"];
            usuario.edad = (int)reader["edad"];
            usuario.email = (string)reader["email"];
            usuario.fotoPerfil = (byte[])reader["foto_perfil"];
            usuario.tipoUsuario = (string)reader["tipo_usuario"];
            usuario.password = (string)reader["password"];
            usuario.inicio_session = (bool)reader["inicio_session"];

            return usuario;
        }
        public IList<Usuario> ConsultarUsuario()
        {
            lista = new List<Usuario>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * From Usuario";
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario = MapearUsuario(reader);
                    lista.Add(usuario);
                }
             return lista;
            }           
        }
        public Usuario BuscarUsuario(Usuario usuario)
        {
            foreach(Usuario item in ConsultarUsuario())
            {
                if(EsEncontrado(item, usuario))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Usuario item, Usuario usuario)
        {
            return item.numeroDocumento == usuario.numeroDocumento;
        }
        public string EditarUsuario(Usuario usuario)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update usuario set tipo_documento = @tipo_documento, num_documento = @num_documento, nombre = @nombre, apellidos = @apellidos, " +
                    "genero = @genero, edad = @edad, email = @email, foto_perfil = @foto_perfil, tipo_usuario = @tipo_usuario, password = @password  where idusuario = @idusuario";


                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario.idusuario;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = usuario.tipoDocumento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = usuario.numeroDocumento;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.nombre;
                Comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = usuario.apellidos;
                Comando.Parameters.Add("@genero", SqlDbType.VarChar).Value = usuario.genero;
                Comando.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.edad;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.email;
                Comando.Parameters.Add("@foto_perfil", SqlDbType.Image).Value = usuario.fotoPerfil;
                Comando.Parameters.Add("@tipo_usuario", SqlDbType.VarChar).Value = usuario.tipoUsuario;
                Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = usuario.password;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO guardo el usuario";
            }
            return respuesta;
        }

        public string Eliminar(Usuario usuario)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from usuario where idusuario = @idusuario";
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario.idusuario;                
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Elimino el usuario";
            }
            return respuesta;
        }

        public Usuario Login(Usuario usuario)
        {
            foreach (Usuario item in ConsultarUsuario())
            {
                if (item.numeroDocumento == usuario.numeroDocumento && item.password == usuario.password)
                {
                    return item;
                }
            }
            return null;
        }

        public bool GuardarSession(Usuario usuario)
        {
            bool respuesta = false;
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update usuario set inicio_session = @inicio_session where idusuario = @idusuario";
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = usuario.idusuario;
                Comando.Parameters.Add("@inicio_session", SqlDbType.Bit).Value = usuario.inicio_session;
                respuesta = Comando.ExecuteNonQuery() == 1 ? true : false;
            }
            return respuesta;
        }

        public bool EliminarSession()
        {
            bool respuesta = false;
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update usuario set inicio_session = @inicio_session";
                Comando.Parameters.Add("@inicio_session", SqlDbType.Bit).Value = false;
                respuesta = Comando.ExecuteNonQuery() == 1 ? true : false;
            }
            return respuesta;
        }

        public Usuario ConsultarSession() 
        {            
            using (var Comando = Conexion.CreateCommand())
            {
                Usuario usuario = null;
                Comando.CommandText = "Select * From Usuario";
                SqlDataReader reader = Comando.ExecuteReader();                
                while (reader.Read())
                { 
                    if ((bool)reader["inicio_session"]) {
                        usuario = new Usuario();
                        usuario = MapearUsuario(reader);
                    }
                }
                return usuario;
            }
        }
    }    
}
