using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        LogicaSQL logSQL = new LogicaSQL();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.PlantillaVentas.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", combo_vendedor.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewVentas.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["nombre_usuario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["combustible_servicio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["costo_combustible"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad_combustible"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["total_bolivianos"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["total_bolivianos"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.LETTER, 25, 25, 25, 25);

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
            dataGridViewVentas.DataSource = logSQL.consultaVenta_Forma_Gral();
            combo_vendedor.SelectedIndex = 0;
        }

        private void combo_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combo_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataGridViewVentas.DataSource = logSQL.consultaVentaEspecifica(combo_vendedor.Text, combo_mes.Text);

        }
    }
}
