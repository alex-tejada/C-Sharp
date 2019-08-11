using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            pictureBox_logo.Image = Image.FromFile(@"Models\Logo.png");
            pictureBox_delphi.Image = Image.FromFile(@"Models\delphi.png");
            this.Icon = Icon.ExtractAssociatedIcon("Models/logoicon.ico");
        }
    }
}
