using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
   
    public class AutorRepository
    {
        private SqlConnection Conexion;
        private SqlDataAdapter reader;
        private SqlCommand Comando;
        List<Autor> lista;
        public AutorRepository(SqlConnection conexion) 
        {
            this.Conexion = conexion;

        }

        public string GuardarAutor(Autor autor) {
            string respuesta = "";
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "insert into autor(codigo, nombre) values(@codigo,@nombre)";
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = autor.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = autor.nombre;
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO guardo el autor";

            }
            return respuesta;
        }

        private Autor MapearAutor(SqlDataReader reader)
        {
            Autor autor = new Autor();

            autor.idautor = (int)reader["idautor"];
            autor.codigo = (string)reader["codigo"];
            autor.nombre = (string)reader["nombre"];

            return autor;
        }
        public IList<Autor> ConsultarAutor()
        {
            lista = new List<Autor>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "select * From autor";
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Autor autor = new Autor();
                    autor = MapearAutor(reader);
                    lista.Add(autor);
                }
                return lista;
            }
        }
        public Autor BuscarAutor(Autor autor)
        {
            foreach (Autor item in ConsultarAutor())
            {
                if (EsEncontrado(item, autor))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Autor item, Autor autor)
        {
            return item.codigo == autor.codigo;
        }
        public string EditarAutor(Autor autor)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update autor set codigo = @codigo, nombre = @nombre where idautor = @idautor";


                Comando.Parameters.Add("@idautor", SqlDbType.Int).Value = autor.idautor;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = autor.codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = autor.nombre;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Edito el autor";
            }
            return respuesta;
        }

        public string Eliminar(Autor autor)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from autor where idautor = @idautor";
                Comando.Parameters.Add("@idautor", SqlDbType.Int).Value = autor.idautor;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Elimino el autor";
            }
            return respuesta;
        }
    }
}