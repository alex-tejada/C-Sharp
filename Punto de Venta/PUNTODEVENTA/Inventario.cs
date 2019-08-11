using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PUNTODEVENTA
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            ActualizarInventario();
        }

        Coneccion cn = new Coneccion();
        MySqlDataAdapter da;
        DataSet ds;

        public void ActualizarInventario()
        {
            try
            {
                cn.Abrir();
                string query = "SELECT id,producto,precio,cantidad FROM inventario";
                da = new MySqlDataAdapter(query, cn.con);
                ds = new DataSet();
                da.Fill(ds, "inventario");
                dtgInventario.DataSource = ds.Tables["inventario"];
                cn.Cerrar();
                dtgInventario.Columns[0].HeaderText = "ID";
                dtgInventario.Columns[1].HeaderText = "Producto";
                dtgInventario.Columns[2].HeaderText = "Precio";
                dtgInventario.Columns[3].HeaderText = "Cantidad";
                dtgInventario.Columns[0].ReadOnly = true;
                dtgInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgInventario.MultiSelect = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
            }
        }

        private void dtgInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarInventario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAgregar.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAgregarProducto.Text != "" && txtAgregarCantidad.Text != "" && txtAgregarPrecio.Text != "")
            {
                try
                {
                    int cantidad = Convert.ToInt32(txtAgregarCantidad.Text);
                    string producto = txtAgregarProducto.Text;
                    double precio = Convert.ToDouble(txtAgregarPrecio.Text);

                    if (cantidad < 0)
                    {
                        cantidad = 0;
                    }
                    string query = "INSERT INTO inventario(producto,precio,cantidad) VALUES('" + producto + "'," + precio + "," + cantidad + ")";

                    cn.Abrir();
                    cn.Mov(query);
                    cn.Cerrar();

                    MessageBox.Show("¡Producto agregado!");
                    txtAgregarProducto.Text = "";
                    txtAgregarCantidad.Text = "";
                    txtAgregarPrecio.Text = "";
                    ActualizarInventario();

                }
                catch (Exception x)
                {
                    cn.Cerrar();
                    MessageBox.Show("Error: " + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Capture todos los campos");
            }
        }
        

        private void dtgInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgInventario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgInventario_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        private void dtgInventario_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dtgInventario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgInventario.Rows[e.RowIndex];

                if (row.Cells[0].Value.ToString() != "")
                {
                    {
                        int indice = Convert.ToInt32(row.Cells[0].Value.ToString());

                        string producto = "";
                        int cantidad = 0;
                        double precio = 00.00;

                        if (row.Cells[1].Value.ToString() != "")
                        {
                            producto = row.Cells[1].Value.ToString();
                        }
                        if (row.Cells[3].Value.ToString() != "")
                        {
                            cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
                        }
                        if (row.Cells[2].Value.ToString() != "")
                        {
                            precio = Convert.ToDouble(row.Cells[2].Value.ToString());
                        }
                        if (cantidad < 0)
                        {
                            cantidad = 0;
                        }
                        string query = "UPDATE inventario SET cantidad=" + cantidad + ", producto='" + producto + "', precio=" + precio + " WHERE id=" + indice;
                        try
                        {
                            cn.Abrir();
                            cn.Mov(query);
                            cn.Cerrar();
                        }
                        catch (Exception x)
                        {

                            cn.Cerrar();
                            MessageBox.Show("Error: " + x.ToString());
                        }
                    }
                }
            }
        }

        private void dtgInventario_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int index = e.RowIndex; index <= e.RowIndex + e.RowCount - 1; index++)
            {
                DataGridViewRow row = dtgInventario.Rows[index];

                string producto = "";
                int cantidad = 0;
                double precio = 00.00;

                if (row.Cells[1].Value.ToString() != "")
                {
                    producto = row.Cells[1].Value.ToString();
                }
                if (row.Cells[3].Value.ToString() != "")
                {
                    cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
                }
                if (row.Cells[2].Value.ToString() != "")
                {
                    precio = Convert.ToDouble(row.Cells[2].Value.ToString());
                }

                if (cantidad < 0)
                {
                    cantidad = 0;
                }
                string query = "INSERT INTO inventario (producto,precio,cantidad) VALUES ('" + producto + "'," + cantidad + "," + precio + ")";
                try
                {
                    cn.Abrir();
                    cn.Mov(query);
                    cn.Cerrar();
                    ActualizarInventario();
                }
                catch (Exception x)
                {

                    cn.Cerrar();
                    MessageBox.Show("Error: " + x.ToString());
                }
            }
        }
    }
    }

