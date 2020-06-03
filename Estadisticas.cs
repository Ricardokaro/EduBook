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
    public partial class Estadisticas : MetroFramework.Forms.MetroForm
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            EstadisticaEstudianteInvitadoLibroMasVisto estadisticaEstudianteInvitadoLibroMasVisto = new EstadisticaEstudianteInvitadoLibroMasVisto();
            if (PanelContenedor.Contains(estadisticaEstudianteInvitadoLibroMasVisto) == false)
            {
                PanelContenedor.Controls.Add(estadisticaEstudianteInvitadoLibroMasVisto);
                estadisticaEstudianteInvitadoLibroMasVisto.Dock = DockStyle.Fill;
                estadisticaEstudianteInvitadoLibroMasVisto.BringToFront();
            }
            else
            {
                estadisticaEstudianteInvitadoLibroMasVisto.BringToFront();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EstadisticaEstudianteLibroMasDescargado estadisticaEstudianteLibroMasDescargado = new EstadisticaEstudianteLibroMasDescargado();
            if (PanelContenedor.Contains(estadisticaEstudianteLibroMasDescargado) == false)
            {
                PanelContenedor.Controls.Add(estadisticaEstudianteLibroMasDescargado);
                estadisticaEstudianteLibroMasDescargado.Dock = DockStyle.Fill;
                estadisticaEstudianteLibroMasDescargado.BringToFront();
            }
            else
            {
                estadisticaEstudianteLibroMasDescargado.BringToFront();
            }
        }
    }
}
