using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DriverTSForm : Form
    {
        private DataBase db = new DataBase(); // подключение к БД
        private int driverid;
        public DriverTSForm(int id)
        {
            InitializeComponent();
            driverid = id;
        }

        private void DriverTSForm_Load(object sender, EventArgs e)
        {
            // Загружаем данные при открытии формы
            LoadCarInfo(driverid); // айди водителя Иванова
        }

        private void LoadCarInfo(int driverId)
        {

            db.openConnection();


            SqlCommand command = new SqlCommand("ПолучитьАвтоВодителя", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.AddWithValue("@Id_Водителя", driverId);

  
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);


            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverMainForm driverForm = new DriverMainForm(driverid);
            driverForm.Show();
            this.Hide();
        }
    }
}
