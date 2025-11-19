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
    public partial class InspectorUD : Form
    {
        DataBase db = new DataBase();

        public InspectorUD()
        {
            InitializeComponent();

            // Двойной клик по DataGridView
            this.dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void InspectorUD_Load(object sender, EventArgs e)
        {
            dateStart.Checked = false;
            dateEnd.Checked = false;
            // При открытии формы показываем все водители
            LoadAllDrivers();
        }

        private void LoadAllDrivers()
        {
            SqlCommand cmd = new SqlCommand("FilterDrivers", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            // Все параметры null для отображения всех записей
            cmd.Parameters.AddWithValue("@FIO", DBNull.Value);
            cmd.Parameters.AddWithValue("@Номер_BY", DBNull.Value);
            cmd.Parameters.AddWithValue("@ДатаОт", DBNull.Value);
            cmd.Parameters.AddWithValue("@ДатаДо", DBNull.Value);

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            db.closeConnection();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("FilterDrivers", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            // Только добавляем параметры, если они заполнены
            if (!string.IsNullOrWhiteSpace(textFio.Text))
                cmd.Parameters.AddWithValue("@FIO", textFio.Text);
            else
                cmd.Parameters.AddWithValue("@FIO", DBNull.Value);

            if (!string.IsNullOrWhiteSpace(textNumber.Text))
                cmd.Parameters.AddWithValue("@Номер_BY", textNumber.Text);
            else
                cmd.Parameters.AddWithValue("@Номер_BY", DBNull.Value);

            if (dateStart.Checked)
                cmd.Parameters.AddWithValue("@ДатаОт", dateStart.Value.Date);
            else
                cmd.Parameters.AddWithValue("@ДатаОт", DBNull.Value);

            if (dateEnd.Checked)
                cmd.Parameters.AddWithValue("@ДатаДо", dateEnd.Value.Date);
            else
                cmd.Parameters.AddWithValue("@ДатаДо", DBNull.Value);

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            db.closeConnection();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Сбрасываем текстовые поля
            textFio.Text = "";
            textNumber.Text = "";

            // Сбрасываем DateTimePicker
            dateStart.Value = DateTime.Today;
            dateEnd.Value = DateTime.Today;
            dateStart.Checked = false;
            dateEnd.Checked = false;

            // Загружаем все записи заново
            LoadAllDrivers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InspectorMainForm inspectorMainForm = new InspectorMainForm();
            inspectorMainForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedFio = dataGridView1.Rows[e.RowIndex].Cells["ФИО"].Value.ToString();

                SqlCommand cmd = new SqlCommand("FilterDrivers", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FIO", selectedFio);
                cmd.Parameters.AddWithValue("@Номер_BY", DBNull.Value);
                cmd.Parameters.AddWithValue("@ДатаОт", DBNull.Value);
                cmd.Parameters.AddWithValue("@ДатаДо", DBNull.Value);

                db.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                db.closeConnection();
            }
        }

        // Если Designer ругается, просто добавляем пустой обработчик
        private void label3_Click(object sender, EventArgs e) { }
    }
}