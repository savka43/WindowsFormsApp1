using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DoverieForm : Form
    {

        DataBase database = new DataBase();
        private int driverid;
        public DoverieForm(int id)
        {
            InitializeComponent();
            driverid = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverMainForm driverForm = new DriverMainForm(driverid);
            driverForm.Show();
            this.Hide();
        }

        private void DoverieForm_Load(object sender, EventArgs e)
        {
            LoadDoverennosti();
        }

        private void LoadDoverennosti()
        {
            SqlCommand command = new SqlCommand("ПолучитьДоверенностиВодителя", database.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id_Водителя", driverid); // конкретный водитель

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            database.openConnection();
            adapter.Fill(table);
            database.closeConnection();

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
