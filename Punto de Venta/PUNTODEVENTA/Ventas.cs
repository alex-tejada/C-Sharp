using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace PUNTODEVENTA
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            llenarCB();
            leerArchivo();
            ajustarFecha();
            
        }
        
        string dir = @"C:\\PuntoVenta\\";
        string nom = "NumeroDeVenta.txt";
        string linea = null;
        int NumeroDeVentaActual;
        string Producto = "";
        int Cantidad = 0;
        int CantidadActual = 0;

        FileStream flujo_archivo;
        StreamReader sr;
        StreamWriter sw;
        public Coneccion cn = new Coneccion();

        List<string> lista;

        List<int> cantidadProducto = new List<int>();
        List<double> totalPrecios = new List<double>();
        List<string> Productos = new List<string>();
        List<string> PrecioUnitario = new List<string>();
        List<int> CantidadAct = new List<int>();

        public void ajustarFecha()
        {
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void CancelarVenta()
        {
            if (CantidadAct.Count > 0)
            {
                try
                {

                    cn.Abrir();
                    for (int i = 0; i < CantidadAct.Count; i++)
                    {
                        string query = "UPDATE inventario SET cantidad=" + (CantidadAct[i] + cantidadProducto[i]-1) + " WHERE producto='" + Productos[i] + "'";
                        cn.Mov(query);
                    }
                    cn.Cerrar();

                    Productos = null;
                    totalPrecios = null;
                    cantidadProducto = null;
                    PrecioUnitario = null;
                    CantidadAct = null;

                    Productos = new List<string>();
                    totalPrecios = new List<double>();
                    cantidadProducto = new List<int>();
                    PrecioUnitario = new List<string>();
                    CantidadAct = new List<int>();

                    dtgVenta.Rows.Clear();
                    dtgVenta.Refresh();
                    lblTotal.Text = "00.00";

                    MessageBox.Show("Ventas canceladas");
                }
                catch (Exception x)
                {
                    cn.Cerrar();
                    MessageBox.Show("Error: " + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay ventas agregadas");
            }
        }

        public void llenarPrecio()
        {
            if (cmbProducto.SelectedIndex >= 0)
            {
                
                string query = "SELECT precio FROM inventario WHERE producto='" + cmbProducto.SelectedItem.ToString() + "'";
                try
                {
                    cn.Abrir();
                    cn.Consulta(query);

                    if (cn.dr.HasRows)
                    {
                        while (cn.dr.Read())
                        {
                            lblPrecioUnitario.Text = Convert.ToString(cn.dr.GetFloat(0));
                        }
                    }

                    cn.dr.Close();
                    cn.Cerrar();
                }
                catch (Exception x)
                {
                    cn.Cerrar();
                    MessageBox.Show("Error: " + x.ToString());
                }
            }
        }
        public void llenarCB()
        {
            
            string query = "SELECT producto, cantidad FROM inventario";
            try
            {
                cn.Abrir();
                cn.Consulta(query);

                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        if (cn.dr.GetInt32(1) > 0)
                        {
                            cmbProducto.Items.Add(cn.dr.GetString(0));

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Sin elementos");
                }
                cn.dr.Close();
                cn.Cerrar();
            }
            catch (Exception x)
            {
                cn.Cerrar();
                MessageBox.Show("Error: " + x.ToString());
            }

        }
        public void leerArchivo()
        {

            if (File.Exists(dir + nom))
            {
                using (flujo_archivo = new FileStream(dir + nom, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (sr = new StreamReader(flujo_archivo))
                    {
                        lista = null;
                        lista = new List<string>();

                        while (true)
                        {
                            linea = sr.ReadLine();
                            if (linea != null)
                            {
                                lista.Add(linea);
                            }
                            else
                            {
                                break;
                            }

                        }
                        if (lista.Count > 0)
                        {
                            NumeroDeVentaActual = Convert.ToInt32(lista[0]);
                            txtNumVenta.Text = (Convert.ToString(NumeroDeVentaActual));
                        }
                        else
                        {
                            lista = null;
                        }

                    }
                }
                sr.Close();
                flujo_archivo.Close();
                sr = null;
                flujo_archivo = null;
            }
            else
            {
                crearContacto();
            }


        }
        public void crearContacto()
        {

            if (File.Exists(dir + nom))
            {

                using (flujo_archivo = new FileStream(dir + nom, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (sw = new StreamWriter(flujo_archivo))
                    {
                        NumeroDeVentaActual = NumeroDeVentaActual + 1;
                        sw.WriteLine(Convert.ToString(NumeroDeVentaActual));
                        txtNumVenta.Text = (Convert.ToString(NumeroDeVentaActual));
                    }
                }
            }
            else
            {
                using (flujo_archivo = new FileStream(dir + nom, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (sw = new StreamWriter(flujo_archivo))
                    {
                        NumeroDeVentaActual = 1;
                        sw.WriteLine(Convert.ToString(NumeroDeVentaActual));
                        txtNumVenta.Text = (Convert.ToString(NumeroDeVentaActual));
                    }

                }

            }
            sw.Close();
            flujo_archivo.Close();
            sw = null;
            flujo_archivo = null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarPrecio();
        }

        public void actualizarCantidadProducto()
        {
            string query = "UPDATE inventario SET cantidad=" + (CantidadActual - Cantidad) + " WHERE producto='" + Producto + "'";
            try
            {
                cn.Abrir();
                cn.Mov(query);
                cn.Cerrar();

                CantidadActual = 0;
                Cantidad = 0;
                Producto = "";

                MessageBox.Show("Agregado");
            }
            catch (Exception x)
            {
                CantidadActual = 0;
                Cantidad = 0;
                Producto = "";
                cn.Cerrar();
                MessageBox.Show("Error: " + x.ToString());
            }
        }


        public void agregarFila()
        {
            string query = "SELECT producto,precio,cantidad FROM inventario WHERE producto='" + cmbProducto.SelectedItem + "'";
            try
            {
                DataGridViewRow row;
                cn.Abrir();
                cn.Consulta(query);
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        if (Convert.ToInt32(txtCantidadProductos.Text) > cn.dr.GetInt32(2))
                        {
                            MessageBox.Show("No se pueden agregar mas productos\n Cantidad actual: [ " + Convert.ToString(cn.dr.GetInt32(2)) + " ]");
                        }
                        else
                        {
                            row = (DataGridViewRow)dtgVenta.Rows[0].Clone();
                            row.Cells[0].Value = cn.dr.GetString(0);
                            row.Cells[2].Value = Convert.ToString(cn.dr.GetFloat(1));
                            row.Cells[1].Value = txtCantidadProductos.Text;
                            row.Cells[3].Value = Convert.ToString(Convert.ToDouble(txtCantidadProductos.Text) * cn.dr.GetFloat(1));
                            dtgVenta.Rows.Add(row);

                            totalPrecios.Add(Convert.ToDouble(txtCantidadProductos.Text) * cn.dr.GetFloat(1));

                            cantidadProducto.Add(Convert.ToInt32(txtCantidadProductos.Text));
                            Productos.Add(cn.dr.GetString(0));
                            PrecioUnitario.Add(Convert.ToString(cn.dr.GetFloat(1)));
                            CantidadAct.Add(cn.dr.GetInt32(2));

                            Cantidad = Convert.ToInt32(txtCantidadProductos.Text);
                            Producto = cn.dr.GetString(0);
                            CantidadActual = cn.dr.GetInt32(2);

                            double total = 0;

                            for (int i = 0; i < totalPrecios.Count; i++)
                            {
                                total += totalPrecios[i];
                            }

                            lblTotal.Text = Convert.ToString(total);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                cn.dr.Close();
                cn.Cerrar();

            }
            catch (Exception x)
            {
                cn.Cerrar();
                MessageBox.Show("Error: " + x.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCantidadProductos.Text != "")
            {
                if (cmbProducto.SelectedIndex >= 0)
                {
                    agregarFila();

                    if (Cantidad != 0 && CantidadActual != 0 && Producto != "")
                    {
                        actualizarCantidadProducto();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto");
                }
            }
            else
            {
                MessageBox.Show("Capture el numero de productos");
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (Productos.Count > 0)
            {
                try
                {
                    DateTime date = DateTime.Now;

                    int numeroVenta = Convert.ToInt32(txtNumVenta.Text);
                    string vendedor = lblVendedor.Text;
                    string fecha = DateTime.Now.ToString("yyyyMMdd");

                    cn.Abrir();
                    for (int i = 0; i < Productos.Count; i++)
                    {
                        string query = "INSERT INTO venta (numventa,cantidad,producto,precioU,Subtotal,vendedor,fecha) VALUES(" + numeroVenta + "," + cantidadProducto[i] + ",'" + Productos[i] + "','" + PrecioUnitario[i] + "'," + totalPrecios[i] + ",'" + vendedor + "','" + fecha + "')";
                        cn.Mov(query);
                    }
                    cn.Cerrar();

                    Productos = null;
                    totalPrecios = null;
                    cantidadProducto = null;
                    PrecioUnitario = null;
                    CantidadAct = null;

                    Productos = new List<string>();
                    totalPrecios = new List<double>();
                    cantidadProducto = new List<int>();
                    PrecioUnitario = new List<string>();
                    CantidadAct = new List<int>();

                    dtgVenta.Rows.Clear();
                    dtgVenta.Refresh();

                    cmbProducto.Items.Clear();
                    llenarCB();
                    cmbProducto.ResetText();
                    lblPrecioUnitario.Text = "";
                    txtCantidadProductos.Text = "";
                    lblTotal.Text = "00.00";

                    MessageBox.Show("Venta entregada!");
                }
                catch (Exception x)
                {
                    cn.Cerrar();
                    MessageBox.Show("Error: " + x.ToString());
                }
                crearContacto();
            }
            else
            {
                MessageBox.Show("Agregue ventas al registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarVenta();
        }

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
    }
}
