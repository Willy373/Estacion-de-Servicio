using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace EstaciondeServicio
{
    public partial class Login : Form
    {
        LogicaSQL logSQL = new LogicaSQL();
        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(logSQL.consultaLogin(txt_usuario.Text, txt_contrasena.Text) == 1)
            {
                MenuPrincipal menu = new MenuPrincipal();
                AddOwnedForm(menu);
                menu.lbl_usuario.Text = this.txt_usuario.Text;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario no ha sido encontrado");    
            }


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
