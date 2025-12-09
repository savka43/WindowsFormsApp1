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
    public partial class DriverMainForm : Form
    {

        private int driverId;
        private DataBase db;
        public DriverMainForm(int id)
        {
            InitializeComponent();
            driverId = id;


            db = new DataBase();
            LoadDriverFIO();

        }

        private void DriverMainForm_Load(object sender, EventArgs e)
        {


        }
        private void LoadDriverFIO()
        {
            db.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT ФИО FROM Водитель WHERE Id_Водителя = @Id", db.getConnection());
            cmd.Parameters.AddWithValue("@Id", driverId);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read(); // читаем первую (и единственную) строку
            textBoxFIO.Text = reader["ФИО"].ToString(); // подставляем ФИО

            reader.Close();
            db.closeConnection();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DriverTSForm drivertsform = new DriverTSForm(driverId);
            drivertsform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverFinesForm driverFinesForm = new DriverFinesForm(driverId);
            driverFinesForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoverieForm doverieForm = new DoverieForm(driverId);
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
