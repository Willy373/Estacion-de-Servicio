using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

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
            dataGridViewClientes.DataSource = logSQL.consultaClientes();
            lbl_combustible.Text = logSQL.consultaCombustible(lbl_usuario.Text);
            lbl_num_servicio.Text = logSQL.consultaNumeroPunto(lbl_usuario.Text);
            lbl_combus_disponible.Text = logSQL.consultaCombusDisponible(lbl_usuario.Text);
            lbl_limite_combus.Text = logSQL.consultaCombusLimite(lbl_usuario.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tanque_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ci_cliente.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            txt_nombre_cliente.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
            txt_ap_paterno.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
            txt_ap_materno.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();
            txt_placa.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            lbl_placa.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_placa.Text != "")
                {
                    dataGridViewClientes.DataSource = logSQL.consultaBuscarCliente(txt_placa.Text);
                }
                else
                {
                    MessageBox.Show("Error: Introducio una Placa inexistente");
                }
            }
            catch
            {
                MessageBox.Show("Error: Introducio un valor equivocado");
            }
        }

        private void btn_venderFull_Click(object sender, EventArgs e)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            double litros =0;
            litros = 2.0 + (random.NextDouble() * 48.0);
            litros = Math.Round(litros, 2);
            Double bolivianos = Convert.ToDouble(logSQL.consultaValorCombustible(lbl_usuario.Text));
            Double valor_bs = Math.Round(litros * bolivianos, 2);

            txt_bs.Text = valor_bs.ToString();

            if (double.Parse(txt_litros.Text) <= double.Parse(lbl_combus_disponible.Text))
            {
                string id_usuario = logSQL.consultaIdUsuario(lbl_usuario.Text);
                string id_cliente = logSQL.consultaIdCliente(txt_placa.Text);

                double limite_combustible = double.Parse(lbl_combus_disponible.Text) - litros;
                logSQL.consultaActCombustible(limite_combustible, int.Parse(lbl_num_servicio.Text));
                try { 
                    logSQL.consultaInsertarHistorial(int.Parse(id_usuario), int.Parse(id_cliente), int.Parse(lbl_num_servicio.Text), litros , valor_bs);
                    MessageBox.Show("Venta de Combustible Registrada");
                    lbl_combus_disponible.Text = limite_combustible.ToString();
                    lbl_litrosDescargados.Text = litros.ToString();
                }catch
                {
                    MessageBox.Show("Error: No selecciono un cliente");
                }
            }
            else
            {
                MessageBox.Show("Error: La Maquina Expendedora No Cuenta Con el Combustible Requerido");
            }

        }

        private void txt_bs_TextChanged(object sender, EventArgs e)
        {
            if (txt_bs.Text != "")
            {
                try
                {
                    Double bolivianos = Convert.ToDouble(logSQL.consultaValorCombustible(lbl_usuario.Text));
                    Double valor_bs = Double.Parse(txt_bs.Text);
                    Double valor_litros = Math.Round(valor_bs / bolivianos, 2);
                    txt_litros.Text = valor_litros.ToString();
                }
                catch
                {
                    MessageBox.Show("Error: Valor Mal introducido");
                }
            }
        }

        private void txt_litros_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_litros.Text) > 0)
                {
                    double bolivianos = double.Parse(logSQL.consultaValorCombustible(lbl_usuario.Text));
                    double valor_litros = double.Parse(txt_litros.Text);
                    double valor_bs = Math.Round(valor_litros * bolivianos, 2);
                    txt_bs.Text = valor_bs.ToString();


                    if (decimal.Parse(txt_litros.Text) <= decimal.Parse(lbl_combus_disponible.Text))
                    {
                        string id_usuario = logSQL.consultaIdUsuario(lbl_usuario.Text);
                        string id_cliente = logSQL.consultaIdCliente(txt_placa.Text);

                        double limite_combustible = double.Parse(lbl_combus_disponible.Text) - double.Parse(txt_litros.Text);
                        logSQL.consultaActCombustible(limite_combustible, int.Parse(lbl_num_servicio.Text));
                        try { 
                            logSQL.consultaInsertarHistorial(int.Parse(id_usuario), int.Parse(id_cliente), int.Parse(lbl_num_servicio.Text), double.Parse(txt_litros.Text), valor_bs);
                            MessageBox.Show("Venta de Combustible Registrada");
                            lbl_combus_disponible.Text = limite_combustible.ToString();
                            lbl_litrosDescargados.Text = txt_litros.Text;
                        }
                        catch
                        {
                            MessageBox.Show("Error: No selecciono un cliente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: La Maquina Expendedora No Cuenta Con el Combustible Requerido");
                    }



                }
            }
            catch
            {
                MessageBox.Show("Error: Valor Mal introducido");
            }
        
        }

        private void btn_recibo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numNit = rnd.Next(900000, 1000200 + 1);
            int numRecibo = rnd.Next(2, 100 + 1);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            Double bolivianos = Convert.ToDouble(logSQL.consultaValorCombustible(lbl_usuario.Text));
            string PaginaHTML_Texto = Properties.Resources.PlantillaRecibo.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", lbl_usuario.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@HORA", DateTime.Now.ToString(" hh:mm"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CI", txt_ci_cliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txt_nombre_cliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PLACA", lbl_placa.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PUNTO", lbl_num_servicio.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USUARIO", lbl_usuario.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DETALLE", lbl_combustible.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NIT", numNit.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@RECIBO", numRecibo.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@UNIT", bolivianos.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CANTIDAD", txt_litros.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", txt_bs.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", txt_bs.Text);
            string num = toText(double.Parse(txt_bs.Text));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VALOR", num);




            string filas = string.Empty;


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A5, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.servicio, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin + 20, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image qr = iTextSharp.text.Image.GetInstance(Properties.Resources.qr, System.Drawing.Imaging.ImageFormat.Png);
                    qr.ScaleToFit(90, 90);
                    qr.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    qr.SetAbsolutePosition(pdfDoc.LeftMargin + 140, pdfDoc.Top - 530);
                    pdfDoc.Add(qr);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();

                }

            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_llenar_tanque_Click(object sender, EventArgs e)
        {
            logSQL.consultaLLenarCombustible(double.Parse(lbl_limite_combus.Text), int.Parse(lbl_num_servicio.Text));
            MessageBox.Show("La Maquina Expendedora esta actualizada en el nivel de combustible maximo ");
            lbl_combus_disponible.Text = lbl_limite_combus.Text;
        }
    }
}
