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
    public class GeneroService
    {
        SqlConnection conexion;
        GeneroRepository Repositorio;
        IList<Genero> lista;

        public GeneroService()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-LAILH2Q\SQLEXPRESS;Initial Catalog=dbEduBook; Integrated Security=True");
            Repositorio = new GeneroRepository(conexion);
        }

        public string GuardarGenero(Genero genero)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarGenero(genero);
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

        public Genero BuscarGenero(string codigo)
        {
            conexion.Open();
            Genero genero = new Genero();
            genero.codigo = codigo;
            genero = Repositorio.BuscarGenero(genero);
            conexion.Close();
            return genero;
        }
        public IList<Genero> ConsultarLista()
        {
            IList<Genero> Lista = new List<Genero>();
            try
            {
                conexion.Open();
                Lista = Repositorio.ConsultarGenero();
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
        public Genero ConsultarGenero(string Auxiliar)
        {
            IList<Genero> Lista = new List<Genero>();
            Lista = ConsultarLista();
            Genero generoEncontrado = null;
            foreach (var item in Lista)
            {
                if (item.codigo.Equals(Auxiliar))
                {
                    generoEncontrado = new Genero();
                    generoEncontrado = item;
                }
            }
            return generoEncontrado;
        }
        public string EditarGenero(Genero genero)
        {
            try
            {

                conexion.Open();
                return Repositorio.EditarGenero(genero);

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

        public string EliminarGenero(Genero genero)
        {
            try
            {

                conexion.Open();
                return Repositorio.Eliminar(genero);

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
