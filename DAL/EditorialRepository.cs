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
    public class EditorialRepository
    {
        private SqlConnection Conexion;
        private SqlDataAdapter reader;
        private SqlCommand Comando;
        List<Editorial> lista;
        public EditorialRepository(SqlConnection conexion)
        {
            this.Conexion = conexion;

        }

        public string GuardarEditorial(Editorial editorial)
        {
            string respuesta = "";
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "insert into editorial(codigo, nombre) values(@codigo,@nombre)";
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = editorial.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = editorial.nombre;
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO guardo el editorial";

            }
            return respuesta;
        }

        private Editorial MapearEditorial(SqlDataReader reader)
        {
            Editorial editorial = new Editorial();

            editorial.ideditorial = (int)reader["ideditorial"];
            editorial.codigo = (string)reader["codigo"];
            editorial.nombre = (string)reader["nombre"];

            return editorial;
        }
        public IList<Editorial> ConsultarEditorial()
        {
            lista = new List<Editorial>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "select * From editorial";
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Editorial editorial = new Editorial();
                    editorial = MapearEditorial(reader);
                    lista.Add(editorial);
                }
                return lista;
            }
        }
        public Editorial BuscarEditorial(Editorial editorial)
        {
            foreach (Editorial item in ConsultarEditorial())
            {
                if (EsEncontrado(item, editorial))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Editorial item, Editorial editorial)
        {
            return item.codigo == editorial.codigo;
        }
        public string EditarEditorial(Editorial editorial)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update editorial set codigo = @codigo, nombre = @nombre where ideditorial = @ideditorial";


                Comando.Parameters.Add("@ideditorial", SqlDbType.Int).Value = editorial.ideditorial;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = editorial.codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = editorial.nombre;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Edito el editorial";
            }
            return respuesta;
        }

        public string Eliminar(Editorial editorial)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from editorial where ideditorial = @ideditorial";
                Comando.Parameters.Add("@ideditorial", SqlDbType.Int).Value = editorial.ideditorial;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Elimino el editorial";
            }
            return respuesta;
        }
    }
}
