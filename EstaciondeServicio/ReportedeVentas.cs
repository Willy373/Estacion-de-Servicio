using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstaciondeServicio
{
    public partial class ReportedeVentas : Form
    {
        public ReportedeVentas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            AddOwnedForm(menu);
            menu.lbl_usuario.Text = this.lbl_usuario.Text;
            menu.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fechor_actual.Text = DateTime.Now.ToString();
        }

        private void ReportedeVentas_Load(object sender, EventArgs e)
        {
            timerReporteVentas.Enabled = true;
        }
    }
}
