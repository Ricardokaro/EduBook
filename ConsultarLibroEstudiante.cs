using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduBook
{
    public partial class ConsultarLibroEstudiante : MetroFramework.Forms.MetroForm
    {
        public LibroService libroService = new LibroService();
        public UsuarioService usuarioService = new UsuarioService();
        public Libro libro;
        public Usuario usuario;
        
        public ConsultarLibroEstudiante()
        {
            InitializeComponent();
        }

        private void ConsultarLibroEstudiante_Load(object sender, EventArgs e)
        {
            this.CargarPerfil();
            this.CargarTablaLibros();
            this.OcultarColumnas();
            this.BotonDescargar.Visible = false;
            this.metroTabControl1.SelectedIndex = 0;
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioEstudiante = new InicioEstudiantes();
            InicioEstudiante.Show();
        }

        private void BuscadorDeLibros_OnTextChange(object sender, EventArgs e)
        {
            if (txtSeleccionarBusqueda.Text.Equals("Nombre")) 
            {
                this.BuscarLibroPorNombre();
            }

            if (txtSeleccionarBusqueda.Text.Equals("Codigo"))
            {
                this.BuscarLibroPorCodigo();
            }
        }

        private void BuscarLibroPorNombre()
        {
            dataListadoLibros.DataSource = libroService.BuscarLibroPorNombre(txtBuscadorDeLibros.text);
            OcultarColumnas();
        }

        private void BuscarLibroPorCodigo()
        {
            dataListadoLibros.DataSource = libroService.BuscarLibroPorCodigo(txtBuscadorDeLibros.text);
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            this.dataListadoLibros.Columns[0].Visible = false; //idlibro
            this.dataListadoLibros.Columns[4].Visible = false; //idautor
            this.dataListadoLibros.Columns[5].Visible = false; //ideditorial 
            this.dataListadoLibros.Columns[6].Visible = false; //idgenero
            //this.dataListadoLibros.Columns[7].Visible = false; //idgenero
            this.dataListadoLibros.Columns[8].Visible = false; //archivo_pdf 
            this.dataListadoLibros.Columns[9].Visible = false; //nombre_archivo
        }

        private void CargarTablaLibros()
        {
            this.dataListadoLibros.DataSource = libroService.ConsultarLista();         
        }

        private void txtSeleccionarBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dataListadoLibros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            libro = new Libro();
            libro.idlibro = (int)dataListadoLibros.CurrentRow.Cells["idlibro"].Value;
            libro.nombre_archivo = (string)dataListadoLibros.CurrentRow.Cells["nombre_archivo"].Value;
            libro.archivo_pdf = (byte[])dataListadoLibros.CurrentRow.Cells["archivo_pdf"].Value;
            cargarArchivoPdf();
            this.metroTabControl1.SelectedIndex = 1;
            BotonDescargar.Visible = true;            
            pdfLibro.setShowToolbar(false);
            guardarVistoLibro();           
        }

        private void guardarVistoLibro()
        {
            string respuesta = "";
            LibroVisto libroVisto = new LibroVisto();
            libroVisto.idlibro = libro.idlibro;
            libroVisto.idusuario = usuario.idusuario;
            libroVisto.fecha = DateTime.Now;
            respuesta = libroService.GuardarVistaLibro(libroVisto);
            if (respuesta.Equals("OK"))
            {
                MessageBox.Show("Cargo con exito el libro...", "EduBook", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "EduBook", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarPerfil() 
        {
            usuario = usuarioService.ConsultarSession();          
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
            pdfLibro.src = fullfilepath;
        }   

        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0) 
            {
                BotonDescargar.Visible = false;
            }

            if (metroTabControl1.SelectedIndex == 1)
            {
                BotonDescargar.Visible = true;
            }
        }

        private void dataListadoLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonDescargar_Click(object sender, EventArgs e)
        {

        }
    }
}
