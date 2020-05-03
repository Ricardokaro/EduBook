namespace EduBook
{
    partial class GestionarEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarEditorial));
            this.NombreEditorial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoEditorialText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CodigoLibro = new System.Windows.Forms.Label();
            this.BotonEliminar = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BotonModificar = new System.Windows.Forms.PictureBox();
            this.BotonAceptar = new System.Windows.Forms.PictureBox();
            this.mensajeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mensajeToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreEditorial
            // 
            this.NombreEditorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreEditorial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NombreEditorial.HintForeColor = System.Drawing.Color.Empty;
            this.NombreEditorial.HintText = "";
            this.NombreEditorial.isPassword = false;
            this.NombreEditorial.LineFocusedColor = System.Drawing.Color.Green;
            this.NombreEditorial.LineIdleColor = System.Drawing.Color.Black;
            this.NombreEditorial.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.NombreEditorial.LineThickness = 3;
            this.NombreEditorial.Location = new System.Drawing.Point(119, 133);
            this.NombreEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.NombreEditorial.Name = "NombreEditorial";
            this.NombreEditorial.Size = new System.Drawing.Size(244, 44);
            this.NombreEditorial.TabIndex = 76;
            this.NombreEditorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nombre";
            // 
            // CodigoEditorialText
            // 
            this.CodigoEditorialText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodigoEditorialText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CodigoEditorialText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodigoEditorialText.HintForeColor = System.Drawing.Color.Empty;
            this.CodigoEditorialText.HintText = "";
            this.CodigoEditorialText.isPassword = false;
            this.CodigoEditorialText.LineFocusedColor = System.Drawing.Color.Green;
            this.CodigoEditorialText.LineIdleColor = System.Drawing.Color.Black;
            this.CodigoEditorialText.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.CodigoEditorialText.LineThickness = 3;
            this.CodigoEditorialText.Location = new System.Drawing.Point(119, 66);
            this.CodigoEditorialText.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoEditorialText.Name = "CodigoEditorialText";
            this.CodigoEditorialText.Size = new System.Drawing.Size(244, 44);
            this.CodigoEditorialText.TabIndex = 74;
            this.CodigoEditorialText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CodigoLibro
            // 
            this.CodigoLibro.AutoSize = true;
            this.CodigoLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodigoLibro.Location = new System.Drawing.Point(28, 86);
            this.CodigoLibro.Name = "CodigoLibro";
            this.CodigoLibro.Size = new System.Drawing.Size(84, 24);
            this.CodigoLibro.TabIndex = 73;
            this.CodigoLibro.Text = "Codigo";
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.Image")));
            this.BotonEliminar.Location = new System.Drawing.Point(228, 199);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(32, 32);
            this.BotonEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonEliminar.TabIndex = 80;
            this.BotonEliminar.TabStop = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BotonBuscar.Image")));
            this.BotonBuscar.Location = new System.Drawing.Point(152, 199);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(32, 32);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonBuscar.TabIndex = 79;
            this.BotonBuscar.TabStop = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Image = ((System.Drawing.Image)(resources.GetObject("BotonModificar.Image")));
            this.BotonModificar.Location = new System.Drawing.Point(190, 199);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(32, 32);
            this.BotonModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonModificar.TabIndex = 78;
            this.BotonModificar.TabStop = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(114, 199);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(32, 32);
            this.BotonAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonAceptar.TabIndex = 77;
            this.BotonAceptar.TabStop = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // mensajeErrorProvider
            // 
            this.mensajeErrorProvider.ContainerControl = this;
            // 
            // mensajeToolTip
            // 
            this.mensajeToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.mensajeToolTip.StyleManager = null;
            this.mensajeToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // GestionarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.NombreEditorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoEditorialText);
            this.Controls.Add(this.CodigoLibro);
            this.Name = "GestionarEditorial";
            this.Size = new System.Drawing.Size(395, 286);
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BotonEliminar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.PictureBox BotonModificar;
        private System.Windows.Forms.PictureBox BotonAceptar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreEditorial;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CodigoEditorialText;
        private System.Windows.Forms.Label CodigoLibro;
        private System.Windows.Forms.ErrorProvider mensajeErrorProvider;
        private MetroFramework.Components.MetroToolTip mensajeToolTip;
    }
}
