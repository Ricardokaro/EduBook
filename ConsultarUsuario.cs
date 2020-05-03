using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
using System.Data.SqlClient;

namespace EduBook
{
    public partial class ConsultarUsuario : UserControl
    {
        UsuarioService usuarioService = new UsuarioService();
        Usuario usuario;
        public ConsultarUsuario()
        {
            InitializeComponent();
            inabilitarCampos();
        }

        private void inabilitarCampos() 
        {
            TipoDeDocumento.Visible = false;
            ComboTipodeUsuario.Visible = false;            
            NombreUsuario.Visible = false;
            ApellidoUsuario.Visible = false;
            GeneroUsuario.Visible = false;
            EdadUsuario.Visible = false;
            CorreoElectronico.Visible = false;
            PasswordUsuario.Visible = false;        
        }

        private void HabilitarCampos()
        {
            TipoDeDocumento.Visible = true;
            ComboTipodeUsuario.Visible = true;
            NombreUsuario.Visible = true;
            ApellidoUsuario.Visible = true;
            GeneroUsuario.Visible = true;
            EdadUsuario.Visible = true;
            CorreoElectronico.Visible = true;
            PasswordUsuario.Visible = true;
        }

        private void BontonBuscar_Click(object sender, EventArgs e)
        {
            if(NumeroDeDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el numero de documento", "◄ AVISO |Consultar Usuario ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    usuario = usuarioService.ConsultarUsuario(NumeroDeDocumento.Text);
                    if(usuario == null)
                    {
                        MessageBox.Show("El usuario no se encuentra registrado en el sistema", "Consultar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {                                               
                        this.TipoDeDocumento.Text = usuario.tipoDocumento;
                        this.NumeroDeDocumento.Text = usuario.numeroDocumento;
                        this.NombreUsuario.Text = usuario.nombre;
                        this.ApellidoUsuario.Text = usuario.apellidos;
                        this.GeneroUsuario.Text = usuario.genero;
                        this.EdadUsuario.Text = Convert.ToString(usuario.edad);
                        this.CorreoElectronico.Text = usuario.email;
                        this.ComboTipodeUsuario.Text = usuario.tipoUsuario;
                        this.PasswordUsuario.Text = usuario.password;

                        System.IO.MemoryStream ms = new System.IO.MemoryStream(usuario.fotoPerfil);
                        this.pxFotoPerfil.Image = Image.FromStream(ms);
                        this.pxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.HabilitarCampos();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Numero de documento no valido" + ex.Message);
                }
            }
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
