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
    public partial class ArqueoEconomico : Form
    {
        public ArqueoEconomico()
        {
            InitializeComponent();
        }
        LogicaSQL logSQL = new LogicaSQL();

        private void ArqueoEconomico_Load(object sender, EventArgs e)
        {
            timerArqueoEconomico.Enabled = true;
            lbl_combustible.Text = logSQL.consultaCombustible(lbl_usuario.Text);
            lbl_num_servicio.Text = logSQL.consultaNumeroPunto(lbl_usuario.Text);
            dataGridViewArqueo.DataSource = logSQL.consultaArqueoEconomico(lbl_usuario.Text, lbl_num_servicio.Text);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            AddOwnedForm(menu);
            menu.lbl_usuario.Text = this.lbl_usuario.Text;
            menu.Show();
            this.Hide();
        }

        private void timerArqueoEconomico_Tick(object sender, EventArgs e)
        {
            lbl_fechor_actual.Text = DateTime.Now.ToString();

        }


    }
}
