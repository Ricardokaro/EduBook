namespace EduBook
{
    partial class ConsultarLibroEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLibroEstudiante));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtSeleccionarBusqueda = new MetroFramework.Controls.MetroComboBox();
            this.dataListadoLibros = new System.Windows.Forms.DataGridView();
            this.txtBuscadorDeLibros = new Bunifu.Framework.UI.BunifuTextbox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pdfLibro = new AxAcroPDFLib.AxAcroPDF();
            this.BotonDescargar = new System.Windows.Forms.PictureBox();
            this.BotonRegresar = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonDescargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 39);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(769, 404);
            this.metroTabControl1.TabIndex = 15;
            this.metroTabControl1.UseSelectable = true;            
            this.metroTabControl1.Click += new System.EventHandler(this.metroTabControl1_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtSeleccionarBusqueda);
            this.metroTabPage1.Controls.Add(this.dataListadoLibros);
            this.metroTabPage1.Controls.Add(this.txtBuscadorDeLibros);
            this.metroTabPage1.Controls.Add(this.Logo);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(761, 362);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Consultar Libro";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtSeleccionarBusqueda
            // 
            this.txtSeleccionarBusqueda.FormattingEnabled = true;
            this.txtSeleccionarBusqueda.ItemHeight = 23;
            this.txtSeleccionarBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.txtSeleccionarBusqueda.Location = new System.Drawing.Point(163, 47);
            this.txtSeleccionarBusqueda.Name = "txtSeleccionarBusqueda";
            this.txtSeleccionarBusqueda.Size = new System.Drawing.Size(143, 29);
            this.txtSeleccionarBusqueda.TabIndex = 12;
            this.txtSeleccionarBusqueda.UseSelectable = true;
            this.txtSeleccionarBusqueda.SelectedIndexChanged += new System.EventHandler(this.txtSeleccionarBusqueda_SelectedIndexChanged);
            // 
            // dataListadoLibros
            // 
            this.dataListadoLibros.AllowUserToAddRows = false;
            this.dataListadoLibros.AllowUserToDeleteRows = false;
            this.dataListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoLibros.Location = new System.Drawing.Point(147, 115);
            this.dataListadoLibros.MultiSelect = false;
            this.dataListadoLibros.Name = "dataListadoLibros";
            this.dataListadoLibros.ReadOnly = true;
            this.dataListadoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoLibros.Size = new System.Drawing.Size(439, 208);
            this.dataListadoLibros.TabIndex = 11;
            this.dataListadoLibros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataListadoLibros_MouseDoubleClick);
            // 
            // txtBuscadorDeLibros
            // 
            this.txtBuscadorDeLibros.BackColor = System.Drawing.Color.White;
            this.txtBuscadorDeLibros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscadorDeLibros.BackgroundImage")));
            this.txtBuscadorDeLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscadorDeLibros.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBuscadorDeLibros.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscadorDeLibros.Icon")));
            this.txtBuscadorDeLibros.Location = new System.Drawing.Point(323, 47);
            this.txtBuscadorDeLibros.Name = "txtBuscadorDeLibros";
            this.txtBuscadorDeLibros.Size = new System.Drawing.Size(263, 29);
            this.txtBuscadorDeLibros.TabIndex = 10;
            this.txtBuscadorDeLibros.text = "";
            this.txtBuscadorDeLibros.OnTextChange += new System.EventHandler(this.BuscadorDeLibros_OnTextChange);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(15, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(132, 95);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.pdfLibro);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(761, 362);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Leer y Descargar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // pdfLibro
            // 
            this.pdfLibro.Enabled = true;
            this.pdfLibro.Location = new System.Drawing.Point(3, 3);
            this.pdfLibro.Name = "pdfLibro";
            this.pdfLibro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfLibro.OcxState")));
            this.pdfLibro.Size = new System.Drawing.Size(762, 356);
            this.pdfLibro.TabIndex = 2;
            // 
            // BotonDescargar
            // 
            this.BotonDescargar.Image = global::EduBook.Properties.Resources.descargar;
            this.BotonDescargar.Location = new System.Drawing.Point(369, 452);
            this.BotonDescargar.Name = "BotonDescargar";
            this.BotonDescargar.Size = new System.Drawing.Size(46, 29);
            this.BotonDescargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonDescargar.TabIndex = 79;
            this.BotonDescargar.TabStop = false;
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRegresar.Image")));
            this.BotonRegresar.Location = new System.Drawing.Point(747, 452);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(32, 32);
            this.BotonRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonRegresar.TabIndex = 14;
            this.BotonRegresar.TabStop = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // ConsultarLibroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 501);
            this.Controls.Add(this.BotonDescargar);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.BotonRegresar);
            this.Name = "ConsultarLibroEstudiante";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.ConsultarLibroEstudiante_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonDescargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscadorDeLibros;
        private System.Windows.Forms.PictureBox BotonRegresar;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataListadoLibros;
        private MetroFramework.Controls.MetroComboBox txtSeleccionarBusqueda;
        private AxAcroPDFLib.AxAcroPDF pdfLibro;
        private System.Windows.Forms.PictureBox BotonDescargar;
    }
}