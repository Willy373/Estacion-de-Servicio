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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        LogicaSQL logSQL = new LogicaSQL();
        public void limpiar()
        {
            txt_nom_usuario.Text = "";
            txt_contraseña.Text = "";
            txt_combustible.Text = "";
            combo_estacion.SelectedIndex = -1;
        }

        public void cerrar()
        {
            txt_nom_usuario.Enabled = false;    
            txt_contraseña.Enabled= false;  
            combo_estacion.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            AddOwnedForm(menu);
            menu.lbl_usuario.Text = this.lbl_usuario.Text;
            menu.Show();
            this.Hide();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            timerUsuarios.Enabled = true;
            dataGridViewUsuarios.DataSource = logSQL.consultaUsuarios();
        }

        private void timerUsuarios_Tick(object sender, EventArgs e)
        {
            lbl_fechor_actual.Text = DateTime.Now.ToString();
        }

        private void btn_actualizar_usuario_Click(object sender, EventArgs e)
        {
            if (txt_nom_usuario.Text != "" && txt_contraseña.Text != "")
            {
                logSQL.consultaActualizarUsuarios(txt_nom_usuario.Text, txt_contraseña.Text, combo_estacion.Text);
                dataGridViewUsuarios.DataSource = logSQL.consultaUsuarios();
                MessageBox.Show("Usuario Actualizado");
                limpiar();
                cerrar();
            }
            else
            {
                MessageBox.Show("Error: Un campo esta vacio");
            }

        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nom_usuario.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            txt_nom_usuario.Enabled = true;
            txt_contraseña.Text = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña.Enabled = true;
            combo_estacion.Text = dataGridViewUsuarios.CurrentRow.Cells[5].Value.ToString();
            combo_estacion.Enabled = true;
            txt_combustible.Text = dataGridViewUsuarios.CurrentRow.Cells[6].Value.ToString();
        }

        private void combo_estacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
