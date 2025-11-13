using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DriverTSForm : Form
    {
        private DataBase db = new DataBase(); // подключение к БД

        public DriverTSForm()
        {
            InitializeComponent();
        }

        private void DriverTSForm_Load(object sender, EventArgs e)
        {
            // Загружаем данные при открытии формы
            LoadCarInfo(101); // айди водителя Иванова
        }

        private void LoadCarInfo(int driverId)
        {
            // открываем соединение
            db.openConnection();

            // создаем команду для вызова хранимой процедуры
            SqlCommand command = new SqlCommand("ПолучитьИнфоОбАвтомобиле", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            // передаем параметр ID водителя
            command.Parameters.AddWithValue("@Id_Водителя", driverId);

            // создаем адаптер и таблицу
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // выводим в DataGridView
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // закрываем соединение
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverMainForm driverForm = new DriverMainForm();
            driverForm.Show();
            this.Hide();
        }
    }
}
