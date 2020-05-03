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
    public partial class BotonRegresa : MetroFramework.Forms.MetroForm
    {
        public BotonRegresa()
        {
            InitializeComponent();
        }

        private void ConsultarEstadisticasInvitado_Load(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioInvitado = new InicioInvitado();
            InicioInvitado.Show();
        }
    }
}
