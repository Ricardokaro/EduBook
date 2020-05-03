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
    public class AutorService
    {
        SqlConnection conexion;
        AutorRepository Repositorio;
        IList<Autor> lista;

        public AutorService()         
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-LAILH2Q\SQLEXPRESS;Initial Catalog=dbEduBook; Integrated Security=True");
            Repositorio = new AutorRepository(conexion);
        }

        public string GuardarAutor(Autor autor)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarAutor(autor);
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

        public Autor BuscarAutor(string codigo)
        {
            conexion.Open();
            Autor autor = new Autor();
            autor.codigo = codigo;
            autor = Repositorio.BuscarAutor(autor);
            conexion.Close();
            return autor;
        }
        public IList<Autor> ConsultarLista()
        {
            IList<Autor> Lista = new List<Autor>();
            try
            {
                conexion.Open();
                Lista = Repositorio.ConsultarAutor();
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
        public Autor ConsultarAutor(string Auxiliar)
        {
            IList<Autor> Lista = new List<Autor>();
            Lista = ConsultarLista();
            Autor austorEncontrado = null;
            foreach (var item in Lista)
            {
                if (item.codigo.Equals(Auxiliar))
                {
                    austorEncontrado = new Autor();
                    austorEncontrado = item;
                }
            }
            return austorEncontrado;
        }
        public string EditarAutor(Autor autor)
        {
            try
            {

                conexion.Open();
                return Repositorio.EditarAutor(autor);

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

        public string EliminarAutor(Autor autor)
        {
            try
            {

                conexion.Open();
                return Repositorio.Eliminar(autor);

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
