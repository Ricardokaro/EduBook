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
    public class LibroRepository
    {
        private SqlConnection Conexion;
        private SqlDataAdapter reader;
        private SqlCommand Comando;
        List<Libro> lista;
        public LibroRepository(SqlConnection conexion)
        {
            this.Conexion = conexion;

        }

        public string GuardarLibro(Libro libro)
        {
            string respuesta = "";
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "insert into libro(codigo, nombre, descripcion, idautor, ideditorial, idgenero, imagen_portada, archivo_pdf, nombre_archivo) " +
                                                "values(@codigo,@nombre,@descripcion,@idautor,@ideditorial,@idgenero,@imagen_portada,@archivo_pdf, @nombre_archivo)";
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = libro.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = libro.nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = libro.descripcion;
                comando.Parameters.Add("@idautor", SqlDbType.Int).Value = libro.idautor;
                comando.Parameters.Add("@ideditorial", SqlDbType.Int).Value = libro.ideditorial;
                comando.Parameters.Add("@idgenero", SqlDbType.Int).Value = libro.idgenero;
                comando.Parameters.Add("@imagen_portada", SqlDbType.Image).Value = libro.imagen_portada;
                comando.Parameters.Add("@archivo_pdf", SqlDbType.Image).Value = libro.archivo_pdf;
                comando.Parameters.Add("@nombre_archivo", SqlDbType.VarChar).Value = libro.nombre_archivo;

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO guardo el libro";

            }
            return respuesta;
        }

        private Libro MapearLibro(SqlDataReader reader)
        {
            Libro libro = new Libro();

            libro.idlibro = (int)reader["idlibro"];
            libro.codigo = (string)reader["codigo"];
            libro.nombre = (string)reader["nombre"];
            libro.descripcion = (string)reader["descripcion"];
            libro.idautor = (int)reader["idautor"];
            libro.ideditorial = (int)reader["ideditorial"];
            libro.idgenero = (int)reader["idgenero"];
            libro.imagen_portada = (byte[])reader["imagen_portada"];
            libro.archivo_pdf = (byte[])reader["archivo_pdf"];
            libro.nombre_archivo = (string)reader["nombre_archivo"];

            return libro;
        }
        public IList<Libro> ConsultarLibro()
        {
            lista = new List<Libro>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "select * From libro";
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Libro libro = new Libro();
                    libro = MapearLibro(reader);
                    lista.Add(libro);
                }
                return lista;
            }
        }
        public Libro BuscarLibro(Libro libro)
        {
            foreach (Libro item in ConsultarLibro())
            {
                if (EsEncontrado(item, libro))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Libro item, Libro libro)
        {
            return item.codigo == libro.codigo;
        }
        public string EditarLibro(Libro libro)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update libro set " +
                    "codigo = @codigo, nombre = @nombre, descripcion = @descripcion, idautor=@idautor, " +
                    "ideditorial = @ideditorial, idgenero = @idgenero, imagen_portada = @imagen_portada, archivo_pdf = @archivo_pdf," +
                    "nombre_archivo = @nombre_archivo where idlibro = @idlibro";


                Comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = libro.idlibro;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = libro.codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = libro.nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = libro.descripcion;
                Comando.Parameters.Add("@idautor", SqlDbType.Int).Value = libro.idautor;
                Comando.Parameters.Add("@ideditorial", SqlDbType.Int).Value = libro.ideditorial;
                Comando.Parameters.Add("@idgenero", SqlDbType.Int).Value = libro.idgenero;
                Comando.Parameters.Add("@imagen_portada", SqlDbType.Image).Value = libro.imagen_portada;
                Comando.Parameters.Add("@archivo_pdf", SqlDbType.Image).Value = libro.archivo_pdf;
                Comando.Parameters.Add("@nombre_archivo", SqlDbType.VarChar).Value = libro.nombre_archivo;

                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Edito el libro";
            }
            return respuesta;
        }

        public string Eliminar(Libro libro)
        {
            string respuesta = "";
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from libro where idlibro = @idlibro";
                Comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = libro.idlibro;
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO Elimino el libro";
            }
            return respuesta;
        }
    }
}
