using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduBook
{
    public partial class GestionDeLibros : MetroFramework.Forms.MetroForm
    {
        public GestionDeLibros()
        {
            InitializeComponent();
        }

        private void GestionDeLibros_Load(object sender, EventArgs e)
        {

        }

        private void BotonGestionarLibro_Click(object sender, EventArgs e)
        {
            GestionarLibro gestionarLibro = new GestionarLibro();
            if (PanelContenedor.Contains(gestionarLibro) == false)
            {
                PanelContenedor.Controls.Add(gestionarLibro);
                gestionarLibro.Dock = DockStyle.Fill;
                gestionarLibro.BringToFront();
            }
            else
            {
                gestionarLibro.BringToFront();
            }
        }

        private void LabelGestionarLibro_Click(object sender, EventArgs e)
        {
            GestionarLibro gestionarLibro = new GestionarLibro();
            if (PanelContenedor.Contains(gestionarLibro) == false)
            {
                PanelContenedor.Controls.Add(gestionarLibro);
                gestionarLibro.Dock = DockStyle.Fill;
                gestionarLibro.BringToFront();
            }
            else
            {
                gestionarLibro.BringToFront();
            }
        }

        private void BotonGestionarGenero_Click(object sender, EventArgs e)
        {
            GestionarGenero gestionarGenero = new GestionarGenero();
            if (PanelContenedor.Contains(gestionarGenero) == false)
            {
                PanelContenedor.Controls.Add(gestionarGenero);
                gestionarGenero.Dock = DockStyle.Fill;
                gestionarGenero.BringToFront();
            }
            else
            {
                gestionarGenero.BringToFront();
            }
        }

        private void LabelGestionarGenero_Click(object sender, EventArgs e)
        {
            GestionarGenero gestionarGenero = new GestionarGenero();
            if (PanelContenedor.Contains(gestionarGenero) == false)
            {
                PanelContenedor.Controls.Add(gestionarGenero);
                gestionarGenero.Dock = DockStyle.Fill;
                gestionarGenero.BringToFront();
            }
            else
            {
                gestionarGenero.BringToFront();
            }
        }

        private void BotonGestionarAutor_Click(object sender, EventArgs e)
        {
            GestionarAutor gestionarAutor = new GestionarAutor();
            if (PanelContenedor.Contains(gestionarAutor) == false)
            {
                PanelContenedor.Controls.Add(gestionarAutor);
                gestionarAutor.Dock = DockStyle.Fill;
                gestionarAutor.BringToFront();
            }
            else
            {
                gestionarAutor.BringToFront();
            }
        }

        private void LabelGestionarEditorial_Click(object sender, EventArgs e)
        {
            GestionarEditorial gestionarEditorial = new GestionarEditorial();
            if (PanelContenedor.Contains(gestionarEditorial) == false)
            {
                PanelContenedor.Controls.Add(gestionarEditorial);
                gestionarEditorial.Dock = DockStyle.Fill;
                gestionarEditorial.BringToFront();
            }
            else
            {
                gestionarEditorial.BringToFront();
            }
        }

        private void LabelGestionarAutor_Click(object sender, EventArgs e)
        {
            GestionarAutor gestionarAutor = new GestionarAutor();
            if (PanelContenedor.Contains(gestionarAutor) == false)
            {
                PanelContenedor.Controls.Add(gestionarAutor);
                gestionarAutor.Dock = DockStyle.Fill;
                gestionarAutor.BringToFront();
            }
            else
            {
                gestionarAutor.BringToFront();
            }
        }

        private void BotonGestionarEditorial_Click(object sender, EventArgs e)
        {
            GestionarEditorial gestionarEditorial = new GestionarEditorial();
            if (PanelContenedor.Contains(gestionarEditorial) == false)
            {
                PanelContenedor.Controls.Add(gestionarEditorial);
                gestionarEditorial.Dock = DockStyle.Fill;
                gestionarEditorial.BringToFront();
            }
            else
            {
                gestionarEditorial.BringToFront();
            }
        }

        private void LabelRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
        }
    }
}
