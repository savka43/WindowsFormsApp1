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

            // Модели
            SqlCommand cmdModel = new SqlCommand("SELECT DISTINCT Модель FROM ТС", db.getConnection());
            SqlDataAdapter daModel = new SqlDataAdapter(cmdModel);
            DataTable dtModel = new DataTable();
            daModel.Fill(dtModel);
            modelCar.Items.Clear();
            foreach (DataRow row in dtModel.Rows)
                modelCar.Items.Add(row["Модель"].ToString());

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

        private void LoadCars(string brand, string model, short? year, DateTime? start, DateTime? end, string color, string plate)
        {
            using (SqlCommand cmd = new SqlCommand("ФильтрТС", db.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Марка", string.IsNullOrWhiteSpace(brand) ? (object)DBNull.Value : brand);
                cmd.Parameters.AddWithValue("@Модель", string.IsNullOrWhiteSpace(model) ? (object)DBNull.Value : model);
                cmd.Parameters.AddWithValue("@Год", year.HasValue ? (object)year : DBNull.Value);
                cmd.Parameters.AddWithValue("@Цвет", string.IsNullOrWhiteSpace(color) ? (object)DBNull.Value : color);
                cmd.Parameters.AddWithValue("@ГосНомер", string.IsNullOrWhiteSpace(plate) ? (object)DBNull.Value : plate);

                // Передаём дату постановки только если обе даты заданы
                if (start.HasValue && end.HasValue)
                {
                    cmd.CommandText = @"
                SELECT *
                FROM ТС
                WHERE (@Марка IS NULL OR Марка = @Марка)
                  AND (@Модель IS NULL OR Модель = @Модель)
                  AND (@Год IS NULL OR Год_Выпуска = @Год)
                  AND (@Цвет IS NULL OR Цвет = @Цвет)
                  AND (@ГосНомер IS NULL OR Гос_номер = @ГосНомер)
                  AND Дата_Постановки BETWEEN @Start AND @End";

                    cmd.Parameters.AddWithValue("@Start", start.Value.Date);
                    cmd.Parameters.AddWithValue("@End", end.Value.Date);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ДатаПостановки", DBNull.Value);
                }

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                db.openConnection();
                da.Fill(table);
                db.closeConnection();

                dataGridView1.DataSource = table;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string brand = carBrand.SelectedItem?.ToString();
            string model = modelCar.SelectedItem?.ToString();
            string color = carColor.SelectedItem?.ToString();
            string plate = carPlate.Text.Trim();

            DateTime? start = startDate.Checked ? startDate.Value.Date : (DateTime?)null;
            DateTime? end = endDate.Checked ? endDate.Value.Date : (DateTime?)null;

            LoadCars(brand, model, null, start, end, color, plate);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            carBrand.SelectedIndex = -1;
            modelCar.SelectedIndex = -1;
            carColor.SelectedIndex = -1;
            carPlate.Clear();
            startDate.Checked = false;
            endDate.Checked = false;

            LoadCars(null, null, null, null, null, null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InspectorMainForm f = new InspectorMainForm();
            f.Show();
            this.Hide();
        }

        private void carBrand_SelectedIndexChanged(object sender, EventArgs e) { }
        private void modelCar_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void dateRegistration_ValueChanged(object sender, EventArgs e) { }
    }
}