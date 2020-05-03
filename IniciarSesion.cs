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
    public partial class IniciarSesion : MetroFramework.Forms.MetroForm
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "Biblioteca" && TextContraseña.Text == "01")
            {
                TextUsuario.Text = "Usuario";
                TextContraseña.Text = "Contraseña";
                this.SetVisibleCore(false);
                InicioAdministrador inicio = new InicioAdministrador();
                inicio.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña errada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        }
    }
