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

namespace EduBook
{
    public partial class EliminarUsuario : UserControl
    {
        UsuarioService usuarioService = new UsuarioService();
        Usuario usuario;
        public EliminarUsuario()
        {
            InitializeComponent();
            inabilitarCampos();
            BotonAceptar.Visible = false;
            LimpiarFotoDePerfil();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "EduBook", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "EduBook", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LimpiarFotoDePerfil()
        {
            this.pxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxFotoPerfil.Image = global::EduBook.Properties.Resources.foto_perfil_2_;
        }

        private void BontonBuscar_Click(object sender, EventArgs e)
        {
            if (NumeroDeDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el numero de documento", "◄ AVISO |Consultar Usuario ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    usuario = usuarioService.ConsultarUsuario(NumeroDeDocumento.Text);
                    if (usuario == null)
                    {
                        MessageBox.Show("El usuario no se encuentra registrado en el sistema", "Consultar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.NumeroDeDocumento.Text = usuario.numeroDocumento;
                        this.TipoDeDocumento.Text = usuario.tipoDocumento;
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
                        BotonAceptar.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Numero de documento no valido" + ex.Message);
                }
            }

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if (NumeroDeDocumento.Text != null && NombreUsuario.Text != null)
            {
                usuario.tipoUsuario = ComboTipodeUsuario.Text;
                usuario.tipoDocumento = TipoDeDocumento.Text;
                usuario.numeroDocumento = NumeroDeDocumento.Text;
                usuario.nombre = NombreUsuario.Text;
                usuario.apellidos = ApellidoUsuario.Text;
                usuario.genero = GeneroUsuario.Text;
                usuario.edad = Convert.ToInt32(EdadUsuario.Text);
                usuario.email = CorreoElectronico.Text;
                usuario.password = PasswordUsuario.Text;

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pxFotoPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                byte[] imagen = ms.GetBuffer();

                usuario.fotoPerfil = imagen;

                DialogResult respuestaEliminarUsuario = MessageBox.Show("¿Esta seguro de eliminar este Usuario?", "eliminar libro", MessageBoxButtons.YesNoCancel,
                               MessageBoxIcon.Information);

                if (respuestaEliminarUsuario == DialogResult.Yes) {
                    respuesta = usuarioService.EliminarUsuario(usuario);

                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Se elimino correctamente el usuario: " + usuario.nombre + " " + usuario.apellidos);
                        inabilitarCampos();
                        LimpiarFotoDePerfil();
                    }
                    else
                    {
                        MensajeError(respuesta);
                    }
                }              

            }

        }
    }
}
