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
    public partial class InicioAdministrador : MetroFramework.Forms.MetroForm
    {       
        public InicioAdministrador()
        {
            InitializeComponent();           
        }

        private void InicioAdministrador_Load(object sender, EventArgs e)
        {
           
        }

        private void GestionarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            Form GestionDeUsuarios = new GestionDeUsuarios();
            GestionDeUsuarios.Show();
        }

        private void GestionarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Form GestionDeUsuarios = new GestionDeUsuarios();
            GestionDeUsuarios.Show();
        }

        private void GestionarLibros_Click(object sender, EventArgs e)
        {
            this.Close();
            Form GestionDeLibros = new GestionDeLibros();
            GestionDeLibros.Show();
        }

        private void GestionarLibro_Click(object sender, EventArgs e)
        {
            this.Close();
            Form GestionDeLibros = new GestionDeLibros();
            GestionDeLibros.Show();
        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Estadisticas = new Estadisticas();
            Estadisticas.Show();
        }

        private void Estadistica_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Estadisticas = new Estadisticas();
            Estadisticas.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form IniciarSesion = new IniciarSesion();
            IniciarSesion.Show();
        }
    }
}
