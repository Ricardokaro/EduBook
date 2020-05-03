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
    public partial class ConsultarLibroInvitado : MetroFramework.Forms.MetroForm
    {
        public ConsultarLibroInvitado()
        {
            InitializeComponent();
        }

        private void ConsultarLibroInvitado_Load(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioInvitado = new InicioInvitado();
            InicioInvitado.Show();
        }
    }
}
