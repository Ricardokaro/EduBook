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
    public partial class GestionarGenero : UserControl
    {

        GeneroService generoService = new GeneroService();
        Genero genero;
        public GestionarGenero()
        {
            InitializeComponent();
            this.mensajeToolTip.SetToolTip(CodigoDelGeneroText, "Digite el codigo del genero");
            this.mensajeToolTip.SetToolTip(NombreGenero, "Digite el nombre del genero");
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
            CodigoDelGeneroText.TabIndex = 1;
            NombreGenero.TabIndex = 2;
        }

        public void LimpiarCampos()
        {
            CodigoDelGeneroText.Text = " ";
            NombreGenero.Text = " ";
        }
        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (CodigoDelGeneroText.Text == string.Empty || NombreGenero.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoDelGeneroText, "Campo obligatorio");
                mensajeErrorProvider.SetError(NombreGenero, "Campo obligatorio");
            }
            else
            {
                if (!(generoService.BuscarGenero(CodigoDelGeneroText.Text.Trim()) == null))
                {
                    this.MensajeError("Un genero con este codigo: " + CodigoDelGeneroText.Text + " ya se encuentra registrado en el sistema");
                }
                else
                {
                    string respuesta = "";
                    genero = new Genero();
                    genero.codigo = CodigoDelGeneroText.Text.Trim();
                    genero.nombre = NombreGenero.Text.Trim();
                    respuesta = generoService.GuardarGenero(genero);
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOk("Registro registrado correcatamente");
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.LimpiarCampos();
                }
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (this.CodigoDelGeneroText.Text == string.Empty)
            {
                MensajeError("para buscar un genero debe ingresar su codigo");
                mensajeErrorProvider.SetError(CodigoDelGeneroText, "dato obligatorio para la busqueda");
            }
            else
            {
                genero = generoService.BuscarGenero(CodigoDelGeneroText.Text.Trim());
                if (!(genero == null))
                {
                    NombreGenero.Text = genero.nombre;
                }
                else
                {
                    MensajeError("este codigo: " + CodigoDelGeneroText.Text + " no se encuentra registrado en el sistema");
                }
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (CodigoDelGeneroText.Text == string.Empty || NombreGenero.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoDelGeneroText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreGenero, "campo obligatorio");
            }
            else
            {
                string respuesta = "";
                genero = generoService.BuscarGenero(CodigoDelGeneroText.Text.Trim());
                if (genero == null)
                {
                    MensajeError("esta intentado editar un genero que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    genero.nombre = NombreGenero.Text.Trim();
                    respuesta = generoService.EditarGenero(genero);
                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Genero editado correctamente");
                    }
                    else
                    {
                        MensajeError(respuesta);
                    }
                }
                LimpiarCampos();
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (CodigoDelGeneroText.Text == string.Empty || NombreGenero.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoDelGeneroText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreGenero, "campo obligatorio");
            }
            else
            {
                string respuesta = "";
                genero = generoService.BuscarGenero(CodigoDelGeneroText.Text.Trim());
                if (genero == null)
                {
                    MensajeError("esta intentado eliminar un genero que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    DialogResult respuestaEliminarGenero = MessageBox.Show("¿Esta seguro de eliminar este Genero?", "eliminar libro", MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Information);

                    if (respuestaEliminarGenero == DialogResult.Yes)
                    {
                        respuesta = generoService.EliminarGenero(genero);
                        if (respuesta.Equals("OK"))
                        {
                            MensajeOk("Genero Eliminado correctamente");
                        }
                        else
                        {
                            MensajeError(respuesta);
                        }
                    }
                   
                }
                LimpiarCampos();
            }
        }
    }
}
