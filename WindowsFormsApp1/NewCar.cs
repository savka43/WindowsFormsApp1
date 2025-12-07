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
    public partial class NewCar : Form
    {
        private DataBase db = new DataBase();

        public NewCar()
        {
            InitializeComponent();
            addAuto.Click += addAuto_Click;
        }

        private void NewCar_Load(object sender, EventArgs e)
        {
        }

        private void addAuto_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(carYear.Text.Trim(), out int year))
            {
                MessageBox.Show("Введите корректный год выпуска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.openConnection();

            SqlCommand addCar = new SqlCommand("ДобавитьТС", db.getConnection());
            addCar.CommandType = CommandType.StoredProcedure;

            addCar.Parameters.AddWithValue("@Паспорт_Владельца", passportOwner.Text.Trim());
            addCar.Parameters.AddWithValue("@Марка", carBrand.Text.Trim());
            addCar.Parameters.AddWithValue("@Модель", carModel.Text.Trim());
            addCar.Parameters.AddWithValue("@Цвет", textBox4.Text.Trim());
            addCar.Parameters.AddWithValue("@Гос_номер", carPlate.Text.Trim());
            addCar.Parameters.AddWithValue("@Дата_Регистрации", dateRegistration.Value.Date);
            addCar.Parameters.AddWithValue("@Год_Выпуска", year); 

            SqlDataReader reader = addCar.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show($"ТС добавлено успешно! Id: {reader["Id_Созданного_ТС"]}");
            }

            reader.Close();
            db.closeConnection();
        }
    }
}