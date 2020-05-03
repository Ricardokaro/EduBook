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
    public partial class GestionarEditorial : UserControl
    {
        EditorialService editorialService = new EditorialService();
        Editorial editorial;
        public GestionarEditorial()
        {
            InitializeComponent();
            this.mensajeToolTip.SetToolTip(CodigoEditorialText, "Digite el codigo del genero");
            this.mensajeToolTip.SetToolTip(NombreEditorial, "Digite el nombre del genero");
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
            CodigoEditorialText.TabIndex = 1;
            NombreEditorial.TabIndex = 2;
        }

        public void LimpiarCampos()
        {
            CodigoEditorialText.Text = " ";
            NombreEditorial.Text = " ";
        }


        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (CodigoEditorialText.Text == string.Empty || NombreEditorial.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoEditorialText, "Campo obligatorio");
                mensajeErrorProvider.SetError(NombreEditorial, "Campo obligatorio");
            }
            else
            {
                if (!(editorialService.BuscarEditorial(CodigoEditorialText.Text.Trim()) == null))
                {
                    this.MensajeError("Un editorial con este codigo: " + CodigoEditorialText.Text + " ya se encuentra registrado en el sistema");
                }
                else
                {
                    string respuesta = "";
                    editorial = new Editorial();
                    editorial.codigo = CodigoEditorialText.Text.Trim();
                    editorial.nombre = NombreEditorial.Text.Trim();
                    respuesta = editorialService.GuardarEditorial(editorial);
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
            if (this.CodigoEditorialText.Text == string.Empty)
            {
                MensajeError("para buscar un editorial debe ingresar su codigo");
                mensajeErrorProvider.SetError(CodigoEditorialText, "dato obligatorio para la busqueda");
            }
            else
            {
                editorial = editorialService.BuscarEditorial(CodigoEditorialText.Text.Trim());
                if (!(editorial == null))
                {
                    NombreEditorial.Text = editorial.nombre;
                }
                else
                {
                    MensajeError("este codigo: " + CodigoEditorialText.Text + " no se encuentra registrado en el sistema");
                }
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (CodigoEditorialText.Text == string.Empty || NombreEditorial.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoEditorialText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreEditorial, "campo obligatorio");
            }
            else
            {
                string respuesta = "";
                editorial = editorialService.BuscarEditorial(CodigoEditorialText.Text.Trim());
                if (editorial == null)
                {
                    MensajeError("esta intentado editar un editorial que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    editorial.nombre = NombreEditorial.Text.Trim();
                    respuesta = editorialService.EditarEditorial(editorial);
                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Editorial editado correctamente");
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
            if (CodigoEditorialText.Text == string.Empty || NombreEditorial.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoEditorialText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreEditorial, "campo obligatorio");
            }
            else
            {
                string respuesta = "";
                editorial = editorialService.BuscarEditorial(CodigoEditorialText.Text.Trim());
                if (editorial == null)
                {
                    MensajeError("esta intentado eliminar un editorial que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    DialogResult respuestaEliminarEditorial = MessageBox.Show("¿Esta seguro de eliminar este Editorial?", "eliminar libro", MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Information);
                    if (respuestaEliminarEditorial == DialogResult.Yes) {
                        respuesta = editorialService.EliminarEditorial(editorial);
                        if (respuesta.Equals("OK"))
                        {
                            MensajeOk("Editorial Eliminado correctamente");
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
