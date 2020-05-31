namespace EduBook
{
    partial class EstadisticaInvitado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLibrosInvitados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosInvitados)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLibrosInvitados
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLibrosInvitados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLibrosInvitados.Legends.Add(legend2);
            this.chartLibrosInvitados.Location = new System.Drawing.Point(3, 3);
            this.chartLibrosInvitados.Name = "chartLibrosInvitados";
            this.chartLibrosInvitados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLibrosInvitados.Series.Add(series2);
            this.chartLibrosInvitados.Size = new System.Drawing.Size(417, 220);
            this.chartLibrosInvitados.TabIndex = 1;
            this.chartLibrosInvitados.Text = "chart1";
            // 
            // EstadisticaInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartLibrosInvitados);
            this.Name = "EstadisticaInvitado";
            this.Size = new System.Drawing.Size(425, 231);
            this.Load += new System.EventHandler(this.EstadisticaInvitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosInvitados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibrosInvitados;
    }
}
