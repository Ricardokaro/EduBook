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
    public class EditorialService
    {
        SqlConnection conexion;
        EditorialRepository Repositorio;
        IList<Editorial> lista;

        public EditorialService()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-LAILH2Q\SQLEXPRESS;Initial Catalog=dbEduBook; Integrated Security=True");
            Repositorio = new EditorialRepository(conexion);
        }

        public string GuardarEditorial(Editorial editorial)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarEditorial(editorial);
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

        public Editorial BuscarEditorial(string codigo)
        {
            conexion.Open();
            Editorial editorial = new Editorial();
            editorial.codigo = codigo;
            editorial = Repositorio.BuscarEditorial(editorial);
            conexion.Close();
            return editorial;
        }
        public IList<Editorial> ConsultarLista()
        {
            IList<Editorial> Lista = new List<Editorial>();
            try
            {
                conexion.Open();
                Lista = Repositorio.ConsultarEditorial();
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
        public Editorial ConsultarEditorial(string Auxiliar)
        {
            IList<Editorial> Lista = new List<Editorial>();
            Lista = ConsultarLista();
            Editorial editorialEncontrado = null;
            foreach (var item in Lista)
            {
                if (item.codigo.Equals(Auxiliar))
                {
                    editorialEncontrado = new Editorial();
                    editorialEncontrado = item;
                }
            }
            return editorialEncontrado;
        }
        public string EditarEditorial(Editorial editorial)
        {
            try
            {

                conexion.Open();
                return Repositorio.EditarEditorial(editorial);

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

        public string EliminarEditorial(Editorial editorial)
        {
            try
            {

                conexion.Open();
                return Repositorio.Eliminar(editorial);

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
