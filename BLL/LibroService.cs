using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LibroService
    {
        SqlConnection conexion;
        LibroRepository Repositorio;
        IList<Libro> lista;
        IList<LibroMasVisto> listaLibrosMasVistos;

        public LibroService()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-LAILH2Q\SQLEXPRESS;Initial Catalog=dbEduBook; Integrated Security=True");
            Repositorio = new LibroRepository(conexion);
        }

        public string GuardarLibro(Libro libro)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarLibro(libro);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexion.Close();
            }

        }        

        public string GuardarVistaLibro(LibroVisto libroVisto)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarVistaLibro(libroVisto);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexion.Close();
            }

        }

        public string GuardarDescargaLibro(LibroDescargado libroDescargado)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarDescargaLibro(libroDescargado);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexion.Close();
            }

        }

        public Libro BuscarLibro(string codigo)
        {
            conexion.Open();
            Libro libro = new Libro();
            libro.codigo = codigo;
            libro = Repositorio.BuscarLibro(libro);
            conexion.Close();
            return libro;
        }

        public IList<Libro> BuscarLibroPorNombre(string nombre)
        {
            IList<Libro> Lista = new List<Libro>();
            try
            {
                conexion.Open();
                Lista = Repositorio.BuscarLibroPorNombre(nombre);
                return Lista;
            }
            catch (Exception e)
            {
                return lista;
            }
            finally
            {
                conexion.Close();
            }
        }

        public IList<Libro> BuscarLibroPorCodigo(string codigo)
        {
            IList<Libro> Lista = new List<Libro>();
            try
            {
                conexion.Open();
                Lista = Repositorio.BuscarLibroPorCodigo(codigo);
                return Lista;
            }
            catch (Exception e)
            {
                return lista;
            }
            finally
            {
                conexion.Close();
            }
        }
        public IList<Libro> ConsultarLista()
        {
            IList<Libro> Lista = new List<Libro>();
            try
            {
                conexion.Open();
                Lista = Repositorio.ConsultarLibro();
                return Lista;
            }
            catch (Exception e)
            {
                return lista;
            }
            finally
            {
                conexion.Close();
            }
        }

        public IList<LibroMasVisto> ConsultarLibroMasVistoPorEstudiante()
        {
            IList<LibroMasVisto> listaLibrosMasVistos = new List<LibroMasVisto>();
            try
            {
                conexion.Open();
                listaLibrosMasVistos = Repositorio.ConsultarLibroMasVistoPorEstudiante();
                return listaLibrosMasVistos;
            }
            catch (Exception e)
            {
                return listaLibrosMasVistos;
            }
            finally
            {
                conexion.Close();
            }
        }


        public IList<LibroMasDescargado> ConsultarLibroMasDescargadoPorEstudiante()
        {
            IList<LibroMasDescargado> listaLibroMasDescargados = new List<LibroMasDescargado>();
            try
            {
                conexion.Open();
                listaLibroMasDescargados = Repositorio.ConsultarLibroMasDescargadoPorEstudiante();
                return listaLibroMasDescargados;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public IList<LibroMasVisto> ConsultarLibroMasVistoPorInvitado()
        {
            IList<LibroMasVisto> listaLibrosMasVistos = new List<LibroMasVisto>();
            try
            {
                conexion.Open();
                listaLibrosMasVistos = Repositorio.ConsultarLibroMasVistoPorInvitado();
                return listaLibrosMasVistos;
            }
            catch (Exception e)
            {
                return listaLibrosMasVistos;
            }
            finally
            {
                conexion.Close();
            }
        }


        public Libro ConsultarLibro(string Auxiliar)
        {
            IList<Libro> Lista = new List<Libro>();
            Lista = ConsultarLista();
            Libro libroEncontrado = null;
            foreach (var item in Lista)
            {
                if (item.codigo.Equals(Auxiliar))
                {
                    libroEncontrado = new Libro();
                    libroEncontrado = item;
                }
            }
            return libroEncontrado;
        }

        
        public string EditarLibro(Libro libro)
        {
            try
            {

                conexion.Open();
                return Repositorio.EditarLibro(libro);

            }
            catch (Exception e)
            {
                return "Error Al modificar: " + e.Message;
            }
            finally
            {
                conexion.Close();
            }
        }

        public string EliminarLibro(Libro libro)
        {
            try
            {

                conexion.Open();
                return Repositorio.Eliminar(libro);

            }
            catch (Exception e)
            {
                return "Error Al eliminar: " + e.Message;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
