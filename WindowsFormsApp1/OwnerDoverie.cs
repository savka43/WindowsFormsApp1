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
    public partial class OwnerDoverie : Form
    {
        DataBase dataBase = new DataBase();
        private int currentDriverId = 101;

        public OwnerDoverie()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.Show();
            this.Hide();
        }

        private void OwnerDoverie_Load(object sender, EventArgs e)
        {
            LoadDoverenosti();
        }

        private void LoadDoverenosti()
        {
            dataBase.openConnection();


            using (SqlCommand command = new SqlCommand("ПолучитьДоверенностиВладельца", dataBase.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

              
                command.Parameters.Add("@Id_Владельца", SqlDbType.Int).Value = currentDriverId; 

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            dataBase.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DobavlenieDoverennosti dobavlenieDoverennosti = new DobavlenieDoverennosti();
            dobavlenieDoverennosti.Show();
            this.Hide();
        }
    }
}