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
    public partial class RegistrarUsuario : UserControl
    {
        UsuarioService usuarioService = new UsuarioService();
        Usuario usuario;
        public RegistrarUsuario()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.ComboTipodeUsuario, "Seleccione un tipo de Usuario");
            this.ttMensaje.SetToolTip(this.TipoDeDocumento, "Seleccione un tipo de Documento");
            this.ttMensaje.SetToolTip(this.NumeroDeDocumento, "Digite un numero de documento");
            this.ttMensaje.SetToolTip(this.NombreUsuario, "Digite un nombre al usuario");
            this.ttMensaje.SetToolTip(this.ApellidoUsuario, "Digite los apellidos del usuario");
            this.ttMensaje.SetToolTip(this.GeneroUsuario, "Seleccione un genero");
            this.ttMensaje.SetToolTip(this.EdadUsuario, "Digite la edad del usuario");
            this.ttMensaje.SetToolTip(this.CorreoElectronico, "Digite un email");
            this.ttMensaje.SetToolTip(this.pxFotoPerfil, "Seleccione una foto de perfil en el boton cargar foto");
            OrdernarTabulacion();

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

        private void OrdernarTabulacion()
        {
            ComboTipodeUsuario.TabIndex = 1;
            TipoDeDocumento.TabIndex = 2;
            NumeroDeDocumento.TabIndex = 3;
            NombreUsuario.TabIndex = 4;
            ApellidoUsuario.TabIndex = 5;
            GeneroUsuario.TabIndex = 6;
            EdadUsuario.TabIndex = 7;
            CorreoElectronico.TabIndex = 8;
            PasswordUsuario.TabIndex = 9;
            metroButton1.TabIndex = 10;            
        }

        public void LimpiarCampos()
        {
            ComboTipodeUsuario.Text = " ";
            TipoDeDocumento.Text = " ";
            NumeroDeDocumento.Text = " ";
            NombreUsuario.Text = " ";
            ApellidoUsuario.Text = " ";
            GeneroUsuario.Text = " ";
            EdadUsuario.Text = " ";
            CorreoElectronico.Text = "";
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";
                if (ComboTipodeUsuario.Text == string.Empty || TipoDeDocumento.Text == string.Empty || NumeroDeDocumento.Text == string.Empty
                    || NombreUsuario.Text == string.Empty || ApellidoUsuario.Text == string.Empty || GeneroUsuario.Text == string.Empty ||
                    EdadUsuario.Text == string.Empty || CorreoElectronico.Text == string.Empty || ComboTipodeUsuario.Text == string.Empty
                    || PasswordUsuario.Text == string.Empty || pxFotoPerfil.Image == null)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcon.SetError(ComboTipodeUsuario, "Ingrese un Valor");
                    errorIcon.SetError(TipoDeDocumento, "Ingrese un Valor");
                    errorIcon.SetError(NumeroDeDocumento, "Ingrese un Valor");
                    errorIcon.SetError(NombreUsuario, "Ingrese un Valor");
                    errorIcon.SetError(ApellidoUsuario, "Ingrese un Valor");
                    errorIcon.SetError(GeneroUsuario, "Ingrese un Valor");
                    errorIcon.SetError(EdadUsuario, "Ingrese un Valor");
                    errorIcon.SetError(PasswordUsuario, "Ingrese un Valor");

                }
                else
                {

                    if (!(usuarioService.BuscarUsuario(NumeroDeDocumento.Text) == null))
                    {
                        MensajeError("el numero de documento: " + NumeroDeDocumento.Text + " ya se encuentra registrado en el sistema ");
                    }
                    else 
                    {
                        usuario = new Usuario();
                        usuario.tipoDocumento = ComboTipodeUsuario.Text;
                        usuario.tipoDocumento = TipoDeDocumento.Text;
                        usuario.numeroDocumento = NumeroDeDocumento.Text;
                        usuario.nombre = NombreUsuario.Text;
                        usuario.apellidos = ApellidoUsuario.Text;
                        usuario.genero = GeneroUsuario.Text;
                        usuario.edad = Convert.ToInt32(EdadUsuario.Text);
                        usuario.email = CorreoElectronico.Text;
                        usuario.tipoUsuario = ComboTipodeUsuario.Text;
                        usuario.password = PasswordUsuario.Text;


                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pxFotoPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        byte[] imagen = ms.GetBuffer();

                        usuario.fotoPerfil = imagen;

                        respuesta = usuarioService.GuardarUsuario(usuario);
                        if (respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeError(respuesta);
                        }
                    }                    
                }
            }
            catch (Exception)
            {

                throw;
            }

        }  
        

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                this.pxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxFotoPerfil.Image = Image.FromFile(dialog.FileName);
            }

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
