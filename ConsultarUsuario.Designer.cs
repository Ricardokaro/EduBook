namespace EduBook
{
    partial class ConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
            this.BontonBuscar = new System.Windows.Forms.PictureBox();
            this.GeneroUsuario = new MetroFramework.Controls.MetroComboBox();
            this.TipoDeDocumento = new MetroFramework.Controls.MetroComboBox();
            this.CorreoElectronico = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EdadUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Correo = new System.Windows.Forms.Label();
            this.ApellidoUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Edad = new System.Windows.Forms.Label();
            this.NombreUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label6 = new System.Windows.Forms.Label();
            this.NumeroDeDocumento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboTipodeUsuario = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pxFotoPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BontonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // BontonBuscar
            // 
            this.BontonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BontonBuscar.Image")));
            this.BontonBuscar.Location = new System.Drawing.Point(512, 27);
            this.BontonBuscar.Name = "BontonBuscar";
            this.BontonBuscar.Size = new System.Drawing.Size(32, 32);
            this.BontonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BontonBuscar.TabIndex = 77;
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
            this.GeneroUsuario.Location = new System.Drawing.Point(261, 280);
            this.GeneroUsuario.Name = "GeneroUsuario";
            this.GeneroUsuario.Size = new System.Drawing.Size(244, 29);
            this.GeneroUsuario.TabIndex = 76;
            this.GeneroUsuario.UseSelectable = true;
            // 
            // TipoDeDocumento
            // 
            this.TipoDeDocumento.FormattingEnabled = true;
            this.TipoDeDocumento.ItemHeight = 23;
            this.TipoDeDocumento.Items.AddRange(new object[] {
            "Tarjeta de identidad",
            "Cedula"});
            this.TipoDeDocumento.Location = new System.Drawing.Point(261, 129);
            this.TipoDeDocumento.Name = "TipoDeDocumento";
            this.TipoDeDocumento.Size = new System.Drawing.Size(244, 29);
            this.TipoDeDocumento.TabIndex = 75;
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
            this.CorreoElectronico.Location = new System.Drawing.Point(261, 363);
            this.CorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Size = new System.Drawing.Size(244, 44);
            this.CorreoElectronico.TabIndex = 71;
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
            this.EdadUsuario.Location = new System.Drawing.Point(261, 311);
            this.EdadUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.EdadUsuario.Name = "EdadUsuario";
            this.EdadUsuario.Size = new System.Drawing.Size(244, 44);
            this.EdadUsuario.TabIndex = 72;
            this.EdadUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Correo.Location = new System.Drawing.Point(55, 383);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(199, 24);
            this.Correo.TabIndex = 63;
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
            this.ApellidoUsuario.Location = new System.Drawing.Point(261, 207);
            this.ApellidoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            this.ApellidoUsuario.Size = new System.Drawing.Size(244, 44);
            this.ApellidoUsuario.TabIndex = 73;
            this.ApellidoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edad.Location = new System.Drawing.Point(192, 331);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(62, 24);
            this.Edad.TabIndex = 64;
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
            this.NombreUsuario.Location = new System.Drawing.Point(261, 155);
            this.NombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(244, 44);
            this.NombreUsuario.TabIndex = 74;
            this.NombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label6.Location = new System.Drawing.Point(168, 285);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 24);
            this.Label6.TabIndex = 65;
            this.Label6.Text = "Genero";
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
            this.NumeroDeDocumento.Location = new System.Drawing.Point(261, 15);
            this.NumeroDeDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.NumeroDeDocumento.Name = "NumeroDeDocumento";
            this.NumeroDeDocumento.Size = new System.Drawing.Size(244, 44);
            this.NumeroDeDocumento.TabIndex = 70;
            this.NumeroDeDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Location = new System.Drawing.Point(160, 227);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(94, 24);
            this.Label5.TabIndex = 66;
            this.Label5.Text = "Apellido";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Location = new System.Drawing.Point(162, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 24);
            this.Label4.TabIndex = 67;
            this.Label4.Text = "Nombre";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(9, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(245, 24);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "Numero de Documento";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(49, 134);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(205, 24);
            this.Label2.TabIndex = 69;
            this.Label2.Text = "Tipo de documento";
            // 
            // ComboTipodeUsuario
            // 
            this.ComboTipodeUsuario.FormattingEnabled = true;
            this.ComboTipodeUsuario.ItemHeight = 23;
            this.ComboTipodeUsuario.Items.AddRange(new object[] {
            "Invitado",
            "Estudiante"});
            this.ComboTipodeUsuario.Location = new System.Drawing.Point(261, 80);
            this.ComboTipodeUsuario.Name = "ComboTipodeUsuario";
            this.ComboTipodeUsuario.Size = new System.Drawing.Size(244, 29);
            this.ComboTipodeUsuario.TabIndex = 81;
            this.ComboTipodeUsuario.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(81, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 80;
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
            this.PasswordUsuario.Location = new System.Drawing.Point(261, 411);
            this.PasswordUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordUsuario.Name = "PasswordUsuario";
            this.PasswordUsuario.Size = new System.Drawing.Size(244, 44);
            this.PasswordUsuario.TabIndex = 89;
            this.PasswordUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(149, 431);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(99, 24);
            this.password.TabIndex = 88;
            this.password.Text = "Pasword";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(103, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 86;
            this.label7.Text = "Foto de Perfil";
            // 
            // pxFotoPerfil
            // 
            this.pxFotoPerfil.Location = new System.Drawing.Point(261, 484);
            this.pxFotoPerfil.Name = "pxFotoPerfil";
            this.pxFotoPerfil.Size = new System.Drawing.Size(114, 109);
            this.pxFotoPerfil.TabIndex = 85;
            this.pxFotoPerfil.TabStop = false;
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.PasswordUsuario);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pxFotoPerfil);
            this.Controls.Add(this.ComboTipodeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BontonBuscar);
            this.Controls.Add(this.GeneroUsuario);
            this.Controls.Add(this.TipoDeDocumento);
            this.Controls.Add(this.CorreoElectronico);
            this.Controls.Add(this.EdadUsuario);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.ApellidoUsuario);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.NumeroDeDocumento);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "ConsultarUsuario";
            this.Size = new System.Drawing.Size(556, 671);
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BontonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BontonBuscar;
        private MetroFramework.Controls.MetroComboBox GeneroUsuario;
        private MetroFramework.Controls.MetroComboBox TipoDeDocumento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CorreoElectronico;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EdadUsuario;
        private System.Windows.Forms.Label Correo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ApellidoUsuario;
        private System.Windows.Forms.Label Edad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreUsuario;
        private System.Windows.Forms.Label Label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NumeroDeDocumento;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private MetroFramework.Controls.MetroComboBox ComboTipodeUsuario;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordUsuario;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pxFotoPerfil;
    }
}
