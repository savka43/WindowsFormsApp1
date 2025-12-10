using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InspectorMainForm : Form
    {
        private int inspectorId;
        public InspectorMainForm(int id)
        {
            InitializeComponent();
            inspectorId = id;
            LoadInspectorInfo();
        }

        private void LoadInspectorInfo()
        {
            DataBase db = new DataBase();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand(
                "SELECT ФИО, Должность FROM Инспектор_ГИБДД WHERE Id_Инспектора = @id",
                db.getConnection()))
            {
                cmd.Parameters.AddWithValue("@id", inspectorId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxFio.Text = reader["ФИО"].ToString();
                    textBoxJob.Text = reader["Должность"].ToString();
                }

                reader.Close();
            }

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TsInspector tsInspector = new TsInspector(inspectorId);
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
            InspectorUD inspectorUD = new InspectorUD(inspectorId);
            inspectorUD.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InspectorCars inspectorCars = new InspectorCars(inspectorId); 
            inspectorCars.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InspectorOwner inspectorOwner = new InspectorOwner(inspectorId);
            inspectorOwner.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InspectorDoverie inspectorDoverie = new InspectorDoverie(inspectorId);
            inspectorDoverie.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InspectorDTP inspectorDTP = new InspectorDTP(inspectorId);
            inspectorDTP.Show();
            this.Hide();
        }

        private void InspectorMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
