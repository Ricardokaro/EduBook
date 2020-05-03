using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GeneroRepository
    {
        private SqlConnection Conexion;
        private SqlDataAdapter reader;
        private SqlCommand Comando;
        List<Genero> lista;
        public GeneroRepository(SqlConnection conexion)
        {
            this.Conexion = conexion;

        }

        public string GuardarGenero(Genero genero)
        {
            string respuesta = "";
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "insert into genero(codigo, nombre) values(@codigo,@nombre)";
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = genero.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = genero.nombre;
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO guardo el genero";

            }
            return respuesta;
        }

        private Genero MapearGenero(SqlDataReader reader)
        {
            Genero genero = new Genero();

            genero.idgenero = (int)reader["idgenero"];
            genero.codigo = (string)reader["codigo"];
            genero.nombre = (string)reader["nombre"];

            return genero;
        }
        public IList<Genero> ConsultarGenero()
        {
            lista = new List<Genero>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "select * From genero";
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Genero genero = new Genero();
                    genero = MapearGenero(reader);
                    lista.Add(genero);
                }
                return lista;
            }
        }
        public Genero BuscarGenero(Genero genero)
        {
            foreach (Genero item in ConsultarGenero())
            {
                if (EsEncontrado(item, genero))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Genero item, Genero genero)
        {
            return item.codigo == genero.codigo;
        }
        public string EditarGenero(Genero genero)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update genero set codigo = @codigo, nombre = @nombre where idgenero = @idgenero";


                Comando.Parameters.Add("@idgenero", SqlDbType.Int).Value = genero.idgenero;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = genero.codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = genero.nombre;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Edito el genero";
            }
            return respuesta;
        }

        public string Eliminar(Genero genero)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from genero where idgenero = @idgenero";
                Comando.Parameters.Add("@idgenero", SqlDbType.Int).Value = genero.idgenero;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Elimino el genero";
            }
            return respuesta;
        }
    }
}
