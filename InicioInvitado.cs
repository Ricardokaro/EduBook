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
    public partial class InicioInvitado : MetroFramework.Forms.MetroForm
    {
        public InicioInvitado()
        {
            InitializeComponent();
        }

        private void InicioInvitado_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarLibrosInvitado_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarLibroInvitado = new ConsultarLibroInvitado();
            ConsultarLibroInvitado.Show();
        }

        private void ConsultarLibroInvitado_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarLibroInvitado = new ConsultarLibroInvitado();
            ConsultarLibroInvitado.Show();
        }

        private void Estadistica_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarEstadisticasInvitado = new BotonRegresa();
            ConsultarEstadisticasInvitado.Show();
        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarEstadisticasInvitado = new BotonRegresa();
            ConsultarEstadisticasInvitado.Show();
        }
    }
}
