namespace EduBook
{
    partial class GestionarGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarGenero));
            this.CodigoDelGeneroText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CodigoLibro = new System.Windows.Forms.Label();
            this.NombreGenero = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonEliminar = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BotonModificar = new System.Windows.Forms.PictureBox();
            this.BotonAceptar = new System.Windows.Forms.PictureBox();
            this.mensajeToolTip = new MetroFramework.Components.MetroToolTip();
            this.mensajeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoDelGeneroText
            // 
            this.CodigoDelGeneroText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodigoDelGeneroText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CodigoDelGeneroText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodigoDelGeneroText.HintForeColor = System.Drawing.Color.Empty;
            this.CodigoDelGeneroText.HintText = "";
            this.CodigoDelGeneroText.isPassword = false;
            this.CodigoDelGeneroText.LineFocusedColor = System.Drawing.Color.Green;
            this.CodigoDelGeneroText.LineIdleColor = System.Drawing.Color.Black;
            this.CodigoDelGeneroText.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.CodigoDelGeneroText.LineThickness = 3;
            this.CodigoDelGeneroText.Location = new System.Drawing.Point(146, 63);
            this.CodigoDelGeneroText.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoDelGeneroText.Name = "CodigoDelGeneroText";
            this.CodigoDelGeneroText.Size = new System.Drawing.Size(244, 44);
            this.CodigoDelGeneroText.TabIndex = 66;
            this.CodigoDelGeneroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CodigoLibro
            // 
            this.CodigoLibro.AutoSize = true;
            this.CodigoLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodigoLibro.Location = new System.Drawing.Point(55, 83);
            this.CodigoLibro.Name = "CodigoLibro";
            this.CodigoLibro.Size = new System.Drawing.Size(84, 24);
            this.CodigoLibro.TabIndex = 65;
            this.CodigoLibro.Text = "Codigo";
            // 
            // NombreGenero
            // 
            this.NombreGenero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NombreGenero.HintForeColor = System.Drawing.Color.Empty;
            this.NombreGenero.HintText = "";
            this.NombreGenero.isPassword = false;
            this.NombreGenero.LineFocusedColor = System.Drawing.Color.Green;
            this.NombreGenero.LineIdleColor = System.Drawing.Color.Black;
            this.NombreGenero.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.NombreGenero.LineThickness = 3;
            this.NombreGenero.Location = new System.Drawing.Point(146, 130);
            this.NombreGenero.Margin = new System.Windows.Forms.Padding(4);
            this.NombreGenero.Name = "NombreGenero";
            this.NombreGenero.Size = new System.Drawing.Size(244, 44);
            this.NombreGenero.TabIndex = 68;
            this.NombreGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nombre";
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.Image")));
            this.BotonEliminar.Location = new System.Drawing.Point(255, 196);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(32, 32);
            this.BotonEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonEliminar.TabIndex = 72;
            this.BotonEliminar.TabStop = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BotonBuscar.Image")));
            this.BotonBuscar.Location = new System.Drawing.Point(179, 196);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(32, 32);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonBuscar.TabIndex = 71;
            this.BotonBuscar.TabStop = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Image = ((System.Drawing.Image)(resources.GetObject("BotonModificar.Image")));
            this.BotonModificar.Location = new System.Drawing.Point(217, 196);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(32, 32);
            this.BotonModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonModificar.TabIndex = 70;
            this.BotonModificar.TabStop = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(141, 196);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(32, 32);
            this.BotonAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonAceptar.TabIndex = 69;
            this.BotonAceptar.TabStop = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
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
            // GestionarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.NombreGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoDelGeneroText);
            this.Controls.Add(this.CodigoLibro);
            this.Name = "GestionarGenero";
            this.Size = new System.Drawing.Size(421, 287);
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox CodigoDelGeneroText;
        private System.Windows.Forms.Label CodigoLibro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BotonEliminar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.PictureBox BotonModificar;
        private System.Windows.Forms.PictureBox BotonAceptar;
        private MetroFramework.Components.MetroToolTip mensajeToolTip;
        private System.Windows.Forms.ErrorProvider mensajeErrorProvider;
    }
}
