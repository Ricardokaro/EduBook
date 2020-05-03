namespace EduBook
{
    partial class EliminarUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuario));
            this.BotonCancelar = new System.Windows.Forms.PictureBox();
            this.BotonAceptar = new System.Windows.Forms.PictureBox();
            this.BontonBuscar = new System.Windows.Forms.PictureBox();
            this.GeneroUsuario = new MetroFramework.Controls.MetroComboBox();
            this.TipoDeDocumento = new MetroFramework.Controls.MetroComboBox();
            this.CorreoElectronico = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EdadUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Correo = new System.Windows.Forms.Label();
            this.ApellidoUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Edad = new System.Windows.Forms.Label();
            this.NombreUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Genero = new System.Windows.Forms.Label();
            this.NumeroDeDocumento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Apellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.NumeroDocumento = new System.Windows.Forms.Label();
            this.TipoDocumento = new System.Windows.Forms.Label();
            this.ComboTipodeUsuario = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pxFotoPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BontonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCancelar.Image")));
            this.BotonCancelar.Location = new System.Drawing.Point(369, 609);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(32, 32);
            this.BotonCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonCancelar.TabIndex = 62;
            this.BotonCancelar.TabStop = false;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(331, 609);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(32, 32);
            this.BotonAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonAceptar.TabIndex = 61;
            this.BotonAceptar.TabStop = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BontonBuscar
            // 
            this.BontonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BontonBuscar.Image")));
            this.BontonBuscar.Location = new System.Drawing.Point(513, 40);
            this.BontonBuscar.Name = "BontonBuscar";
            this.BontonBuscar.Size = new System.Drawing.Size(32, 32);
            this.BontonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BontonBuscar.TabIndex = 60;
            this.BontonBuscar.TabStop = false;
            this.BontonBuscar.Click += new System.EventHandler(this.BontonBuscar_Click);
            // 
            // GeneroUsuario
            // 
            this.GeneroUsuario.FormattingEnabled = true;
            this.GeneroUsuario.ItemHeight = 23;
            this.GeneroUsuario.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.GeneroUsuario.Location = new System.Drawing.Point(259, 281);
            this.GeneroUsuario.Name = "GeneroUsuario";
            this.GeneroUsuario.Size = new System.Drawing.Size(244, 29);
            this.GeneroUsuario.TabIndex = 59;
            this.GeneroUsuario.UseSelectable = true;
            // 
            // TipoDeDocumento
            // 
            this.TipoDeDocumento.FormattingEnabled = true;
            this.TipoDeDocumento.ItemHeight = 23;
            this.TipoDeDocumento.Items.AddRange(new object[] {
            "Cedula",
            "Tarjeta de identidad"});
            this.TipoDeDocumento.Location = new System.Drawing.Point(259, 137);
            this.TipoDeDocumento.Name = "TipoDeDocumento";
            this.TipoDeDocumento.Size = new System.Drawing.Size(244, 29);
            this.TipoDeDocumento.TabIndex = 58;
            this.TipoDeDocumento.UseSelectable = true;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorreoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CorreoElectronico.HintForeColor = System.Drawing.Color.Empty;
            this.CorreoElectronico.HintText = "";
            this.CorreoElectronico.isPassword = false;
            this.CorreoElectronico.LineFocusedColor = System.Drawing.Color.Green;
            this.CorreoElectronico.LineIdleColor = System.Drawing.Color.Black;
            this.CorreoElectronico.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.CorreoElectronico.LineThickness = 3;
            this.CorreoElectronico.Location = new System.Drawing.Point(259, 364);
            this.CorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Size = new System.Drawing.Size(244, 44);
            this.CorreoElectronico.TabIndex = 54;
            this.CorreoElectronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EdadUsuario
            // 
            this.EdadUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EdadUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EdadUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EdadUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.EdadUsuario.HintText = "";
            this.EdadUsuario.isPassword = false;
            this.EdadUsuario.LineFocusedColor = System.Drawing.Color.Green;
            this.EdadUsuario.LineIdleColor = System.Drawing.Color.Black;
            this.EdadUsuario.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.EdadUsuario.LineThickness = 3;
            this.EdadUsuario.Location = new System.Drawing.Point(259, 312);
            this.EdadUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.EdadUsuario.Name = "EdadUsuario";
            this.EdadUsuario.Size = new System.Drawing.Size(244, 44);
            this.EdadUsuario.TabIndex = 55;
            this.EdadUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Correo.Location = new System.Drawing.Point(53, 384);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(199, 24);
            this.Correo.TabIndex = 46;
            this.Correo.Text = "CorreoElectronico";
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApellidoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ApellidoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ApellidoUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.ApellidoUsuario.HintText = "";
            this.ApellidoUsuario.isPassword = false;
            this.ApellidoUsuario.LineFocusedColor = System.Drawing.Color.Green;
            this.ApellidoUsuario.LineIdleColor = System.Drawing.Color.Black;
            this.ApellidoUsuario.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.ApellidoUsuario.LineThickness = 3;
            this.ApellidoUsuario.Location = new System.Drawing.Point(259, 208);
            this.ApellidoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            this.ApellidoUsuario.Size = new System.Drawing.Size(244, 44);
            this.ApellidoUsuario.TabIndex = 56;
            this.ApellidoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edad.Location = new System.Drawing.Point(190, 332);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(62, 24);
            this.Edad.TabIndex = 47;
            this.Edad.Text = "Edad";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NombreUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.NombreUsuario.HintText = "";
            this.NombreUsuario.isPassword = false;
            this.NombreUsuario.LineFocusedColor = System.Drawing.Color.Green;
            this.NombreUsuario.LineIdleColor = System.Drawing.Color.Black;
            this.NombreUsuario.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.NombreUsuario.LineThickness = 3;
            this.NombreUsuario.Location = new System.Drawing.Point(259, 156);
            this.NombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(244, 44);
            this.NombreUsuario.TabIndex = 57;
            this.NombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Genero.Location = new System.Drawing.Point(166, 286);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(86, 24);
            this.Genero.TabIndex = 48;
            this.Genero.Text = "Genero";
            // 
            // NumeroDeDocumento
            // 
            this.NumeroDeDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumeroDeDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumeroDeDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumeroDeDocumento.HintForeColor = System.Drawing.Color.Empty;
            this.NumeroDeDocumento.HintText = "";
            this.NumeroDeDocumento.isPassword = false;
            this.NumeroDeDocumento.LineFocusedColor = System.Drawing.Color.Green;
            this.NumeroDeDocumento.LineIdleColor = System.Drawing.Color.Black;
            this.NumeroDeDocumento.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.NumeroDeDocumento.LineThickness = 3;
            this.NumeroDeDocumento.Location = new System.Drawing.Point(259, 28);
            this.NumeroDeDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.NumeroDeDocumento.Name = "NumeroDeDocumento";
            this.NumeroDeDocumento.Size = new System.Drawing.Size(244, 44);
            this.NumeroDeDocumento.TabIndex = 53;
            this.NumeroDeDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Apellido.Location = new System.Drawing.Point(158, 228);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(94, 24);
            this.Apellido.TabIndex = 49;
            this.Apellido.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombre.Location = new System.Drawing.Point(160, 176);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(92, 24);
            this.Nombre.TabIndex = 50;
            this.Nombre.Text = "Nombre";
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.AutoSize = true;
            this.NumeroDocumento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumeroDocumento.Location = new System.Drawing.Point(7, 48);
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.Size = new System.Drawing.Size(245, 24);
            this.NumeroDocumento.TabIndex = 51;
            this.NumeroDocumento.Text = "Numero de Documento";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.AutoSize = true;
            this.TipoDocumento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TipoDocumento.Location = new System.Drawing.Point(47, 142);
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Size = new System.Drawing.Size(205, 24);
            this.TipoDocumento.TabIndex = 52;
            this.TipoDocumento.Text = "Tipo de documento";
            // 
            // ComboTipodeUsuario
            // 
            this.ComboTipodeUsuario.FormattingEnabled = true;
            this.ComboTipodeUsuario.ItemHeight = 23;
            this.ComboTipodeUsuario.Items.AddRange(new object[] {
            "Invitado",
            "Estudiante"});
            this.ComboTipodeUsuario.Location = new System.Drawing.Point(259, 92);
            this.ComboTipodeUsuario.Name = "ComboTipodeUsuario";
            this.ComboTipodeUsuario.Size = new System.Drawing.Size(244, 29);
            this.ComboTipodeUsuario.TabIndex = 83;
            this.ComboTipodeUsuario.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(79, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tipo de usuario";
            // 
            // PasswordUsuario
            // 
            this.PasswordUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordUsuario.HintText = "";
            this.PasswordUsuario.isPassword = false;
            this.PasswordUsuario.LineFocusedColor = System.Drawing.Color.Green;
            this.PasswordUsuario.LineIdleColor = System.Drawing.Color.Black;
            this.PasswordUsuario.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.PasswordUsuario.LineThickness = 3;
            this.PasswordUsuario.Location = new System.Drawing.Point(261, 413);
            this.PasswordUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordUsuario.Name = "PasswordUsuario";
            this.PasswordUsuario.Size = new System.Drawing.Size(244, 44);
            this.PasswordUsuario.TabIndex = 97;
            this.PasswordUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(149, 433);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(99, 24);
            this.password.TabIndex = 96;
            this.password.Text = "Pasword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(103, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Foto de Perfil";
            // 
            // pxFotoPerfil
            // 
            this.pxFotoPerfil.Location = new System.Drawing.Point(306, 476);
            this.pxFotoPerfil.Name = "pxFotoPerfil";
            this.pxFotoPerfil.Size = new System.Drawing.Size(132, 127);
            this.pxFotoPerfil.TabIndex = 94;
            this.pxFotoPerfil.TabStop = false;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.PasswordUsuario);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pxFotoPerfil);
            this.Controls.Add(this.ComboTipodeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BontonBuscar);
            this.Controls.Add(this.GeneroUsuario);
            this.Controls.Add(this.TipoDeDocumento);
            this.Controls.Add(this.CorreoElectronico);
            this.Controls.Add(this.EdadUsuario);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.ApellidoUsuario);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.NumeroDeDocumento);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.NumeroDocumento);
            this.Controls.Add(this.TipoDocumento);
            this.Name = "EliminarUsuario";
            this.Size = new System.Drawing.Size(565, 661);
            ((System.ComponentModel.ISupportInitialize)(this.BotonCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BontonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BotonCancelar;
        private System.Windows.Forms.PictureBox BotonAceptar;
        private System.Windows.Forms.PictureBox BontonBuscar;
        private MetroFramework.Controls.MetroComboBox GeneroUsuario;
        private MetroFramework.Controls.MetroComboBox TipoDeDocumento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CorreoElectronico;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EdadUsuario;
        private System.Windows.Forms.Label Correo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ApellidoUsuario;
        private System.Windows.Forms.Label Edad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreUsuario;
        private System.Windows.Forms.Label Genero;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NumeroDeDocumento;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label NumeroDocumento;
        private System.Windows.Forms.Label TipoDocumento;
        private MetroFramework.Controls.MetroComboBox ComboTipodeUsuario;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordUsuario;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pxFotoPerfil;
    }
}
