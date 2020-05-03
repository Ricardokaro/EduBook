namespace EduBook
{
    partial class GestionarAutor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarAutor));
            this.NombreAutor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoAutorText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CodigoLibro = new System.Windows.Forms.Label();
            this.mensajeToolTip = new MetroFramework.Components.MetroToolTip();
            this.mensajeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BotonEliminar = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BotonModificar = new System.Windows.Forms.PictureBox();
            this.BotonAceptar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreAutor
            // 
            this.NombreAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NombreAutor.HintForeColor = System.Drawing.Color.Empty;
            this.NombreAutor.HintText = "";
            this.NombreAutor.isPassword = false;
            this.NombreAutor.LineFocusedColor = System.Drawing.Color.Green;
            this.NombreAutor.LineIdleColor = System.Drawing.Color.Black;
            this.NombreAutor.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.NombreAutor.LineThickness = 3;
            this.NombreAutor.Location = new System.Drawing.Point(125, 122);
            this.NombreAutor.Margin = new System.Windows.Forms.Padding(4);
            this.NombreAutor.Name = "NombreAutor";
            this.NombreAutor.Size = new System.Drawing.Size(244, 44);
            this.NombreAutor.TabIndex = 84;
            this.NombreAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nombre";
            // 
            // CodigoAutorText
            // 
            this.CodigoAutorText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodigoAutorText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CodigoAutorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodigoAutorText.HintForeColor = System.Drawing.Color.Empty;
            this.CodigoAutorText.HintText = "";
            this.CodigoAutorText.isPassword = false;
            this.CodigoAutorText.LineFocusedColor = System.Drawing.Color.Green;
            this.CodigoAutorText.LineIdleColor = System.Drawing.Color.Black;
            this.CodigoAutorText.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.CodigoAutorText.LineThickness = 3;
            this.CodigoAutorText.Location = new System.Drawing.Point(125, 55);
            this.CodigoAutorText.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoAutorText.Name = "CodigoAutorText";
            this.CodigoAutorText.Size = new System.Drawing.Size(244, 44);
            this.CodigoAutorText.TabIndex = 82;
            this.CodigoAutorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CodigoLibro
            // 
            this.CodigoLibro.AutoSize = true;
            this.CodigoLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodigoLibro.Location = new System.Drawing.Point(34, 75);
            this.CodigoLibro.Name = "CodigoLibro";
            this.CodigoLibro.Size = new System.Drawing.Size(84, 24);
            this.CodigoLibro.TabIndex = 81;
            this.CodigoLibro.Text = "Codigo";
            // 
            // mensajeToolTip
            // 
            this.mensajeToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.mensajeToolTip.StyleManager = null;
            this.mensajeToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mensajeErrorProvider
            // 
            this.mensajeErrorProvider.ContainerControl = this;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.Image")));
            this.BotonEliminar.Location = new System.Drawing.Point(234, 188);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(32, 32);
            this.BotonEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonEliminar.TabIndex = 88;
            this.BotonEliminar.TabStop = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BotonBuscar.Image")));
            this.BotonBuscar.Location = new System.Drawing.Point(158, 188);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(32, 32);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonBuscar.TabIndex = 87;
            this.BotonBuscar.TabStop = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Image = ((System.Drawing.Image)(resources.GetObject("BotonModificar.Image")));
            this.BotonModificar.Location = new System.Drawing.Point(196, 188);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(32, 32);
            this.BotonModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonModificar.TabIndex = 86;
            this.BotonModificar.TabStop = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(120, 188);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(32, 32);
            this.BotonAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonAceptar.TabIndex = 85;
            this.BotonAceptar.TabStop = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // GestionarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.NombreAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoAutorText);
            this.Controls.Add(this.CodigoLibro);
            this.Name = "GestionarAutor";
            this.Size = new System.Drawing.Size(406, 263);
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BotonEliminar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.PictureBox BotonModificar;
        private System.Windows.Forms.PictureBox BotonAceptar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreAutor;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CodigoAutorText;
        private System.Windows.Forms.Label CodigoLibro;
        private MetroFramework.Components.MetroToolTip mensajeToolTip;
        private System.Windows.Forms.ErrorProvider mensajeErrorProvider;
    }
}
