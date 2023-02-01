﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            timerMenuPrincipal.Enabled = true;
        }

        private void timerMenuPrincipal_Tick(object sender, EventArgs e)
        {
            lbl_fechor_actual.Text = DateTime.Now.ToString();
        }

        private void btn_punto_venta_Click(object sender, EventArgs e)
        {
            PuntodeVenta punto = new PuntodeVenta();
            AddOwnedForm(punto);
            punto.lbl_usuario.Text = this.lbl_usuario.Text;
            punto.Show();
            this.Hide();
        }

        private void pbox_cita_Click(object sender, EventArgs e)
        {
            PuntodeVenta punto = new PuntodeVenta();
            AddOwnedForm(punto);
            punto.lbl_usuario.Text = this.lbl_usuario.Text;
            punto.Show();
            this.Hide();
        }
    }
}
