using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace EduBook
{
    public partial class EstadisticaInvitado : UserControl
    {
        LibroService libroService = new LibroService();
        public EstadisticaInvitado()
        {
            InitializeComponent();
        }

        private void EstadisticaInvitado_Load(object sender, EventArgs e)
        {
            this.CargarGraficaLibroMasVistos();
        }

        private void CargarGraficaLibroMasVistos()
        {
            //configuarar la grafica 
            chartLibrosInvitados.Titles.Clear();
            chartLibrosInvitados.Series.Clear();
            chartLibrosInvitados.ChartAreas.Clear();
            chartLibrosInvitados.Palette = ChartColorPalette.SeaGreen;

            ChartArea areaGrafico = new ChartArea();
            areaGrafico.Area3DStyle.Enable3D = true;
            chartLibrosInvitados.ChartAreas.Add(areaGrafico);

            Title titulo = new Title("Los 8 Libros mas Vistos");
            titulo.Font = new Font("Tahoma", 18, FontStyle.Bold);
            chartLibrosInvitados.Titles.Add(titulo);

            Series serie = new Series("Libro");
            serie.ChartType = SeriesChartType.Column;
            serie.XValueMember = "nombre ";
            serie.YValueMembers = "total";
            serie.IsValueShownAsLabel = true;
            chartLibrosInvitados.Series.Add(serie);

            chartLibrosInvitados.DataSource = libroService.ConsultarLibroMasVistoPorInvitado();
        }
    }
}
