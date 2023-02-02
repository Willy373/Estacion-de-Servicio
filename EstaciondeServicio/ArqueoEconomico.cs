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


using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

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
            dataGridViewArqueo.RowHeadersVisible = false;
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

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", lbl_usuario.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PUNTO", lbl_num_servicio.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewArqueo.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["nombre_usuario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["combustible_servicio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["fecha_venta"].Value.ToString() + "</td>";
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
                    img.SetAbsolutePosition(pdfDoc.LeftMargin +20, pdfDoc.Top - 60);
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
    }
}
