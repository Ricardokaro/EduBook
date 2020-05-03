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
    public partial class ConsultarLibroEstudiante : MetroFramework.Forms.MetroForm
    {
        public ConsultarLibroEstudiante()
        {
            InitializeComponent();
        }

        private void ConsultarLibroEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioEstudiante = new InicioEstudiantes();
            InicioEstudiante.Show();
        }
    }
}
