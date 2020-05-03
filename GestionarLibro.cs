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
using System.IO;

namespace EduBook
{
    public partial class GestionarLibro : UserControl
    {
        LibroService libroService = new LibroService();
        AutorService autorService = new AutorService();
        EditorialService editorialService = new EditorialService();
        GeneroService generoService = new GeneroService();

        Libro libro;

        OpenFileDialog file;
        private string ruta_archivo = "";
        public GestionarLibro()
        {
            InitializeComponent();           
            LlenarComboAutor();
            LlenarComboEditorial();
            LlenarComboGenero();
            this.OrdernarTabulacion();
            this.LimpiarCampos();
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
            CodigoDelLibroText.TabIndex = 1;
            NombreDelLibroText.TabIndex = 2;
            DescripcionText.TabIndex = 3;
            ComboAutor.TabIndex = 4;
            ComboEditorial.TabIndex = 5;
            ComboGenero.TabIndex = 6;
            botonCargarFoto.TabIndex = 7;
            botonCargarPedf.TabIndex = 8;
        }

        public void LimpiarCampos()
        {
            CodigoDelLibroText.Text = "";
            NombreDelLibroText.Text = "";
            DescripcionText.Text = "";
            ComboAutor.SelectedIndex = -1;          
            ComboEditorial.SelectedIndex = -1;            
            ComboGenero.SelectedIndex = -1;
            pxFotoPortada.Image = global::EduBook.Properties.Resources.file;
                 
            
        }       

        private void cargarPedf_Click(object sender, EventArgs e)
        {
            try
            {
                file = new OpenFileDialog();                
                file.Filter = "Archivo PDF|*.pdf";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    ruta_archivo = file.FileName;
                    archivoPdf.src = file.FileName;
                    mensajeErrorProvider.SetError(archivoPdf, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }            
        }


        private void LlenarComboAutor()
        {            
            ComboAutor.DataSource = autorService.ConsultarLista();
            ComboAutor.ValueMember = "idautor";
            ComboAutor.DisplayMember = "nombre";            
        }

        private void LlenarComboEditorial()
        {
            ComboEditorial.DataSource = editorialService.ConsultarLista();
            ComboEditorial.ValueMember = "ideditorial";
            ComboEditorial.DisplayMember = "nombre";

        }

        private void LlenarComboGenero()
        {
            ComboGenero.DataSource = generoService.ConsultarLista();
            ComboGenero.ValueMember = "idgenero";
            ComboGenero.DisplayMember = "nombre";

        }

        private void cargarArchivoPdf()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string folder = path + "/temp/";
            string fullfilepath = folder + libro.nombre_archivo;

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (File.Exists(fullfilepath))
                File.Delete(fullfilepath);

            File.WriteAllBytes(fullfilepath, libro.archivo_pdf);
            archivoPdf.src = fullfilepath;
        }

        private void ComboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboGenero.Text.Trim().Length > 0)
            {
                mensajeErrorProvider.SetError(ComboGenero, String.Empty);
            }
        }

        private void ComboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboAutor.Text.Trim().Length > 0)
            {
                mensajeErrorProvider.SetError(ComboAutor, String.Empty);
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (CodigoDelLibroText.Text == string.Empty || ComboAutor.Text == string.Empty || ComboEditorial.Text == string.Empty
                    || ComboGenero.Text == string.Empty || archivoPdf.src == null )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    mensajeErrorProvider.SetError(CodigoDelLibroText, "Ingrese un Valor");
                    mensajeErrorProvider.SetError(ComboAutor, "Ingrese un Valor");
                    mensajeErrorProvider.SetError(ComboEditorial, "Ingrese un Valor");
                    mensajeErrorProvider.SetError(ComboGenero, "Ingrese un Valor");
                    mensajeErrorProvider.SetError(archivoPdf, "Ingrese un Valor");                  

                }
                else
                {

                    if (!(libroService.BuscarLibro(CodigoDelLibroText.Text) == null))
                    {
                        MensajeError("el codigo del libro: " + CodigoDelLibroText.Text + " ya se encuentra registrado en el sistema ");
                    }
                    else
                    {
                        libro = new Libro();
                        libro.codigo = CodigoDelLibroText.Text;
                        libro.nombre = NombreDelLibroText.Text;
                        libro.descripcion = DescripcionText.Text;
                        libro.idautor = (int)ComboAutor.SelectedValue;
                        libro.ideditorial = (int)ComboEditorial.SelectedValue;
                        libro.idgenero = (int)ComboGenero.SelectedValue;
                        
                        ///guargdar imagen de portada 
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pxFotoPortada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();
                        libro.imagen_portada = imagen;

                        ///guardar archivo en pdf                       
                        byte[] archivo = null;
                        Stream myStream = file.OpenFile();
                        using (MemoryStream mStream = new MemoryStream())
                        {
                            myStream.CopyTo(mStream);
                            archivo = mStream.ToArray();
                        }

                        libro.archivo_pdf = archivo;
                        libro.nombre_archivo = file.SafeFileName;

                        respuesta = libroService.GuardarLibro(libro);
                        if (respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeError(respuesta);
                        }
                    }
                    LimpiarCampos();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void botonCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxFotoPortada.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxFotoPortada.Image = Image.FromFile(dialog.FileName);                
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
           
            if (CodigoDelLibroText.Text.Trim() == string.Empty)
            {
                MensajeError("Digite un codigo de libro para poder realizar la busqueda");
                mensajeErrorProvider.SetError(CodigoDelLibroText, "Campo obligatorio para realizar la busqueda");
            }
            else {
                libro = libroService.BuscarLibro(CodigoDelLibroText.Text.Trim());
                if (!(libro == null))
                {
                    NombreDelLibroText.Text = libro.nombre;
                    DescripcionText.Text = libro.descripcion;
                    ComboAutor.SelectedValue = libro.idautor;
                    ComboEditorial.SelectedValue = libro.ideditorial;
                    ComboGenero.SelectedValue = libro.idgenero;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(libro.imagen_portada);
                    this.pxFotoPortada.Image = Image.FromStream(ms);
                    this.pxFotoPortada.SizeMode = PictureBoxSizeMode.StretchImage;
                    cargarArchivoPdf();
                }
                else
                {
                    MensajeError("Libro con este codigo: "+CodigoDelLibroText.Text+" no se encuentra registrado en e sistema, intente probar con un codigo diferente");
                    mensajeErrorProvider.SetError(CodigoDelLibroText, "Campo obligatorio para realizar la busqueda");
                }
            }
           
        }

        private void CodigoDelLibroText_OnValueChanged(object sender, EventArgs e)
        {
            if (CodigoDelLibroText.Text.Trim().Length > 0) {
                mensajeErrorProvider.SetError(CodigoDelLibroText, string.Empty);
            }
        }

        private void BortonModificar_Click(object sender, EventArgs e)
        {
            if (CodigoDelLibroText.Text.Trim() == string.Empty || NombreDelLibroText.Text.Trim() == string.Empty
                || ComboAutor.Text.Trim() == string.Empty || ComboEditorial.Text.Trim() == string.Empty 
                || ComboGenero.Text.Trim() == string.Empty || archivoPdf.src == null)
            {
                mensajeErrorProvider.SetError(CodigoDelLibroText, "campo obligatorio");
                mensajeErrorProvider.SetError(NombreDelLibroText, "campo obligatorio");               
                mensajeErrorProvider.SetError(ComboAutor, "campo obligatorio");
                mensajeErrorProvider.SetError(ComboEditorial, "campo obligatorio");
                mensajeErrorProvider.SetError(ComboGenero, "campo obligatorio");
                mensajeErrorProvider.SetError(archivoPdf, "campo obligatorio");

            }
            else
            {
                string respuesta = "";
                libro = libroService.BuscarLibro(CodigoDelLibroText.Text.Trim());
                if (libro == null)
                {
                    MensajeError("esta intentado editar un libro que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    libro.nombre = NombreDelLibroText.Text.Trim();
                    libro.descripcion = DescripcionText.Text.Trim();
                    libro.idautor = (int)ComboAutor.SelectedValue;
                    libro.ideditorial = (int)ComboEditorial.SelectedValue;
                    libro.idgenero = (int)ComboGenero.SelectedValue;
                    
                    ///guargdar imagen de portada 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxFotoPortada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();
                    libro.imagen_portada = imagen;

                    ///guardar archivo en pdf
                    if (file != null) {
                        byte[] archivo = null;
                        Stream myStream = file.OpenFile();
                        using (MemoryStream mStream = new MemoryStream())
                        {
                            myStream.CopyTo(mStream);
                            archivo = mStream.ToArray();
                        }

                        libro.archivo_pdf = archivo;
                        libro.nombre_archivo = file.SafeFileName;
                    }                   

                    respuesta = libroService.EditarLibro(libro);
                    if (respuesta.Equals("OK"))
                    {
                        MensajeOk("Libro editado correctamente");
                    }
                    else
                    {
                        MensajeError(respuesta);
                    }
                }
                LimpiarCampos();
            }
        }

        private void NombreDelLibroText_OnValueChanged(object sender, EventArgs e)
        {
            if (NombreDelLibroText.Text.Length > 0) {
                mensajeErrorProvider.SetError(NombreDelLibroText, String.Empty);
            }
        }

        private void DescripcionText_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboEditorial.Text.Length > 0)
            {
                mensajeErrorProvider.SetError(ComboEditorial, String.Empty);
            }
        }

        private void archivoPdf_Enter(object sender, EventArgs e)
        {

        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (CodigoDelLibroText.Text == string.Empty)
            {
                mensajeErrorProvider.SetError(CodigoDelLibroText, "campo obligatorio");                
            }
            else
            {
                string respuesta = "";
                libro = libroService.BuscarLibro(CodigoDelLibroText.Text.Trim());
                if (libro == null)
                {
                    MensajeError("esta intentado eliminar un libro que no esta Registrado en el sistema intente buscar nuevamente");
                }
                else
                {
                    DialogResult respuestaEliminarLibro = MessageBox.Show("¿Esta seguro de eliminar este libro?", "eliminar libro", MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Information);

                    if (respuestaEliminarLibro == DialogResult.Yes) {
                        respuesta = libroService.EliminarLibro(libro);
                        if (respuesta.Equals("OK"))
                        {
                            MensajeOk("Libro Eliminado correctamente");
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
