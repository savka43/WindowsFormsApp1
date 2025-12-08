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
    public partial class InspectorDoverie : Form
    {
        public InspectorDoverie()
        {
            InitializeComponent();

            LoadDoverennosti();
            LoadMarks();
            LoadStatus();

            dateStart.Checked = false;
            dateEnd.Checked = false;

            // --- ВАЖНО: добавляем обработчик двойного клика ---
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void LoadDoverennosti()
        {
            DataBase db = new DataBase();
            db.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_ИнспекторДоверенности", db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            db.closeConnection();
        }

        private void LoadMarks()
        {
            DataBase db = new DataBase();
            db.openConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT Марка FROM vw_ИнспекторДоверенности ORDER BY Марка",
                db.getConnection());

            SqlDataReader reader = cmd.ExecuteReader();
            CarBrand.Items.Clear();
            while (reader.Read())
                CarBrand.Items.Add(reader["Марка"].ToString());

            reader.Close();
            db.closeConnection();

            CarModel.Items.Clear();
        }

        private void LoadModels(string mark)
        {
            DataBase db = new DataBase();
            db.openConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT Модель FROM vw_ИнспекторДоверенности WHERE Марка = @mark ORDER BY Модель",
                db.getConnection());
            cmd.Parameters.AddWithValue("@mark", mark);

            SqlDataReader reader = cmd.ExecuteReader();
            CarModel.Items.Clear();
            while (reader.Read())
                CarModel.Items.Add(reader["Модель"].ToString());

            reader.Close();
            db.closeConnection();
        }

        private void LoadStatus()
        {
            stateOfDoverie.Items.Clear();
            stateOfDoverie.Items.Add("Действительна");
            stateOfDoverie.Items.Add("Просрочена");
        }

        private void ApplyFullFilter()
        {
            DataBase db = new DataBase();
            db.openConnection();

            SqlCommand cmd = new SqlCommand("ФильтрДоверенностейИнспектор", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DriverFIO", string.IsNullOrWhiteSpace(DriverFIO.Text) ? (object)DBNull.Value : DriverFIO.Text);
            cmd.Parameters.AddWithValue("@OwnerFIO", string.IsNullOrWhiteSpace(OwnerFIO.Text) ? (object)DBNull.Value : OwnerFIO.Text);
            cmd.Parameters.AddWithValue("@Marka", CarBrand.SelectedIndex != -1 ? CarBrand.SelectedItem.ToString() : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Model", CarModel.SelectedIndex != -1 ? CarModel.SelectedItem.ToString() : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DateStart", dateStart.Checked ? (object)dateStart.Value.Date : DBNull.Value);
            cmd.Parameters.AddWithValue("@DateEnd", dateEnd.Checked ? (object)dateEnd.Value.Date : DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", stateOfDoverie.SelectedIndex != -1 ? stateOfDoverie.SelectedItem.ToString() : (object)DBNull.Value);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Id_Доверенности"].HeaderText = "Номер доверенности";
            db.closeConnection();
        }

        // --- УДАЛЕНИЕ ДОКУМЕНТА ПРИ ДВОЙНОМ КЛИКЕ ---
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Берём ID доверенности из таблицы (колонка "Id_Доверенности")
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id_Доверенности"].Value);

            var res = MessageBox.Show(
                $"Удалить доверенность № {id}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (res == DialogResult.Yes)
            {
                // Удаляем доверенность через процедуру
                DataBase db = new DataBase();
                db.openConnection();

                SqlCommand cmd = new SqlCommand("УдалитьДоверенность", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Доверенности", id);

                cmd.ExecuteNonQuery();
                db.closeConnection();

                // Сообщение о успешном удалении
                MessageBox.Show("Доверенность успешно удалена");

                // Обновляем таблицу
                LoadDoverennosti();
            }
        }

        // --- ВЫЗОВ ХРАНИМОЙ ПРОЦЕДУРЫ УДАЛЕНИЯ ---
        private void DeleteDoverennost(int id)
        {
            DataBase db = new DataBase();
            db.openConnection();

            SqlCommand cmd = new SqlCommand("УдалитьДоверенность", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Доверенности", id);

            cmd.ExecuteNonQuery();
            db.closeConnection();
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            ApplyFullFilter();
        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            CarBrand.SelectedIndex = -1;
            CarModel.Items.Clear();
            CarModel.SelectedIndex = -1;

            DriverFIO.Clear();
            OwnerFIO.Clear();
            stateOfDoverie.SelectedIndex = -1;

            dateStart.Value = DateTime.Today;
            dateEnd.Value = DateTime.Today;
            dateStart.Checked = false;
            dateEnd.Checked = false;

            LoadDoverennosti();
        }

        private void CarBrand_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CarBrand.SelectedIndex != -1)
                LoadModels(CarBrand.SelectedItem.ToString());

        }

        private void CarModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void stateOfDoverie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dateStart_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dateEnd_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void DriverFIO_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void OwnerFIO_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            InspectorMainForm frm = new InspectorMainForm();
            frm.Show();
            this.Close();
        }

        // Пустые обработчики
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void InspectorDoverie_Load(object sender, EventArgs e) { }
    }
}