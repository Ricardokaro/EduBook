﻿using System;
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
    public partial class ConsultarEstadisticasEstudiante : MetroFramework.Forms.MetroForm
    {
        public ConsultarEstadisticasEstudiante()
        {
            InitializeComponent();
        }

        private void ConsultarEstadisticasEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioEstudiante = new InicioEstudiantes();
            InicioEstudiante.Show();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form InicioEstudiante = new InicioEstudiantes();
            InicioEstudiante.Show();
        }

        private void EstadisticasLibroEstudiante_Click(object sender, EventArgs e)
        {
            EstadisticaEstudiante estadisticaEstudiante = new EstadisticaEstudiante();
            if (PanelContenedor.Contains(estadisticaEstudiante) == false)
            {
                PanelContenedor.Controls.Add(estadisticaEstudiante);
                estadisticaEstudiante.Dock = DockStyle.Fill;
                estadisticaEstudiante.BringToFront();
            }
            else
            {
                estadisticaEstudiante.BringToFront();
            }
        }

        private void EstadisticaDescargaEstudiantes_Click(object sender, EventArgs e)
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
