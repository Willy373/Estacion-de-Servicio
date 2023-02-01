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

namespace EstaciondeServicio
{
    public partial class PuntodeVenta : Form
    {
        public PuntodeVenta()
        {
            InitializeComponent();
        }
        LogicaSQL logSQL = new LogicaSQL();

        private void button2_Click(object sender, EventArgs e)
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

        private void timerPuntoVenta_Tick(object sender, EventArgs e)
        {
            lbl_fechor_actual.Text = DateTime.Now.ToString();
        }

        private void PuntodeVenta_Load(object sender, EventArgs e)
        {
            timerPuntoVenta.Enabled = true;
            lbl_combustible.Text = logSQL.consultaCombustible(lbl_usuario.Text);
            lbl_num_servicio.Text = logSQL.consultaNumeroPunto(lbl_usuario.Text);
            lbl_combus_disponible.Text = logSQL.consultaCombusDisponible(lbl_usuario.Text);
            lbl_limite_combus.Text = logSQL.consultaCombusLimite(lbl_usuario.Text);
        }
    }
}
