using BLL;
using ENTITY;
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
    public partial class InicioEstudiantes : MetroFramework.Forms.MetroForm
    {
        UsuarioService usuarioService = new UsuarioService();
        Usuario usuario;
        public InicioEstudiantes()
        {
            InitializeComponent();
          
        }

        private void InicioEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarLibroEstudiante_Click(object sender, EventArgs e)
        {

            this.Close();
            Form ConsultarLibroEstudiante = new ConsultarLibroEstudiante();
            ConsultarLibroEstudiante.Show();
        }

        private void ConsultarLibrosEstudiante_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarLibroEstudiante = new ConsultarLibroEstudiante();
            ConsultarLibroEstudiante.Show();
        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarEstadisticasEstudiante = new ConsultarEstadisticasEstudiante();
            ConsultarEstadisticasEstudiante.Show();
        }

        private void Estadistica_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ConsultarEstadisticasEstudiante = new ConsultarEstadisticasEstudiante();
            ConsultarEstadisticasEstudiante.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form IniciarSesion = new IniciarSesion();
            IniciarSesion.Show();
        }
    }
}
