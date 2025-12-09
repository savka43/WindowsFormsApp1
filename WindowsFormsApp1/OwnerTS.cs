using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class OwnerTS : Form
    {
        private DataBase db = new DataBase(); 
        private int ownerId;
        public OwnerTS(int id)
        {
            InitializeComponent();
            ownerId = id;
        }

        private void OwnerTS_Load(object sender, EventArgs e)
        {
            
            LoadCarInfo(101); 
        }

        private void LoadCarInfo(int driverId)
        {
            
            db.openConnection();

           
            SqlCommand command = new SqlCommand("ПолучитьАвтоВладельца", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            
            command.Parameters.AddWithValue("@Id_Владельца", driverId);

           
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

           
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm(ownerId);
            ownerForm.Show();
            this.Hide();
        }
    }
}