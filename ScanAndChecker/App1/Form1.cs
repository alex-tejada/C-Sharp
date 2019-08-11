using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ClosedXML.Excel;

namespace App1
{
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();
        ServerInfo serverInfo = new ServerInfo();
        ServerConfig server = new ServerConfig();
        Ayuda ayuda = new Ayuda();
        
        int colorIndex = 0;
        int countdownSearch = 0;
        bool approvedDate = false;
        string tempID = "";
        Nullable<int> countDown = 1;
        DataTable excelData = null;
        DateTime startingDate, endingDate;
        List<string> employeeAddList = new List<string>();

        List<string> employee = null;
        List<string> idEmployees = null;

        Thread threadTime = null, threadDatabaseRequest = null, threadExcel = null,
            threadSingleDatabaseRequest = null,threadSearchForEmployees = null;

        public Form1()
        {
            InitializeComponent();
            threadTime = new Thread(new ThreadStart(timeChange));
            setExcelFileFromStartup();
            timer1.Start();
        }
        public void clearAllData()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            if (employeeAddList.Count > 0)
            {
                employeeAddList.Clear();
            }
        }

        public void createExcelFile(string path)
        {
            DataTable table = (DataTable)dataGridView1.DataSource;
            var book = new XLWorkbook();
            var sheet = book.Worksheets.Add(table, "Lista de Horas");
            book.SaveAs(path+".xlsx");
        }
        public void deleteEmployeeFromInfo(string name)
        {
            if (employeeAddList.Contains(name) && dataGridView1.DataSource != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (name.Equals(row.Cells["Empleado"].Value))
                    {
                        dataGridView1.Rows.Remove(row);
                        employeeAddList.Remove(name);
                        break;
                    }
                }
            }
        }
        public void addEveryEmployeeInfoToList()
        {
            getEmployees();
            DateTime start = dateTimePicker_startDate.Value;
            DateTime end = dateTimePicker_endDate.Value;
            
            DataTable table = getEmployeeCheckAsist(employee,idEmployees, start,end);
            
            idEmployees = null;
            employeeAddList.Clear();
            employeeAddList = employee;
            employee = null;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
            if (button_earnExcelFile.Enabled == false)
            {
                button_earnExcelFile.Enabled = true;
            }
        }
        public void getEmployees()
        {
            string[] serverData = serverInfo.readJSON();
            employee = new List<string>();
            idEmployees = new List<string>();

            string query = "SELECT DISTINCT name,idEmp FROM checklist";

            conexion.Abrir(serverData[0], serverData[1], serverData[2]);
            conexion.Consulta(query);
            while (conexion.dr.Read())
            {
                employee.Add(conexion.dr.GetString(0));
                idEmployees.Add(conexion.dr.GetString(1));
            }
            conexion.Cerrar();
            
        }
        public void addListedEmployeesToTable(DataTable table)
        {
            DataTable dataGridSource = (DataTable)dataGridView1.DataSource;
            
            foreach (DataRow row in table.Rows)
            {
                dataGridSource.ImportRow(row);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataGridSource;
        }
        public DataTable getEmployeeCheckAsist(List<string> names, List<string> id, DateTime initialDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;
            DataColumn dataColumn;

            DateTime initialDateDT = initialDate;
            DateTime endDateDT = endDate;
            endDateDT = endDateDT.AddDays(1);

            dataColumn = new DataColumn();
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.ColumnName = "Número de Gafete";
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.ColumnName = "Empleado";
            dataTable.Columns.Add(dataColumn);

            while (initialDateDT.CompareTo(endDateDT) != 0)
            {
                dataColumn = new DataColumn();
                dataColumn.DataType = System.Type.GetType("System.String");
                dataColumn.ColumnName = initialDateDT.ToString("dd/MM/yyyy");
                dataTable.Columns.Add(dataColumn);
                initialDateDT = initialDateDT.AddDays(1);
            }
            string[] serverData = serverInfo.readJSON();
            string query = "";

            initialDateDT = initialDate;
            endDateDT = endDate;
            endDateDT = endDateDT.AddDays(1);

            for (int i = 0; i < names.Count; i++)
            {
                dataRow = dataTable.NewRow();
                List<string[]> hourList = new List<string[]>();
                List<string> hoursByDate;
                DateTime firstHour, lastHour;
                string[] hoursData;

                initialDateDT = initialDate;
                endDateDT = endDate;
                endDateDT = endDateDT.AddDays(1);

                while (initialDateDT.CompareTo(endDateDT) != 0)
                {
                    query = "SELECT hour FROM checklist WHERE date='" + initialDateDT.ToString("dd/MM/yyyy") + "' AND name='" + names.ElementAt(i) + "'";

                    hoursByDate = new List<string>();

                    conexion.Abrir(serverData[0], serverData[1], serverData[2]);
                    conexion.Consulta(query);
                    while (conexion.dr.Read())
                    {
                        hoursByDate.Add(conexion.dr.GetString(0));
                    }
                    conexion.Cerrar();

                    hoursData = new string[3];
                    if (hoursByDate.Count >= 2)
                    {
                        firstHour = Convert.ToDateTime(hoursByDate.ElementAt(0));
                        lastHour = Convert.ToDateTime(hoursByDate.ElementAt(hoursByDate.Count - 1));
                        hoursData[0] = firstHour.ToString("hh:mm tt");
                        hoursData[1] = lastHour.ToString("hh:mm tt");
                        hoursData[2] = ((int)lastHour.Subtract(firstHour).TotalHours).ToString();
                        hourList.Add(hoursData);
                    }
                    else
                    {
                        hoursData[0] = "-";
                        hoursData[1] = "-";
                        hoursData[2] = "-";
                        hourList.Add(hoursData);
                    }
                    initialDateDT = initialDateDT.AddDays(1);
                }


                dataRow = dataTable.NewRow();
                initialDateDT = initialDate;
                dataRow["Número de Gafete"] = id.ElementAt(i);
                dataRow["Empleado"] = names.ElementAt(i);
                for (int j = 0; j < hourList.Count; j++)
                {
                    hoursData = hourList.ElementAt(j);
                    dataRow[initialDateDT.ToString("dd/MM/yyyy")] = " Entrada: " + hoursData[0] + "\n Salida: " + hoursData[1] + "\n Horas: " + hoursData[2];
                    initialDateDT = initialDateDT.AddDays(1);
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
        public void addSingleEmployeeInfoToList(string name,string id)
        {
            if (!employeeAddList.Contains(name))
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text = name;
                label.Font = new Font("Arial", 9, FontStyle.Regular);
                label.ForeColor = Color.White;

                DateTime start = dateTimePicker_startDate.Value;
                DateTime end = dateTimePicker_endDate.Value;

                employee = new List<string>();
                idEmployees = new List<string>();
                employee.Add(name);
                idEmployees.Add(id);

                DataTable dataTable = getEmployeeCheckAsist(employee,idEmployees, start, end);

                employee = null;
                idEmployees = null;
                employeeAddList.Add(name);
                if (dataGridView1.DataSource != null)
                {
                    addListedEmployeesToTable(dataTable);
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                }
                if (button_earnExcelFile.Enabled == false)
                {
                    button_earnExcelFile.Enabled = true;
                }
            }
        }
        public void requestEmployees()
        {
            string[] serverData = serverInfo.readJSON();

            string query = "SELECT DISTINCT idEmp AS 'Nro. Gafete',name AS 'Empleado',department AS 'Departamento' FROM checklist ORDER BY idEmp";

            conexion.Abrir(serverData[0], serverData[1], serverData[2]);
            DataTable employeeData = conexion.requestForTable(query);
            conexion.Cerrar();

            dataGridView2.DataSource = employeeData;
        }
        public List<Color> getColors()
        {
            List<Color> colorsList = new List<Color>();
            colorsList.Add(Color.FromArgb(11, 37, 79));
            colorsList.Add(Color.FromArgb(40, 10, 104));
            colorsList.Add(Color.FromArgb(137, 17, 1));
            colorsList.Add(Color.FromArgb(10, 117, 37));
            colorsList.Add(Color.FromArgb(5, 99, 99));
            colorsList.Add(Color.FromArgb(91, 7, 79));

            return colorsList;
        }
        public void addCheckInfo(string name, string hour)
        {
            Panel panel = new Panel();
            Label label = new Label();

            label.Text = "Registro: " + name.ToUpper() + "\nHora: " + hour;
            label.Font = new Font("Arial", 10, FontStyle.Regular);
            label.ForeColor = Color.White;
            panel.Size = new Size(190, 50);

            panel.BackColor = getColors().ElementAt(colorIndex);
            panel.Controls.Add(label);
            label.SetBounds(1, 1, 189, 49);

            flowLayoutPanel1.Controls.Add(panel);

            colorIndex += 1;
            if (colorIndex > 5)
            {
                colorIndex = 0;
            }

            panel.Focus();
            textBox_id.Focus();
        }
        public void setImage(bool flag)
        {
            if (flag)
            {
                pictureBox1.Image = Image.FromFile(@"Models\success.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Models\tache.png");
            }
        }
        public void accessExcelFile(string fileExt, string excelPath)
        {
            string conn = null;

            if (fileExt.CompareTo(".xls") == 0)
            {
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + excelPath + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                excelData = readExcel(conn);
                setMessageExcel(1);
            }
            else if (fileExt.CompareTo(".xlsx") == 0)
            {
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
                excelData = readExcel(conn);
                setMessageExcel(1);
            }
            else
            {
                setMessageExcel(0);
            }
        }

        public void setExcelFile()
        {
            try
            {
                string excelPath = null;
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    excelPath = this.openFileDialog1.FileName.ToString();
                    accessExcelFile(Path.GetExtension(excelPath), excelPath);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }
        public DataTable readExcel(string conn)
        {
            DataTable dtexcel = new DataTable();
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                oleAdpt.Fill(dtexcel);
            }
            return dtexcel;
        }

        public void AsyncProcessExcel()
        {
            this.Invoke((MethodInvoker)delegate
            {
                setExcelFile();
                button_setMaster.Enabled = true;
            });
        }

        public void searhExcel(string id)
        {
            bool found = false;
            if (id.Equals(tempID))
            {

            }
            else
            {
                tempID = id;
                foreach (DataRow row in excelData.Rows)
                {
                    if (id.Equals(row["F1"].ToString()))
                    {
                        string depart = row["F3"].ToString();
                        string name = row["F2"].ToString();

                        if (depart.Contains("'"))
                        {
                            depart = depart.Remove(depart.IndexOf("'"), 1);
                        }

                        employeeDataINSERT(id, name, depart);
                        found = true;
                        addCheckInfo(name, DateTime.Now.ToString("hh:mm"));
                        textBox_id.Focus();
                        break;
                    }
                }
            }
            setImage(found);
        }

        public void employeeDataINSERT(string id, string name, string depart)
        {
            string[] serverData = serverInfo.readJSON();

            string hour = DateTime.Now.ToString("hh:mm tt");
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string query = "INSERT INTO checklist (idEmp,name,department,date,hour) VALUES('" + id + "','" + name + "','" + depart + "','" + date + "','" + hour + "')";
            conexion.Abrir(serverData[0], serverData[1],serverData[2]);
            conexion.Mov(query);
            conexion.Cerrar();
        }

        public string[] detectExcelFiles()
        {
            var files = Directory.EnumerateFiles(@"Excel\", "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".xls") || s.EndsWith(".xlsx"));
            string[] excelFiles = files.ToArray();
            setMessageExcel(excelFiles.Length);
            return excelFiles;
        }

        public void setMessageExcel(int i)
        {
            if (i == 1)
            {
                label_messageMaestro.Text = "Maestro detectado";
                label_messageMaestro.ForeColor = Color.FromArgb(64, 130, 237);
            }
            else if (i == 0)
            {
                label_messageMaestro.Text = "Maestro no detectado";
                label_messageMaestro.ForeColor = Color.FromArgb(242, 72, 126);
            }
            else
            {
                label_messageMaestro.Text = "Mas de un arhivo excel encontrado";
                label_messageMaestro.ForeColor = Color.FromArgb(40, 130, 83);
            }
        }
        public void setExcelFileFromStartup()
        {
            string[] excelFiles = detectExcelFiles();
            if (excelFiles.Length == 1)
            {
                accessExcelFile(Path.GetExtension(@"Excel\" + excelFiles[0]), excelFiles[0]);
            }
        }
        public void timeChange()
        {
            while ((true))
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (label_hora.Text != DateTime.Now.ToString("hh:mm:ss tt"))
                    {
                        label_hora.Text = DateTime.Now.ToString("hh:mm:ss tt");
                    }
                    label_fecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
                    textBox_id.SelectAll();
                    if (countdownSearch >= 0)
                    {
                        countdownSearch--;
                    }
                });
                Thread.Sleep(1000);
            }
        }

        public void threadSingleDatabaseRequestManage()
        {
            this.Invoke((MethodInvoker)delegate
            {
                string name = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string id = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();
                addSingleEmployeeInfoToList(name,id);
                threadSingleDatabaseRequest = null;
            });
        }
        public void threadExcelManage()
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    string excelPath = null;
                    if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        excelPath = Path.GetFullPath(this.saveFileDialog1.FileName);
                        if (Path.GetFileName(excelPath) == null)
                        {
                            excelPath += "Lista de empleados.xlsx";
                        }
                        createExcelFile(excelPath);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error: " + x.Message);
                }
                threadExcel = null;
            });
        }
        public void threadDatabaseRequestManage()
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    addEveryEmployeeInfoToList();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error: " + x.Message.ToString());
                }
                if (employeeAddList.Count > 0)
                {
                    employeeAddList.Clear();
                }
                threadDatabaseRequest = null;
            });
        }
        public void searchForEmployee()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string query = "SELECT DISTINCT name,idEmp,department FROM checklist";
            conexion.quickOpen();
            conexion.Consulta(query);
            if (conexion.dr.HasRows)
            {
                while (conexion.dr.Read())
                {
                    collection.Add(conexion.dr.GetString(0));
                    collection.Add(conexion.dr.GetString(1));
                    collection.Add(conexion.dr.GetString(2));
                }
            }
            conexion.Cerrar();

            textBox_busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_busqueda.AutoCompleteCustomSource = collection;
        }
        public void threadSearchForEmployeeManager()
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    requestEmployees();
                    searchForEmployee();
                }
                catch (Exception x)
                {

                }
                threadSearchForEmployees = null;
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void configuracionDeMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void button_buscar_Click(object sender, EventArgs e)
        {
            try
            { 
            searhExcel(textBox_id.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            button_setMaster.Enabled = false;
            Task task = new Task(AsyncProcessExcel);
            task.Start();
            await task;
        }
        private void credencialesDeBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (server.Visible)
            {

            }
            else
            {
                server = new ServerConfig();
                server.Show();
            }
        }
        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_id.Text != "" && excelData!=null)
            {
                string text = textBox_id.Text;
                try
                {
                    if (text.Contains("B1"))
                    {
                        text = text.Substring(text.IndexOf("1") + 1);
                    }
                    if (text != "")
                    {
                        label_buscado.Text = "Búsqueda: " + text;
                        searhExcel(text);
                    }
                }
                 catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message.ToString());
            }
        }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("Models/logo.png");
            this.Icon = Icon.ExtractAssociatedIcon("Models/logoicon.ico");

            dateTimePicker_endDate.Value = DateTime.Now.Date;
            dateTimePicker_startDate.Value = DateTime.Now.Date;
            button_earnExcelFile.Image = Image.FromFile("Models/excel.png");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countDown < 0)
            {
                threadTime.IsBackground = true;
                threadTime.Start();
                countDown = null;
                timer1.Stop();
            }
            else
            {
                countDown -= 1;
            }
        }
        private async void  button_setMaster_ClickAsync(object sender, EventArgs e)
        {
            button_setMaster.Enabled = false;
            Task task = new Task(AsyncProcessExcel);
            task.Start();
            await task;
        }
        private void comboBox_cuantifyEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_cuantifyEmployes.SelectedItem.ToString().Equals("Específico"))
                {
                    button_earnHours.Enabled = false;
                    requestEmployees();
                    panel_addEmploye.Visible = true;
                    clearAllData();
                }
                else
                {
                    panel_addEmploye.Visible = false;
                    button_earnHours.Enabled = true;
                    clearAllData();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: "+x.Message.ToString());
            }
            if (employeeAddList.Count > 0)
            {
                button_earnHours.Enabled = true;
            }
        }
        private void textBox_id_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox_id.Text != "" && excelData != null)
            {
                string text = textBox_id.Text;
                try
                {
                    if (text.Contains("B1")|| text.Contains("b 1"))
                    {
                        text = text.Substring(text.IndexOf("1") + 1);
                    }
                    if (text != "")
                    {
                        label_buscado.Text = "Búsqueda: " + text;
                        searhExcel(text);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error: " + x.Message.ToString());
                }
            }
        }
        private void comboBox_selectiveEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button_addEmployee_Click(object sender, EventArgs e)
        {
            if (approvedDate)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    threadSingleDatabaseRequest = new Thread(new ThreadStart(threadSingleDatabaseRequestManage));
                    threadSingleDatabaseRequest.IsBackground = true;
                    threadSingleDatabaseRequest.Start();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila con el cursor");
                }
            }
            else
            {
                MessageBox.Show("La fecha inicial debe ser igual o anterior a la fecha final");
            }
        }
        private void button_borrar_Click(object sender, EventArgs e)
        {
            clearAllData();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ayuda.Visible)
            {

            }
            else
            {
                ayuda = new Ayuda();
                ayuda.Show();
            }
        }
        private void textBox_busqueda_KeyUp(object sender, KeyEventArgs e)
        {
        }
        private void textBox_busqueda_TextChanged(object sender, EventArgs e)
        {
            textBox_busqueda.BackColor = Color.FromArgb(255, 153, 204);
            if (threadSearchForEmployees == null && countdownSearch<=0)
            {
                countdownSearch = 60;
                threadSearchForEmployees = new Thread(new ThreadStart(threadSearchForEmployeeManager));
                threadSearchForEmployees.IsBackground = true;
                threadSearchForEmployees.Start();
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Empleado"].Value.ToString().Equals(textBox_busqueda.Text))
                {
                    textBox_busqueda.BackColor = Color.FromArgb(153, 204, 255);
                    dataGridView2.ClearSelection();
                    dataGridView2.CurrentCell = dataGridView2.Rows[row.Index].Cells[0];
                    break;
                }
                else if (row.Cells["Nro. Gafete"].Value.ToString().Equals(textBox_busqueda.Text))
                {
                    textBox_busqueda.BackColor = Color.FromArgb(153, 204, 255);
                    dataGridView2.ClearSelection();
                    dataGridView2.CurrentCell = dataGridView2.Rows[row.Index].Cells[0];
                    break;
                }
                else if (row.Cells["Departamento"].Value.ToString().Equals(textBox_busqueda.Text))
                {
                    textBox_busqueda.BackColor = Color.FromArgb(153, 204, 255);
                    dataGridView2.ClearSelection();
                    dataGridView2.CurrentCell = dataGridView2.Rows[row.Index].Cells[0];
                    break;
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            if (startingDate != dateTimePicker_startDate.Value)
            {
                clearAllData();
            }
            if (endingDate != null && startingDate != null)
            {
                startingDate = dateTimePicker_startDate.Value;
                endingDate = dateTimePicker_endDate.Value;

                if (endingDate.CompareTo(startingDate) < 0)
                {
                    approvedDate = false;
                    MessageBox.Show("La fecha inicial debe ser igual o anterior a la fecha final");
                }
                else
                {
                    approvedDate = true;
                }
            }
        }
        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endingDate != dateTimePicker_endDate.Value)
            {
                clearAllData();
            }
            if (endingDate != null && startingDate != null)
            {
                endingDate = dateTimePicker_endDate.Value;
                startingDate = dateTimePicker_startDate.Value;
                if (endingDate.CompareTo(startingDate) < 0)
                {
                    approvedDate = false;
                    MessageBox.Show("La fecha inicial debe ser igual o anterior a la fecha final");
                }
                else
                {
                    approvedDate = true;
                }
            }
        }
        private void button_earnHours_Click(object sender, EventArgs e)
        {
            if (approvedDate)
            {
                threadDatabaseRequest = new Thread(new ThreadStart(threadDatabaseRequestManage));
                threadDatabaseRequest.IsBackground = true;
                threadDatabaseRequest.Start();
            }
            else
            {
                MessageBox.Show("La fecha inicial debe ser igual o anterior a la fecha final");
            }
        }
        private void button_deleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string name = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString();

                deleteEmployeeFromInfo(name);
            }
            else
            {
                MessageBox.Show("Seleccione una fila con el cursor");
            }
        }
        private void button_earnExcelFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                threadExcel = new Thread(new ThreadStart(threadExcelManage));
                threadExcel.IsBackground = true;
                threadExcel.Start();
            }
            else
            {
                MessageBox.Show("Agregue datos para generar el archivo excel");
            }
        }
    }
}
