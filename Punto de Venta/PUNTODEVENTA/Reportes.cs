using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text.xml;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System.IO;


namespace PUNTODEVENTA
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        Coneccion cn = new Coneccion();
        MySqlDataAdapter da;
        DataSet ds;
        Boolean busqueda = false;
        Boolean listoGenerar = false;

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            mn.lblUser.Text = lblUser.Text;
            mn.lblUsertype.Text = lblUsertype.Text;
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdFecha_CheckedChanged(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            pnlFecha.Enabled = true;
            txtAnio.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
        }

        private void rdVenta_CheckedChanged(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pnlFecha.Enabled = false;
            lblBuscarDato.Text = "Ingrese el Numero de Venta";
            txtBuscar.Text = "";
        }

        private void rdProducto_CheckedChanged(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pnlFecha.Enabled = false;
            lblBuscarDato.Text = "Ingresar nombre del Producto";
            txtBuscar.Text = "";
        }

        private void rdVendedor_CheckedChanged(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pnlFecha.Enabled = false;
            lblBuscarDato.Text = "Ingresar nombre del Vendedor";
            txtBuscar.Text = "";
        }

        public void BuscarporFecha()
        {
            string nombreVendedor = "";
            string fecha = "";
            string totalVenta = "";
            string numventa = "";

            StringBuilder builder;
            string mes;
            string dia;

            if (txtAnio.Text != "" && txtDia.Text != "" && txtMes.Text != "")
            {
                mes = txtMes.Text;
                dia = txtDia.Text;

                if (txtDia.TextLength == 1)
                {
                    builder = new StringBuilder();
                    builder.Append('0').Append(txtDia.Text);
                    dia = builder.ToString();
                }
                if (txtMes.TextLength == 1)
                {
                    builder = new StringBuilder();
                    builder.Append('0').Append(txtMes.Text);
                    mes = builder.ToString();
                }
                try
                {
                    string query = "SELECT numventa, producto, cantidad, precioU, Subtotal, vendedor, fecha, SUM(Subtotal)  FROM venta WHERE fecha='" + txtAnio.Text + "-" + mes + "-" + dia + "'";
                    cn.Abrir();
                    cn.Consulta(query);

                    if (cn.dr.HasRows)
                    {
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();

                        while (cn.dr.Read())
                        {
                            if (!nombreVendedor.Contains(cn.dr.GetString(5)))
                            {
                                if (nombreVendedor == "")
                                {
                                    nombreVendedor = cn.dr.GetString(5);
                                }
                                else
                                {
                                    nombreVendedor = nombreVendedor + " | " + cn.dr.GetString(5);
                                }
                                
                            }
                            
                            if (!numventa.Contains(cn.dr.GetInt32(0).ToString()))
                            {
                                if (numventa == "")
                                {
                                    numventa = cn.dr.GetInt32(0).ToString();
                                }
                                else
                                {
                                    numventa = numventa + " | " + cn.dr.GetInt32(0).ToString();
                                }
                            }
                            

                            
                            fecha = cn.dr.GetString(6);
                            totalVenta = Convert.ToString(cn.dr.GetFloat(7));

                        }

                        pnlResultados.Visible = true;
                        busqueda = true;
                        lblResultados.Visible = false;
                    }
                    else
                    {
                        busqueda = false;
                        pnlResultados.Visible = false;
                        listoGenerar = false;
                        lblResultados.Visible = true;
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();
                    }
                    cn.Cerrar();
                    cn.Abrir();
                    if (busqueda == true)
                    {
                        query = "SELECT producto, cantidad, precioU, Subtotal, numventa, vendedor  FROM venta WHERE fecha='" + txtAnio.Text + "-" + txtMes.Text + "-" + txtDia.Text + "'";
                        da = new MySqlDataAdapter(query, cn.con);
                        ds = new DataSet();
                        da.Fill(ds, "venta");
                        dgvReporte.DataSource = ds.Tables["venta"];

                        dgvReporte.Columns[0].HeaderText = "Producto";
                        dgvReporte.Columns[1].HeaderText = "Cantidad Vendida";
                        dgvReporte.Columns[2].HeaderText = "Precio Unitario";
                        dgvReporte.Columns[3].HeaderText = "Subtotal";
                        dgvReporte.Columns[4].HeaderText = "Numero de Venta";
                        dgvReporte.Columns[5].HeaderText = "Nombre de Vendedor";

                        dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvReporte.MultiSelect = false;
                        busqueda = false;
                        listoGenerar = true;
                    }
                    cn.Cerrar();

                    lblVendedor.Text = nombreVendedor;
                    lblFecha.Text = fecha;
                    lblTotal.Text = "$" + totalVenta;
                    lblNumeroVenta.Text = numventa;


                }
                catch (Exception x)
                {
                    dgvReporte.DataSource = null;
                    dgvReporte.Rows.Clear();
                    dgvReporte.Refresh();
                    cn.Cerrar();
                    busqueda = false;
                    pnlResultados.Visible = false;
                    listoGenerar = false;
                    lblResultados.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Capture la fecha: Dia/Mes/Año");
            }
        }

        public void BuscarporVenta()
        {

            string nombreVendedor = "";
            string fecha = "";
            string totalVenta = "";
            string numventa = "";

            if (txtBuscar.Text != "")
            {
                try
                {
                    string query = "SELECT vendedor, fecha, SUM(Subtotal) FROM venta WHERE numventa=" + Convert.ToInt32(txtBuscar.Text);
                    cn.Abrir();
                    cn.Consulta(query);

                    if (cn.dr.HasRows)
                    {
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();

                        while (cn.dr.Read())
                        {

                            fecha = cn.dr.GetString(1);
                            numventa = txtBuscar.Text;
                            totalVenta = Convert.ToString(cn.dr.GetFloat(2));
                            nombreVendedor = cn.dr.GetString(0);
                        }
                        pnlResultados.Visible = true;
                        busqueda = true;
                        lblResultados.Visible = false;
                    }
                    else
                    {
                        busqueda = false;
                        pnlResultados.Visible = false;
                        listoGenerar = false;
                        lblResultados.Visible = true;
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();
                    }
                    cn.Cerrar();
                    cn.Abrir();
                    if (busqueda == true)
                    {
                        query = "SELECT producto, cantidad, precioU, Subtotal  FROM venta WHERE numventa=" + Convert.ToInt32(txtBuscar.Text);
                        da = new MySqlDataAdapter(query, cn.con);
                        ds = new DataSet();
                        da.Fill(ds, "venta");
                        dgvReporte.DataSource = ds.Tables["venta"];

                        dgvReporte.Columns[0].HeaderText = "Producto";
                        dgvReporte.Columns[1].HeaderText = "Cantidad Vendida";
                        dgvReporte.Columns[2].HeaderText = "Precio Unitario";
                        dgvReporte.Columns[3].HeaderText = "Subtotal";

                        dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvReporte.MultiSelect = false;
                        busqueda = false;
                        listoGenerar = true;
                    }
                    cn.Cerrar();

                    lblVendedor.Text = nombreVendedor;
                    lblFecha.Text = fecha;
                    lblTotal.Text = "$" + totalVenta;
                    lblNumeroVenta.Text = numventa;


                }
                catch (Exception x)
                {
                    dgvReporte.DataSource = null;
                    dgvReporte.Rows.Clear();
                    dgvReporte.Refresh();
                    cn.Cerrar();
                    busqueda = false;
                    pnlResultados.Visible = false;
                    listoGenerar = false;
                    lblResultados.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el numero de venta");
            }
        }
        public void BuscarPorProducto()
        {

            string nombreVendedor = "";
            string fecha = "";
            string totalVenta = "";
            string numventa = "";

            if (txtBuscar.Text != "")
            {
                string query = "SELECT vendedor, fecha, SUM(Subtotal), numventa FROM venta WHERE producto='" + txtBuscar.Text + "'";
                try
                {
                    cn.Abrir();
                    cn.Consulta(query);

                    if (cn.dr.HasRows)
                    {
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();

                        while (cn.dr.Read())
                        {
                            if (nombreVendedor != cn.dr.GetString(0))
                            {
                                if (nombreVendedor == "")
                                {
                                    nombreVendedor = cn.dr.GetString(0);
                                }
                                else
                                {
                                    nombreVendedor += ", " + cn.dr.GetString(0);
                                }
                            }
                            if (fecha != cn.dr.GetString(1))
                            {
                                if (fecha == "")
                                {
                                    fecha = cn.dr.GetString(1);
                                }
                                else
                                {
                                    fecha += ", " + cn.dr.GetString(1); ;
                                }
                            }
                            if (numventa != Convert.ToString(cn.dr.GetString(3)))
                            {
                                if (numventa == "")
                                {
                                    numventa = Convert.ToString(cn.dr.GetString(3));
                                }
                                else
                                {
                                    numventa += ", " + Convert.ToString(cn.dr.GetString(3));
                                }
                            }
                            totalVenta = Convert.ToString(cn.dr.GetFloat(2));

                        }
                        pnlResultados.Visible = true;
                        busqueda = true;
                        lblResultados.Visible = false;
                    }
                    else
                    {
                        busqueda = false;
                        pnlResultados.Visible = false;
                        listoGenerar = false;
                        lblResultados.Visible = true;
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();
                    }
                    cn.Cerrar();
                    cn.Abrir();
                    if (busqueda == true)
                    {
                        query = "SELECT producto, cantidad, precioU, Subtotal, fecha, numventa, vendedor  FROM venta WHERE producto='" + txtBuscar.Text + "'";
                        da = new MySqlDataAdapter(query, cn.con);
                        ds = new DataSet();
                        da.Fill(ds, "venta");
                        dgvReporte.DataSource = ds.Tables["venta"];

                        dgvReporte.Columns[0].HeaderText = "Producto";
                        dgvReporte.Columns[1].HeaderText = "Cantidad Vendida";
                        dgvReporte.Columns[2].HeaderText = "Precio Unitario";
                        dgvReporte.Columns[3].HeaderText = "Subtotal";
                        dgvReporte.Columns[4].HeaderText = "fecha";
                        dgvReporte.Columns[5].HeaderText = "Numero de Venta";
                        dgvReporte.Columns[6].HeaderText = "Vendedor";

                        dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvReporte.MultiSelect = false;
                        busqueda = false;
                        listoGenerar = true;
                    }
                    cn.Cerrar();

                    lblVendedor.Text = nombreVendedor;
                    lblFecha.Text = fecha;
                    lblTotal.Text = "$" + totalVenta;
                    lblNumeroVenta.Text = numventa;


                }
                catch (Exception x)
                {
                    dgvReporte.DataSource = null;
                    dgvReporte.Rows.Clear();
                    dgvReporte.Refresh();
                    cn.Cerrar();
                    busqueda = false;
                    pnlResultados.Visible = false;
                    listoGenerar = false;
                    lblResultados.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del producto");
            }
        }

        public void BuscarPorVendedor()
        {
            string nombreVendedor = "";
            string fecha = "";
            string totalVenta = "";
            string numventa = "";

            if (txtBuscar.Text != "")
            {
                string query = "SELECT numventa, fecha, SUM(Subtotal), numventa FROM venta WHERE vendedor='" + txtBuscar.Text + "'";
                try
                {
                    cn.Abrir();
                    cn.Consulta(query);

                    if (cn.dr.HasRows)
                    {
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();

                        while (cn.dr.Read())
                        {
                            if (numventa != Convert.ToString(cn.dr.GetString(0)))
                            {
                                if (numventa == "")
                                {
                                    numventa = Convert.ToString(cn.dr.GetString(0));
                                }
                                else
                                {
                                    numventa += ", " + Convert.ToString(cn.dr.GetString(0));
                                }
                            }
                            if (fecha != cn.dr.GetString(1))
                            {
                                if (fecha == "")
                                {
                                    fecha = cn.dr.GetString(1);
                                }
                                else
                                {
                                    fecha += ", " + cn.dr.GetString(1); ;
                                }
                            }
                            totalVenta = Convert.ToString(cn.dr.GetFloat(2));
                            nombreVendedor = txtBuscar.Text;
                        }
                        pnlResultados.Visible = true;
                        busqueda = true;
                        lblResultados.Visible = false;
                    }
                    else
                    {
                        busqueda = false;
                        pnlResultados.Visible = false;
                        listoGenerar = false;
                        lblResultados.Visible = true;
                        dgvReporte.DataSource = null;
                        dgvReporte.Rows.Clear();
                        dgvReporte.Refresh();
                    }
                    cn.Cerrar();
                    cn.Abrir();
                    if (busqueda == true)
                    {
                        query = "SELECT producto, cantidad, precioU, Subtotal, fecha, numventa  FROM venta WHERE vendedor='" + txtBuscar.Text + "'";
                        da = new MySqlDataAdapter(query, cn.con);
                        ds = new DataSet();
                        da.Fill(ds, "venta");
                        dgvReporte.DataSource = ds.Tables["venta"];

                        dgvReporte.Columns[0].HeaderText = "Producto";
                        dgvReporte.Columns[1].HeaderText = "Cantidad Vendida";
                        dgvReporte.Columns[2].HeaderText = "Precio Unitario";
                        dgvReporte.Columns[3].HeaderText = "Subtotal";
                        dgvReporte.Columns[4].HeaderText = "fecha";
                        dgvReporte.Columns[5].HeaderText = "Numero de venta";

                        dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvReporte.MultiSelect = false;
                        busqueda = false;
                        listoGenerar = true;
                    }
                    cn.Cerrar();

                    lblVendedor.Text = nombreVendedor;
                    lblFecha.Text = fecha;
                    lblTotal.Text = "$" + totalVenta;
                    lblNumeroVenta.Text = numventa;


                }
                catch (Exception x)
                {
                    dgvReporte.DataSource = null;
                    dgvReporte.Rows.Clear();
                    dgvReporte.Refresh();
                    cn.Cerrar();
                    busqueda = false;
                    pnlResultados.Visible = false;
                    listoGenerar = false;
                    lblResultados.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del vendedor");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdFecha.Checked == true)
            {
                BuscarporFecha();
            }
            else if (rdVenta.Checked == true)
            {
                BuscarporVenta();
            }
            else if (rdProducto.Checked == true)
            {
                BuscarPorProducto();
            }
            else if (rdVendedor.Checked == true)
            {
                BuscarPorVendedor();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (listoGenerar == true)
            {
                string Titulo = "Reporte de Ventas";
                string Texto1 = "Numero de Venta(s): " + lblNumeroVenta.Text;
                string Texto2 = "Nombre de Vendedor(es): " + lblVendedor.Text;
                string Texto3 = "Fecha de Venta(s): " + lblFecha.Text;
                string Texto4 = "Total de venta: " + lblTotal.Text;

                string nombreArchivo = @"C:\\PuntoVenta\\Reporte.pdf";


                Document doc = new Document(PageSize.LETTER, 30, 30, 20, 20);

                Chunk linebreak = new Chunk("\n", FontFactory.GetFont("ARIAL", "10"));

                Paragraph tp = new Paragraph(Titulo, FontFactory.GetFont("TAHOMA", 19, iTextSharp.text.Font.BOLD));
                tp.Alignment = Element.ALIGN_CENTER;

                string url = @"C:\\PuntoVenta\\logo.png";
                try
                {
                    FileStream arch = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, arch);

                    doc.Open();

                    /*iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(new Uri(url));
                    doc.Add(jpg);*/

                    doc.Add(tp);
                    doc.Add(linebreak);
                    doc.Add(linebreak);

                    doc.Add(new Paragraph(Texto1, FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL)));
                    doc.Add(new Paragraph(Texto2, FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL)));
                    doc.Add(new Paragraph(Texto3, FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL)));
                    doc.Add(new Paragraph(Texto4, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph(".....................................................................", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLDITALIC)));
                    doc.Add(linebreak);

                    GenerarDocumento(doc);

                    Process.Start(nombreArchivo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                doc.Close();
            }
            else
            {
                MessageBox.Show("Sin busquedas");
            }
        }

        public void GenerarDocumento(Document docu)
        {
            PdfPTable tabla = new PdfPTable(dgvReporte.ColumnCount);
            tabla.DefaultCell.Padding = 3;
            float[] header = GetTamañoColumnas(dgvReporte);
            tabla.SetWidths(header);
            tabla.WidthPercentage = 100;
            tabla.DefaultCell.BorderWidth = 1;
            tabla.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            for (int i = 0; i < dgvReporte.ColumnCount; i++)
            {
                tabla.AddCell(dgvReporte.Columns[i].HeaderText);
            }

            tabla.HeaderRows = 0;
            tabla.DefaultCell.BorderWidth = 1;

            for (int y = 0; y < dgvReporte.RowCount - 1; y++)
            {
                for (int x = 0; x < dgvReporte.Columns.Count; x++)
                {
                    tabla.AddCell(dgvReporte[x, y].Value.ToString());
                }
                tabla.CompleteRow();
            }
            docu.Add(tabla);


        }
        public float[] GetTamañoColumnas(DataGridView dgv)
        {
            float[] valores = new float[dgv.ColumnCount];

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                valores[i] = (float)dgv.Columns[i].Width;
            }

            return valores;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
