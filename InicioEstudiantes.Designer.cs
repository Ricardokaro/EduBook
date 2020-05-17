namespace EduBook
{
    partial class InicioEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioEstudiantes));
            this.Estadistica = new System.Windows.Forms.Label();
            this.ConsultarLibroEstudiante = new System.Windows.Forms.Label();
            this.Estadisticas = new System.Windows.Forms.PictureBox();
            this.ConsultarLibrosEstudiante = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarLibrosEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Estadistica
            // 
            this.Estadistica.AutoSize = true;
            this.Estadistica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estadistica.Location = new System.Drawing.Point(112, 216);
            this.Estadistica.Name = "Estadistica";
            this.Estadistica.Size = new System.Drawing.Size(177, 32);
            this.Estadistica.TabIndex = 11;
            this.Estadistica.Text = "Estadisticas";
            this.Estadistica.Click += new System.EventHandler(this.Estadistica_Click);
            // 
            // ConsultarLibroEstudiante
            // 
            this.ConsultarLibroEstudiante.AutoSize = true;
            this.ConsultarLibroEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarLibroEstudiante.Location = new System.Drawing.Point(112, 141);
            this.ConsultarLibroEstudiante.Name = "ConsultarLibroEstudiante";
            this.ConsultarLibroEstudiante.Size = new System.Drawing.Size(218, 32);
            this.ConsultarLibroEstudiante.TabIndex = 12;
            this.ConsultarLibroEstudiante.Text = "Consultar Libro";
            this.ConsultarLibroEstudiante.Click += new System.EventHandler(this.ConsultarLibroEstudiante_Click);
            // 
            // Estadisticas
            // 
            this.Estadisticas.Image = ((System.Drawing.Image)(resources.GetObject("Estadisticas.Image")));
            this.Estadisticas.Location = new System.Drawing.Point(36, 200);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(64, 64);
            this.Estadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Estadisticas.TabIndex = 10;
            this.Estadisticas.TabStop = false;
            this.Estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // ConsultarLibrosEstudiante
            // 
            this.ConsultarLibrosEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarLibrosEstudiante.Image")));
            this.ConsultarLibrosEstudiante.Location = new System.Drawing.Point(36, 130);
            this.ConsultarLibrosEstudiante.Name = "ConsultarLibrosEstudiante";
            this.ConsultarLibrosEstudiante.Size = new System.Drawing.Size(64, 64);
            this.ConsultarLibrosEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConsultarLibrosEstudiante.TabIndex = 9;
            this.ConsultarLibrosEstudiante.TabStop = false;
            this.ConsultarLibrosEstudiante.Click += new System.EventHandler(this.ConsultarLibrosEstudiante_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(138, 34);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 61);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // InicioEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 296);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Estadistica);
            this.Controls.Add(this.ConsultarLibroEstudiante);
            this.Controls.Add(this.Estadisticas);
            this.Controls.Add(this.ConsultarLibrosEstudiante);
            this.Name = "InicioEstudiantes";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.InicioEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarLibrosEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estadistica;
        private System.Windows.Forms.Label ConsultarLibroEstudiante;
        private System.Windows.Forms.PictureBox Estadisticas;
        private System.Windows.Forms.PictureBox ConsultarLibrosEstudiante;
        private System.Windows.Forms.PictureBox Logo;
    }
}