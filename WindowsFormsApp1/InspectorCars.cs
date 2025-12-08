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
    public partial class InspectorCars : Form
    {
        private DataBase db = new DataBase();

        public InspectorCars()
        {
            InitializeComponent();
        }

        private void InspectorCars_Load(object sender, EventArgs e)
        {
            dateRegistration.Checked = false;
            startDate.Checked = false;
            endDate.Checked = false;

            LoadComboBoxes();
            LoadCars(null, null, null, null, null, null, null);

            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // Игнорируем клик по заголовкам
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Получаем данные о ТС из строки
            int idTs = Convert.ToInt32(row.Cells["Id_ТС"].Value);
            string brand = row.Cells["Марка"].Value.ToString();
            string model = row.Cells["Модель"].Value.ToString();
            string color = row.Cells["Цвет"].Value.ToString();
            string plate = row.Cells["Гос_номер"].Value.ToString();
            short year = Convert.ToInt16(row.Cells["Год_Выпуска"].Value);

            // Можно получить данные владельца, если они есть в таблице (или через JOIN в хранимой процедуре)
            string ownerPassport = row.Cells["ПаспортВладельца"].Value.ToString(); // пример
            string ownerName = row.Cells["ФиоВладельца"].Value.ToString(); // пример

            // Создаем форму редактирования ТС и передаем данные
            UpdateTs updateForm = new UpdateTs
            {
                IdТС = idTs, // нужно добавить свойство IdТС в форме UpdateTs
                carBrandText = brand,
                carModelText = model,
                carColorText = color,
                carPlateText = plate,
                carYearText = year.ToString(),
                passportOwnerText = ownerPassport,
                passOwnerText = ownerName
            };

            updateForm.ShowDialog(); // открываем как модальное окно
        }

        private void LoadComboBoxes()
        {
            db.openConnection();

            // Марки
            SqlCommand cmdBrand = new SqlCommand("SELECT DISTINCT Марка FROM ТС", db.getConnection());
            SqlDataAdapter daBrand = new SqlDataAdapter(cmdBrand);
            DataTable dtBrand = new DataTable();
            daBrand.Fill(dtBrand);
            carBrand.Items.Clear();
            foreach (DataRow row in dtBrand.Rows)
                carBrand.Items.Add(row["Марка"].ToString());


            // Цвета
            SqlCommand cmdColor = new SqlCommand("SELECT DISTINCT Цвет FROM ТС", db.getConnection());
            SqlDataAdapter daColor = new SqlDataAdapter(cmdColor);
            DataTable dtColor = new DataTable();
            daColor.Fill(dtColor);
            carColor.Items.Clear();
            foreach (DataRow row in dtColor.Rows)
                carColor.Items.Add(row["Цвет"].ToString());

            db.closeConnection();
        }

        private void LoadCars(string brand, string model, short? yearStart, short? yearEnd, string color, string plate, DateTime? registrationDate)
        {
            using (SqlCommand cmd = new SqlCommand("ФильтрТС", db.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Марка", string.IsNullOrWhiteSpace(brand) ? (object)DBNull.Value : brand);
                cmd.Parameters.AddWithValue("@Модель", string.IsNullOrWhiteSpace(model) ? (object)DBNull.Value : model);
                cmd.Parameters.AddWithValue("@ГодНачало", yearStart.HasValue ? (object)yearStart.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ГодКонец", yearEnd.HasValue ? (object)yearEnd.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Цвет", string.IsNullOrWhiteSpace(color) ? (object)DBNull.Value : color);
                cmd.Parameters.AddWithValue("@ГосНомер", string.IsNullOrWhiteSpace(plate) ? (object)DBNull.Value : plate);
                cmd.Parameters.AddWithValue("@ДатаПостановки", registrationDate.HasValue ? (object)registrationDate.Value.Date : DBNull.Value);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                db.openConnection();
                da.Fill(table);
                db.closeConnection();

                dataGridView1.DataSource = table;
                dataGridView1.Columns["Id_ТС"].Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string brand = carBrand.SelectedItem?.ToString();
            string model = modelCar.SelectedItem?.ToString();
            string color = carColor.SelectedItem?.ToString();
            string plate = carPlate.Text.Trim();

            short? yearStart = startDate.Checked ? (short?)startDate.Value.Year : null;
            short? yearEnd = endDate.Checked ? (short?)endDate.Value.Year : null;
            DateTime? registrationDate = dateRegistration.Checked ? (DateTime?)dateRegistration.Value.Date : null;

            LoadCars(brand, model, yearStart, yearEnd, color, plate, registrationDate);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            carBrand.SelectedIndex = -1;
            modelCar.SelectedIndex = -1;
            carColor.SelectedIndex = -1;
            carPlate.Clear();
            startDate.Checked = false;
            endDate.Checked = false;
            dateRegistration.Checked = false;

            LoadCars(null, null, null, null, null, null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InspectorMainForm f = new InspectorMainForm();
            f.Show();
            this.Hide();
        }

        private void carBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = carBrand.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedBrand))
                return;

            modelCar.Items.Clear();

            db.openConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT Модель FROM ТС WHERE Марка = @Марка",
                db.getConnection()
            );
            cmd.Parameters.AddWithValue("@Марка", selectedBrand);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
                modelCar.Items.Add(row["Модель"].ToString());

            db.closeConnection();

            // Сбрасываем выбранную модель при смене марки
            modelCar.SelectedIndex = -1;
        }
        private void modelCar_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void dateRegistration_ValueChanged(object sender, EventArgs e) { }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar();
            newCar.Show();
        }
    }
}