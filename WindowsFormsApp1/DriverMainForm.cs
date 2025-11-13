using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DriverMainForm : Form
    {
        public DriverMainForm()
        {
            InitializeComponent();
        }

        private void DriverMainForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DriverTSForm drivertsform = new DriverTSForm();
            drivertsform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverFinesForm driverFinesForm = new DriverFinesForm();
            driverFinesForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoverieForm doverieForm = new DoverieForm();
            doverieForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
