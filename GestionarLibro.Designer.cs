namespace EduBook
{
    partial class GestionarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarLibro));
            this.NombreDelLibroText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NombreLibro = new System.Windows.Forms.Label();
            this.CodigoDelLibroText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CodigoLibro = new System.Windows.Forms.Label();
            this.GeneroLibro = new System.Windows.Forms.Label();
            this.EditorialLibro = new System.Windows.Forms.Label();
            this.AutorLibro = new System.Windows.Forms.Label();
            this.ComboAutor = new MetroFramework.Controls.MetroComboBox();
            this.ComboEditorial = new MetroFramework.Controls.MetroComboBox();
            this.ComboGenero = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCargarFoto = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCargarPedf = new MetroFramework.Controls.MetroButton();
            this.archivoPdf = new AxAcroPDFLib.AxAcroPDF();
            this.mensajeToolTip = new MetroFramework.Components.MetroToolTip();
            this.mensajeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BotonEliminar = new System.Windows.Forms.PictureBox();
            this.DescripcionText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.pxFotoPortada = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BortonModificar = new System.Windows.Forms.PictureBox();
            this.BotonAceptar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.archivoPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxFotoPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BortonModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreDelLibroText
            // 
            this.NombreDelLibroText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreDelLibroText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreDelLibroText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NombreDelLibroText.HintForeColor = System.Drawing.Color.Empty;
            this.NombreDelLibroText.HintText = "";
            this.NombreDelLibroText.isPassword = false;
            this.NombreDelLibroText.LineFocusedColor = System.Drawing.Color.Green;
            this.NombreDelLibroText.LineIdleColor = System.Drawing.Color.Black;
            this.NombreDelLibroText.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.NombreDelLibroText.LineThickness = 3;
            this.NombreDelLibroText.Location = new System.Drawing.Point(258, 74);
            this.NombreDelLibroText.Margin = new System.Windows.Forms.Padding(4);
            this.NombreDelLibroText.Name = "NombreDelLibroText";
            this.NombreDelLibroText.Size = new System.Drawing.Size(244, 44);
            this.NombreDelLibroText.TabIndex = 63;
            this.NombreDelLibroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreDelLibroText.OnValueChanged += new System.EventHandler(this.NombreDelLibroText_OnValueChanged);
            // 
            // NombreLibro
            // 
            this.NombreLibro.AutoSize = true;
            this.NombreLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreLibro.Location = new System.Drawing.Point(138, 94);
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Size = new System.Drawing.Size(92, 24);
            this.NombreLibro.TabIndex = 58;
            this.NombreLibro.Text = "Nombre";
            // 
            // CodigoDelLibroText
            // 
            this.CodigoDelLibroText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodigoDelLibroText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CodigoDelLibroText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodigoDelLibroText.HintForeColor = System.Drawing.Color.Empty;
            this.CodigoDelLibroText.HintText = "";
            this.CodigoDelLibroText.isPassword = false;
            this.CodigoDelLibroText.LineFocusedColor = System.Drawing.Color.Green;
            this.CodigoDelLibroText.LineIdleColor = System.Drawing.Color.Black;
            this.CodigoDelLibroText.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.CodigoDelLibroText.LineThickness = 3;
            this.CodigoDelLibroText.Location = new System.Drawing.Point(258, 22);
            this.CodigoDelLibroText.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoDelLibroText.Name = "CodigoDelLibroText";
            this.CodigoDelLibroText.Size = new System.Drawing.Size(244, 44);
            this.CodigoDelLibroText.TabIndex = 64;
            this.CodigoDelLibroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CodigoDelLibroText.OnValueChanged += new System.EventHandler(this.CodigoDelLibroText_OnValueChanged);
            // 
            // CodigoLibro
            // 
            this.CodigoLibro.AutoSize = true;
            this.CodigoLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodigoLibro.Location = new System.Drawing.Point(146, 42);
            this.CodigoLibro.Name = "CodigoLibro";
            this.CodigoLibro.Size = new System.Drawing.Size(84, 24);
            this.CodigoLibro.TabIndex = 59;
            this.CodigoLibro.Text = "Codigo";
            // 
            // GeneroLibro
            // 
            this.GeneroLibro.AutoSize = true;
            this.GeneroLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneroLibro.Location = new System.Drawing.Point(144, 310);
            this.GeneroLibro.Name = "GeneroLibro";
            this.GeneroLibro.Size = new System.Drawing.Size(86, 24);
            this.GeneroLibro.TabIndex = 55;
            this.GeneroLibro.Text = "Genero";
            // 
            // EditorialLibro
            // 
            this.EditorialLibro.AutoSize = true;
            this.EditorialLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorialLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditorialLibro.Location = new System.Drawing.Point(134, 258);
            this.EditorialLibro.Name = "EditorialLibro";
            this.EditorialLibro.Size = new System.Drawing.Size(96, 24);
            this.EditorialLibro.TabIndex = 56;
            this.EditorialLibro.Text = "Editorial";
            // 
            // AutorLibro
            // 
            this.AutorLibro.AutoSize = true;
            this.AutorLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AutorLibro.Location = new System.Drawing.Point(163, 206);
            this.AutorLibro.Name = "AutorLibro";
            this.AutorLibro.Size = new System.Drawing.Size(67, 24);
            this.AutorLibro.TabIndex = 57;
            this.AutorLibro.Text = "Autor";
            // 
            // ComboAutor
            // 
            this.ComboAutor.FormattingEnabled = true;
            this.ComboAutor.ItemHeight = 23;
            this.ComboAutor.Location = new System.Drawing.Point(258, 206);
            this.ComboAutor.Name = "ComboAutor";
            this.ComboAutor.Size = new System.Drawing.Size(242, 29);
            this.ComboAutor.TabIndex = 67;
            this.ComboAutor.UseSelectable = true;
            this.ComboAutor.SelectedIndexChanged += new System.EventHandler(this.ComboAutor_SelectedIndexChanged);
            // 
            // ComboEditorial
            // 
            this.ComboEditorial.BackColor = System.Drawing.SystemColors.Window;
            this.ComboEditorial.FormattingEnabled = true;
            this.ComboEditorial.ItemHeight = 23;
            this.ComboEditorial.Location = new System.Drawing.Point(258, 253);
            this.ComboEditorial.Name = "ComboEditorial";
            this.ComboEditorial.Size = new System.Drawing.Size(242, 29);
            this.ComboEditorial.TabIndex = 67;
            this.ComboEditorial.UseSelectable = true;
            this.ComboEditorial.SelectedIndexChanged += new System.EventHandler(this.ComboEditorial_SelectedIndexChanged);
            // 
            // ComboGenero
            // 
            this.ComboGenero.FormattingEnabled = true;
            this.ComboGenero.ItemHeight = 23;
            this.ComboGenero.Location = new System.Drawing.Point(258, 305);
            this.ComboGenero.Name = "ComboGenero";
            this.ComboGenero.Size = new System.Drawing.Size(242, 29);
            this.ComboGenero.TabIndex = 67;
            this.ComboGenero.UseSelectable = true;
            this.ComboGenero.SelectedIndexChanged += new System.EventHandler(this.ComboGenero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Imagen de Portada";
            // 
            // botonCargarFoto
            // 
            this.botonCargarFoto.Location = new System.Drawing.Point(258, 362);
            this.botonCargarFoto.Name = "botonCargarFoto";
            this.botonCargarFoto.Size = new System.Drawing.Size(244, 23);
            this.botonCargarFoto.TabIndex = 96;
            this.botonCargarFoto.Text = "Cargar foto";
            this.botonCargarFoto.UseSelectable = true;
            this.botonCargarFoto.Click += new System.EventHandler(this.botonCargarFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(616, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 24);
            this.label2.TabIndex = 97;
            this.label2.Text = "Cargar Libro en formato PDF";
            // 
            // botonCargarPedf
            // 
            this.botonCargarPedf.Location = new System.Drawing.Point(717, 89);
            this.botonCargarPedf.Name = "botonCargarPedf";
            this.botonCargarPedf.Size = new System.Drawing.Size(123, 23);
            this.botonCargarPedf.TabIndex = 98;
            this.botonCargarPedf.Text = "Cargar PDF";
            this.botonCargarPedf.UseSelectable = true;
            this.botonCargarPedf.Click += new System.EventHandler(this.cargarPedf_Click);
            // 
            // archivoPdf
            // 
            this.archivoPdf.Enabled = true;
            this.archivoPdf.Location = new System.Drawing.Point(568, 118);
            this.archivoPdf.Name = "archivoPdf";
            this.archivoPdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("archivoPdf.OcxState")));
            this.archivoPdf.Size = new System.Drawing.Size(474, 345);
            this.archivoPdf.TabIndex = 99;
            this.archivoPdf.Enter += new System.EventHandler(this.archivoPdf_Enter);
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
            this.mensajeErrorProvider.SetIconAlignment(this.BotonEliminar, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.BotonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.Image")));
            this.BotonEliminar.Location = new System.Drawing.Point(415, 575);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(32, 32);
            this.BotonEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotonEliminar.TabIndex = 66;
            this.BotonEliminar.TabStop = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // DescripcionText
            // 
            this.DescripcionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescripcionText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DescripcionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescripcionText.HintForeColor = System.Drawing.Color.Empty;
            this.DescripcionText.HintText = "";
            this.DescripcionText.isPassword = false;
            this.DescripcionText.LineFocusedColor = System.Drawing.Color.Green;
            this.DescripcionText.LineIdleColor = System.Drawing.Color.Black;
            this.DescripcionText.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.DescripcionText.LineThickness = 3;
            this.DescripcionText.Location = new System.Drawing.Point(258, 135);
            this.DescripcionText.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionText.Name = "DescripcionText";
            this.DescripcionText.Size = new System.Drawing.Size(244, 44);
            this.DescripcionText.TabIndex = 101;
            this.DescripcionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescripcionText.OnValueChanged += new System.EventHandler(this.DescripcionText_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(97, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 100;
            this.label3.Text = "Descripcion";
            // 
            // pxFotoPortada
            // 
            this.pxFotoPortada.Location = new System.Drawing.Point(315, 396);
            this.pxFotoPortada.Name = "pxFotoPortada";
            this.pxFotoPortada.Size = new System.Drawing.Size(132, 127);
            this.pxFotoPortada.TabIndex = 95;
            this.pxFotoPortada.TabStop = false;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BotonBuscar.Image")));
            this.BotonBuscar.Location = new System.Drawing.Point(339, 575);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(32, 32);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonBuscar.TabIndex = 65;
            this.BotonBuscar.TabStop = false;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // BortonModificar
            // 
            this.BortonModificar.Image = ((System.Drawing.Image)(resources.GetObject("BortonModificar.Image")));
            this.BortonModificar.Location = new System.Drawing.Point(377, 575);
            this.BortonModificar.Name = "BortonModificar";
            this.BortonModificar.Size = new System.Drawing.Size(32, 32);
            this.BortonModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BortonModificar.TabIndex = 54;
            this.BortonModificar.TabStop = false;
            this.BortonModificar.Click += new System.EventHandler(this.BortonModificar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(301, 575);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(32, 32);
            this.BotonAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BotonAceptar.TabIndex = 53;
            this.BotonAceptar.TabStop = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // GestionarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DescripcionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.archivoPdf);
            this.Controls.Add(this.botonCargarPedf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonCargarFoto);
            this.Controls.Add(this.pxFotoPortada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboGenero);
            this.Controls.Add(this.ComboEditorial);
            this.Controls.Add(this.ComboAutor);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.GeneroLibro);
            this.Controls.Add(this.EditorialLibro);
            this.Controls.Add(this.AutorLibro);
            this.Controls.Add(this.NombreDelLibroText);
            this.Controls.Add(this.NombreLibro);
            this.Controls.Add(this.CodigoDelLibroText);
            this.Controls.Add(this.CodigoLibro);
            this.Controls.Add(this.BortonModificar);
            this.Controls.Add(this.BotonAceptar);
            this.Name = "GestionarLibro";
            this.Size = new System.Drawing.Size(1102, 725);
            ((System.ComponentModel.ISupportInitialize)(this.archivoPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxFotoPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BortonModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BortonModificar;
        private System.Windows.Forms.PictureBox BotonAceptar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreDelLibroText;
        private System.Windows.Forms.Label NombreLibro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CodigoDelLibroText;
        private System.Windows.Forms.Label CodigoLibro;
        private System.Windows.Forms.PictureBox BotonEliminar;
        private System.Windows.Forms.Label GeneroLibro;
        private System.Windows.Forms.Label EditorialLibro;
        private System.Windows.Forms.Label AutorLibro;
        private MetroFramework.Controls.MetroComboBox ComboAutor;
        private MetroFramework.Controls.MetroComboBox ComboEditorial;
        private MetroFramework.Controls.MetroComboBox ComboGenero;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton botonCargarFoto;
        private System.Windows.Forms.PictureBox pxFotoPortada;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton botonCargarPedf;
        private AxAcroPDFLib.AxAcroPDF archivoPdf;
        private MetroFramework.Components.MetroToolTip mensajeToolTip;
        private System.Windows.Forms.ErrorProvider mensajeErrorProvider;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescripcionText;
        private System.Windows.Forms.Label label3;
    }
}
