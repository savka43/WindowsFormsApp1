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
    public partial class DriverFinesForm : Form
    {
        private DataBase db = new DataBase();

        private int driverId;
        public DriverFinesForm(int id)
        {
            InitializeComponent();
            radioButton3.Checked = true;
            driverId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverMainForm driverform = new DriverMainForm(driverId);
            driverform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                LoadFines("Оплачен");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                LoadFines("Не оплачен");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                LoadFines("Все");
        }
        private void DriverFinesForm_Load(object sender, EventArgs e)
        {
            
            LoadFines("Все");
        }

        
        private void LoadFines(string status)
        {
            SqlCommand command = new SqlCommand("ПолучитьШтрафыВодителя", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            
            command.Parameters.AddWithValue("@Id_Водителя", driverId); 
            command.Parameters.AddWithValue("@Статус", status);

       
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

        
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            db.closeConnection();
        }

    }
}
