﻿using BLL;
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
    public partial class IniciarSesion : MetroFramework.Forms.MetroForm
    {
        UsuarioService usuarioService = new UsuarioService();
        public IniciarSesion()
        {
            InitializeComponent();
            usuarioService.EliminarSession();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuarioService.EliminarSession();
            progressBar1.Visible = false;
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();

            Usuario usuario = usuarioService.Login(TextUsuario.Text, TextContraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña errada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuario.inicio_session = true;
                usuarioService.GuardarSession(usuario);

                if (usuario.tipoUsuario.Equals("Administrador"))
                {                    
                    this.SetVisibleCore(false);
                    InicioAdministrador inicio = new InicioAdministrador();
                    inicio.Show();                   
                }

                if (usuario.tipoUsuario.Equals("Estudiante"))
                {
                    this.SetVisibleCore(false);
                    InicioEstudiantes inicio = new InicioEstudiantes();
                    inicio.Show();
                }

                if (usuario.tipoUsuario.Equals("Invitado"))
                {
                    this.SetVisibleCore(false);
                    InicioInvitado inicio = new InicioInvitado();
                    inicio.Show();
                }
            }
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar progressBar = new ProgressBar();
        }
    }
    }
