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
    public partial class GestionDeUsuarios : MetroFramework.Forms.MetroForm
    {
        public GestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void BotonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            if(PanelContenedor.Contains(registrarUsuario) == false)
            {
                PanelContenedor.Controls.Add(registrarUsuario);
                registrarUsuario.Dock = DockStyle.Fill;
                registrarUsuario.BringToFront();
            }
            else
            {
                registrarUsuario.BringToFront();
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            if (PanelContenedor.Contains(registrarUsuario) == false)
            {
                PanelContenedor.Controls.Add(registrarUsuario);
                registrarUsuario.Dock = DockStyle.Fill;
                registrarUsuario.BringToFront();
            }
            else
            {
                registrarUsuario.BringToFront();
            }
        }

        private void ConsultarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuario consultarUsuario = new ConsultarUsuario();
            if (PanelContenedor.Contains(consultarUsuario) == false)
            {
                PanelContenedor.Controls.Add(consultarUsuario);
                consultarUsuario.Dock = DockStyle.Fill;
                consultarUsuario.BringToFront();
            }
            else
            {
                consultarUsuario.BringToFront();
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuario consultarUsuario = new ConsultarUsuario();
            if (PanelContenedor.Contains(consultarUsuario) == false)
            {
                PanelContenedor.Controls.Add(consultarUsuario);
                consultarUsuario.Dock = DockStyle.Fill;
                consultarUsuario.BringToFront();
            }
            else
            {
                consultarUsuario.BringToFront();
            }
        }

        private void ModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario ModificarUsuario = new ModificarUsuario();
            if (PanelContenedor.Contains(ModificarUsuario) == false)
            {
                PanelContenedor.Controls.Add(ModificarUsuario);
                ModificarUsuario.Dock = DockStyle.Fill;
                ModificarUsuario.BringToFront();
            }
            else
            {
                ModificarUsuario.BringToFront();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario ModificarUsuario = new ModificarUsuario();
            if (PanelContenedor.Contains(ModificarUsuario) == false)
            {
                PanelContenedor.Controls.Add(ModificarUsuario);
                ModificarUsuario.Dock = DockStyle.Fill;
                ModificarUsuario.BringToFront();
            }
            else
            {
                ModificarUsuario.BringToFront();
            }
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            if (PanelContenedor.Contains(eliminarUsuario) == false)
            {
                PanelContenedor.Controls.Add(eliminarUsuario);
                eliminarUsuario.Dock = DockStyle.Fill;
                eliminarUsuario.BringToFront();
            }
            else
            {
                eliminarUsuario.BringToFront();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            if (PanelContenedor.Contains(eliminarUsuario) == false)
            {
                PanelContenedor.Controls.Add(eliminarUsuario);
                eliminarUsuario.Dock = DockStyle.Fill;
                eliminarUsuario.BringToFront();
            }
            else
            {
                eliminarUsuario.BringToFront();
            }
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
        }
    }
}
