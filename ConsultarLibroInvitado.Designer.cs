namespace EduBook
{
    partial class ConsultarLibroInvitado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLibroInvitado));
            this.BuscadorDeLibros = new Bunifu.Framework.UI.BunifuTextbox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BotonRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscadorDeLibros
            // 
            this.BuscadorDeLibros.BackColor = System.Drawing.Color.White;
            this.BuscadorDeLibros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscadorDeLibros.BackgroundImage")));
            this.BuscadorDeLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscadorDeLibros.ForeColor = System.Drawing.Color.SeaGreen;
            this.BuscadorDeLibros.Icon = ((System.Drawing.Image)(resources.GetObject("BuscadorDeLibros.Icon")));
            this.BuscadorDeLibros.Location = new System.Drawing.Point(189, 46);
            this.BuscadorDeLibros.Name = "BuscadorDeLibros";
            this.BuscadorDeLibros.Size = new System.Drawing.Size(382, 51);
            this.BuscadorDeLibros.TabIndex = 12;
            this.BuscadorDeLibros.text = "Buscar Libro";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(28, 17);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(132, 95);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRegresar.Image")));
            this.BotonRegresar.Location = new System.Drawing.Point(539, 415);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(32, 32);
            this.BotonRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonRegresar.TabIndex = 13;
            this.BotonRegresar.TabStop = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // ConsultarLibroInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.BotonRegresar);
            this.Controls.Add(this.BuscadorDeLibros);
            this.Controls.Add(this.Logo);
            this.Name = "ConsultarLibroInvitado";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.ConsultarLibroInvitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox BuscadorDeLibros;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox BotonRegresar;
    }
}