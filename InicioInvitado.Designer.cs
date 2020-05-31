namespace EduBook
{
    partial class InicioInvitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioInvitado));
            this.Estadistica = new System.Windows.Forms.Label();
            this.ConsultarLibroInvitado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Estadisticas = new System.Windows.Forms.PictureBox();
            this.ConsultarLibrosInvitado = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarLibrosInvitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Estadistica
            // 
            this.Estadistica.AutoSize = true;
            this.Estadistica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estadistica.Location = new System.Drawing.Point(104, 234);
            this.Estadistica.Name = "Estadistica";
            this.Estadistica.Size = new System.Drawing.Size(177, 32);
            this.Estadistica.TabIndex = 17;
            this.Estadistica.Text = "Estadisticas";
            this.Estadistica.Click += new System.EventHandler(this.Estadistica_Click);
            // 
            // ConsultarLibroInvitado
            // 
            this.ConsultarLibroInvitado.AutoSize = true;
            this.ConsultarLibroInvitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarLibroInvitado.Location = new System.Drawing.Point(104, 159);
            this.ConsultarLibroInvitado.Name = "ConsultarLibroInvitado";
            this.ConsultarLibroInvitado.Size = new System.Drawing.Size(218, 32);
            this.ConsultarLibroInvitado.TabIndex = 18;
            this.ConsultarLibroInvitado.Text = "Consultar Libro";
            this.ConsultarLibroInvitado.Click += new System.EventHandler(this.ConsultarLibroInvitado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inicio Invitado";
            // 
            // Estadisticas
            // 
            this.Estadisticas.Image = ((System.Drawing.Image)(resources.GetObject("Estadisticas.Image")));
            this.Estadisticas.Location = new System.Drawing.Point(28, 218);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(64, 64);
            this.Estadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Estadisticas.TabIndex = 16;
            this.Estadisticas.TabStop = false;
            this.Estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // ConsultarLibrosInvitado
            // 
            this.ConsultarLibrosInvitado.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarLibrosInvitado.Image")));
            this.ConsultarLibrosInvitado.Location = new System.Drawing.Point(28, 148);
            this.ConsultarLibrosInvitado.Name = "ConsultarLibrosInvitado";
            this.ConsultarLibrosInvitado.Size = new System.Drawing.Size(64, 64);
            this.ConsultarLibrosInvitado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConsultarLibrosInvitado.TabIndex = 15;
            this.ConsultarLibrosInvitado.TabStop = false;
            this.ConsultarLibrosInvitado.Click += new System.EventHandler(this.ConsultarLibrosInvitado_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(132, 35);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 61);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 14;
            this.Logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EduBook.Properties.Resources.flecha__1_;
            this.pictureBox1.Location = new System.Drawing.Point(274, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InicioInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Estadistica);
            this.Controls.Add(this.ConsultarLibroInvitado);
            this.Controls.Add(this.Estadisticas);
            this.Controls.Add(this.ConsultarLibrosInvitado);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label1);
            this.Name = "InicioInvitado";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.InicioInvitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarLibrosInvitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estadistica;
        private System.Windows.Forms.Label ConsultarLibroInvitado;
        private System.Windows.Forms.PictureBox Estadisticas;
        private System.Windows.Forms.PictureBox ConsultarLibrosInvitado;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}