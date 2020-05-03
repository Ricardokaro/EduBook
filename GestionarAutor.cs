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
    public partial class GestionarAutor : UserControl
    {

        AutorService autorService = new AutorService();
        Autor autor;

        public GestionarAutor()
        {
            InitializeComponent();
            this.mensajeToolTip.SetToolTip(CodigoAutorText, "Digite el codigo del autor");
            this.mensajeToolTip.SetToolTip(NombreAutor, "Digite el nombre del autor");
           
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
            CodigoAutorText.TabIndex = 1;
            NombreAutor.TabIndex = 2;           
        }

        public void LimpiarCampos()
        {
            CodigoAutorText.Text = " ";
            NombreAutor.Text = " ";          
        }

      
        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            
            if (CodigoAutorText.Text == string.Empty || NombreAutor.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoAutorText, "Campo obligatorio");
                mensajeErrorProvider.SetError(NombreAutor, "Campo obligatorio");
            }
            else
            {
                if (!(autorService.BuscarAutor(CodigoAutorText.Text.Trim()) == null))
                {
                    this.MensajeError("Un autor con este codigo: " + CodigoAutorText.Text + " ya se encuentra registrado en el sistema");
                }
                else
                {
                    string respuesta = "";
                    autor = new Autor();
                    autor.codigo = CodigoAutorText.Text.Trim();
                    autor.nombre = NombreAutor.Text.Trim();
                    respuesta = autorService.GuardarAutor(autor);
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
            if (this.CodigoAutorText.Text == string.Empty)
            {
                MensajeError("para buscar un autor debe ingresar su codigo");
                mensajeErrorProvider.SetError(CodigoAutorText, "dato obligatorio para la busqueda");
            }
            else
            {               
                autor = autorService.BuscarAutor(CodigoAutorText.Text.Trim());
                if (!(autor == null))
                {
                    NombreAutor.Text = autor.nombre;
                }
                else
                {
                    MensajeError("este codigo: "+ CodigoAutorText.Text +" no se encuentra registrado en el sistema");
                }
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (CodigoAutorText.Text == string.Empty || NombreAutor.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoAutorText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreAutor, "campo obligatorio");
            }
            else {
                string respuesta = "";
                autor = autorService.BuscarAutor(CodigoAutorText.Text.Trim());
                if (autor == null)
                {
                    MensajeError("esta intentado editar un autor que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else {
                    autor.nombre = NombreAutor.Text.Trim();
                    respuesta = autorService.EditarAutor(autor);
                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Autor editado correctamente");
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
            if (CodigoAutorText.Text == string.Empty || NombreAutor.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoAutorText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreAutor, "campo obligatorio");
            }
            else
            {
                string respuesta = "";
                autor = autorService.BuscarAutor(CodigoAutorText.Text.Trim());
                if (autor == null)
                {
                    MensajeError("esta intentado eliminar un autor que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    DialogResult respuestaEliminarAutor = MessageBox.Show("¿Esta seguro de eliminar este Autor?", "eliminar libro", MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Information);

                    if (respuestaEliminarAutor == DialogResult.Yes) 
                    {
                        respuesta = autorService.EliminarAutor(autor);
                        if (respuesta.Equals("OK"))
                        {
                            MensajeOk("Autor Eliminado correctamente");
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
