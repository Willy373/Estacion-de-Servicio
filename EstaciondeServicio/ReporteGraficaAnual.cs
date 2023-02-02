using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EstaciondeServicio
{
    public partial class ReporteGraficaAnual : Form
    {
        public ReporteGraficaAnual()
        {
            InitializeComponent();
        }

        LogicaSQL logSQL = new LogicaSQL();
        private void ReporteGraficaAnual_Load(object sender, EventArgs e)
        {
            timerGrafica.Enabled = true;
            String[] series = { "GASOLINA", "DIESEL" };

            chart1.Palette = ChartColorPalette.Pastel;
            

            double maxgaso = Math.Round(double.Parse(logSQL.consultaMaxGasolina()),2);
            double maxdiesel = Math.Round(double.Parse(logSQL.consultaMaxDiesel()),2);
            double[] puntos = { maxgaso, maxdiesel };

            chart1.Titles.Add("Litros");

            for (int i=0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label= puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        private void timerGrafica_Tick(object sender, EventArgs e)
        {
            lbl_fechor_actual.Text = DateTime.Now.ToString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            AddOwnedForm(menu);
            menu.lbl_usuario.Text = this.lbl_usuario.Text;
            menu.Show();
            this.Hide();
        }

        private void combo_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
