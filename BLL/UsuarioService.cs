using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Data.SqlClient;
using System.Security.Policy;

namespace BLL
{
    public class UsuarioService
    {
        SqlConnection conexion;
        UsuarioRepository Repositorio;
        IList<Usuario> lista;
        public UsuarioService()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-LAILH2Q\SQLEXPRESS;Initial Catalog=dbEduBook; Integrated Security=True");
            Repositorio = new UsuarioRepository(conexion);
        }


        public string GuardarUsuario(Usuario usuario)
        {
            try
            {
                conexion.Open();
                return Repositorio.GuardarUsuario(usuario);
            }
            catch (Exception e)
            {
                return  e.Message;
            }
            finally
            {
                conexion.Close();
            }
            
        }
        public Usuario BuscarUsuario(string NumeroDocumento)
        {            
            conexion.Open();
            Usuario usuario = new Usuario();
            usuario.numeroDocumento = NumeroDocumento;
            usuario = Repositorio.BuscarUsuario(usuario);
            conexion.Close();
            return usuario;
        }
        public IList<Usuario> ConsultarLista()
        {
            IList<Usuario> Lista = new List<Usuario>();
            try
            {
                conexion.Open();
                Lista = Repositorio.ConsultarUsuario();                
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
        public Usuario ConsultarUsuario(string Auxiliar)
        {
            IList<Usuario> Lista = new List<Usuario>();
            Lista = ConsultarLista();
            Usuario UsuEncontrado = null;
            foreach(var item in Lista)
            {
                if (item.numeroDocumento.Equals(Auxiliar))
                {
                    UsuEncontrado = new Usuario();
                    UsuEncontrado = item;
                }
            }
            return UsuEncontrado;
        }
        public string EditarUsuario(Usuario usuario)
        {
            try
            {
                
                conexion.Open();
                return Repositorio.EditarUsuario(usuario);
               
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

        public bool GuardarSession(Usuario usuario)
        {
            try
            {

                conexion.Open();
                return Repositorio.GuardarSession(usuario);

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public Usuario ConsultarSession()
        {
            try
            {

                conexion.Open();
                return Repositorio.ConsultarSession();

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

        public string EliminarUsuario(Usuario usuario)
        {
            try
            {

                conexion.Open();
                return Repositorio.Eliminar(usuario);

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

        public Usuario Login(string NumeroDocumento, string password)
        {
            try
            {
                conexion.Open();
                Usuario usuario = new Usuario();
                usuario.numeroDocumento = NumeroDocumento;
                usuario.password = password;
                usuario = Repositorio.Login(usuario);
                return usuario;
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
        public bool EliminarSession()
        {
            try
            {

                conexion.Open();
                return Repositorio.EliminarSession();

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
