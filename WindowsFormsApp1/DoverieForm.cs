using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DoverieForm : Form
    {
        DataBase database = new DataBase();

        public DoverieForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverMainForm driverForm = new DriverMainForm();
            driverForm.Show();
            this.Hide();
        }

        private void DoverieForm_Load(object sender, EventArgs e)
        {
            LoadDoverennosti();
        }

        private void LoadDoverennosti()
        {
            SqlCommand command = new SqlCommand("ПолучитьДоверенностиПоВодителю", database.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id_Водителя", 101); // конкретный водитель

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
