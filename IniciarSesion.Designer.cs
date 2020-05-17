namespace EduBook
{
    partial class IniciarSesion
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TextUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BotonIngresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesion";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(60, 61);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(228, 148);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // TextUsuario
            // 
            this.TextUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsuario.ForeColor = System.Drawing.Color.Silver;
            this.TextUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.TextUsuario.HintText = "";
            this.TextUsuario.isPassword = false;
            this.TextUsuario.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.TextUsuario.LineIdleColor = System.Drawing.Color.Black;
            this.TextUsuario.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextUsuario.LineThickness = 3;
            this.TextUsuario.Location = new System.Drawing.Point(69, 220);
            this.TextUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(208, 44);
            this.TextUsuario.TabIndex = 4;
            this.TextUsuario.Text = "Ingrese Usuario";
            this.TextUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
           
            // 
            // TextContraseña
            // 
            this.TextContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContraseña.ForeColor = System.Drawing.Color.Silver;
            this.TextContraseña.HintForeColor = System.Drawing.Color.Empty;
            this.TextContraseña.HintText = "";
            this.TextContraseña.isPassword = true;
            this.TextContraseña.LineFocusedColor = System.Drawing.Color.Green;
            this.TextContraseña.LineIdleColor = System.Drawing.Color.Black;
            this.TextContraseña.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.TextContraseña.LineThickness = 3;
            this.TextContraseña.Location = new System.Drawing.Point(69, 274);
            this.TextContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(208, 44);
            this.TextContraseña.TabIndex = 4;
            this.TextContraseña.Text = "Ingrese contr";
            this.TextContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.Image = ((System.Drawing.Image)(resources.GetObject("BotonIngresar.Image")));
            this.BotonIngresar.Location = new System.Drawing.Point(146, 337);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(48, 48);
            this.BotonIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonIngresar.TabIndex = 5;
            this.BotonIngresar.TabStop = false;
            this.BotonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 407);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "IniciarSesion";
            this.Padding = new System.Windows.Forms.Padding(43, 111, 43, 37);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextContraseña;
        private System.Windows.Forms.PictureBox BotonIngresar;
    }
}

