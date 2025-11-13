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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerDoverie ownerDoverie = new OwnerDoverie();
            ownerDoverie.Show();
            this.Hide();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerFines ownerFines = new OwnerFines();
            ownerFines.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OwnerTS ownerTS = new OwnerTS();
            ownerTS.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
