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
    public partial class InspectorMainForm : Form
    {
        public InspectorMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TsInspector tsInspector = new TsInspector();
            tsInspector.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InspectorUD inspectorUD = new InspectorUD();
            inspectorUD.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InspectorCars inspectorCars = new InspectorCars(); 
            inspectorCars.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InspectorOwner inspectorOwner = new InspectorOwner();
            inspectorOwner.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InspectorDoverie inspectorDoverie = new InspectorDoverie();
            inspectorDoverie.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InspectorDTP inspectorDTP = new InspectorDTP();
            inspectorDTP.Show();
            this.Hide();
        }
    }
}
