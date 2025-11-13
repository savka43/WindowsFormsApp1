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
        public DriverFinesForm()
        {
            InitializeComponent();
            radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverMainForm driverform = new DriverMainForm();
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
            // Загружаем все штрафы при старте формы
            LoadFines("Все");
        }

        // Метод для загрузки штрафов по статусу
        private void LoadFines(string status)
        {
            // Открываем соединение
            db.openConnection();

            // Создаем команду для вызова процедуры
            SqlCommand command = new SqlCommand("ПолучитьШтрафы", db.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            // ✅ Добавляем параметры
            command.Parameters.AddWithValue("@Id_TC", 101); // Константа — айди ТС Иванова
            command.Parameters.AddWithValue("@Статус", status);

            // Создаем адаптер и таблицу
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Привязываем данные к таблице
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Закрываем соединение
            db.closeConnection();
        }

    }
}
