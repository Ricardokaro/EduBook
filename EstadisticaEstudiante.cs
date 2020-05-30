using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;

namespace EduBook
{
    public partial class EstadisticaEstudiante : UserControl
    {
        
        LibroService LibroService = new LibroService();
        public EstadisticaEstudiante()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void EstadisticaEstudiante_Load(object sender, EventArgs e)
        {
            this.CargarGraficaLibroMasVistos();
        }

        private void CargarGraficaLibroMasVistos() 
        {
            //configuarar la grafica 
            chartLibros.Titles.Clear();
            chartLibros.Series.Clear();
            chartLibros.ChartAreas.Clear();
            chartLibros.Palette = ChartColorPalette.SeaGreen;

            ChartArea areaGrafico = new ChartArea();
            areaGrafico.Area3DStyle.Enable3D = true;
            chartLibros.ChartAreas.Add(areaGrafico);

            Title titulo = new Title("Los 8 Libros mas Vistos");
            titulo.Font = new Font("Tahoma", 18, FontStyle.Bold);
            chartLibros.Titles.Add(titulo);

            Series serie = new Series("Libro");
            serie.ChartType = SeriesChartType.Column;
            serie.XValueMember = "nombre ";
            serie.YValueMembers = "total";
            serie.IsValueShownAsLabel = true;
            chartLibros.Series.Add(serie);

            chartLibros.DataSource = LibroService.ConsultarLibroMasVistoPorEstudiante();
        }
    }
}
