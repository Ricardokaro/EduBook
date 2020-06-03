using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;

namespace EduBook
{
    public partial class EstadisticaEstudianteLibroMasDescargado : UserControl
    {
        LibroService libroService = new LibroService();
        public EstadisticaEstudianteLibroMasDescargado()
        {
            InitializeComponent();
        }

        private void EstadisticaEstudianteLibroMasDescargado_Load(object sender, EventArgs e)
        {
            this.CargarGraficaLibroMasDescargadoPorEstudiante();
        }

        private void CargarGraficaLibroMasDescargadoPorEstudiante() 
        {
            //configuarar la grafica 
            chartLibros.Titles.Clear();
            chartLibros.Series.Clear();
            chartLibros.ChartAreas.Clear();
            chartLibros.Palette = ChartColorPalette.SeaGreen;

            ChartArea areaGrafico = new ChartArea();
            areaGrafico.Area3DStyle.Enable3D = true;
            chartLibros.ChartAreas.Add(areaGrafico);

            Title titulo = new Title("Los 8 Libros mas Descargados");
            titulo.Font = new Font("Tahoma", 18, FontStyle.Bold);
            chartLibros.Titles.Add(titulo);

            Series serie = new Series("Libro");
            serie.ChartType = SeriesChartType.Column;
            serie.XValueMember = "nombre ";
            serie.YValueMembers = "total";
            serie.IsValueShownAsLabel = true;
            chartLibros.Series.Add(serie);

            chartLibros.DataSource = libroService.ConsultarLibroMasDescargadoPorEstudiante();
        }
    }
}
