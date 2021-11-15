using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerConfigForm_P5_046
{
    public partial class Form1 : Form
    {
        private ServiceHost host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(Matematika));

            label1.Text = "Server ON";
            labelket.Text = "Klik OFF untuk Mematikan Server";
            host.Open();
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;

        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            host.Close();
            labelket.Text = "Klik OFF untuk Mematikan Server";
            label1.Text = "Server Off"; 

        }
    }
}
