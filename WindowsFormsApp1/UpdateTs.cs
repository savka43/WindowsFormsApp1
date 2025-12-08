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
    public partial class UpdateTs : Form
    {
        private DataBase db = new DataBase();

        // Свойства для передачи данных из главной формы
        public int IdТС { get; set; }
        public string carBrandText { get; set; }
        public string carModelText { get; set; }
        public string carColorText { get; set; }
        public string carPlateText { get; set; }
        public string carYearText { get; set; }
        public string passportOwnerText { get; set; }
        public string passOwnerText { get; set; }

        public UpdateTs()
        {
            InitializeComponent();
        }

        private void UpdateTs_Load(object sender, EventArgs e)
        {
            // Заполняем поля формы переданными данными
            carBrand.Text = carBrandText;
            carModel.Text = carModelText;
            carColor.Text = carColorText;
            carPlate.Text = carPlateText;
            carYear.Text = carYearText;
            passportOwner.Text = passportOwnerText;

        }


        // Кнопка удаления ТС
        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить это ТС?",
        "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.openConnection();

                db.getConnection().InfoMessage += (s, ev) =>
                {
                    MessageBox.Show(ev.Message, "Сообщение SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };

                SqlCommand cmd = new SqlCommand("УдалитьТС", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_ТС", IdТС);

                cmd.ExecuteNonQuery();

                db.closeConnection();


                this.Close();
            }
        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            carBrand.Text = carBrandText;
            carModel.Text = carModelText;
            carColor.Text = carColorText;
            carPlate.Text = carPlateText;
            carYear.Text = carYearText;
            passportOwner.Text = passportOwnerText;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            SqlCommand cmd = new SqlCommand("ОбновитьТС", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            // ID ТС
            cmd.Parameters.AddWithValue("@Id_ТС", IdТС);

            // Строковые поля — передаём либо текст, либо NULL
            cmd.Parameters.Add("@Марка", SqlDbType.VarChar, 50).Value =
                carBrand.Text.Trim().Length == 0 ? (object)DBNull.Value : carBrand.Text.Trim();

            cmd.Parameters.Add("@Модель", SqlDbType.VarChar, 50).Value =
                carModel.Text.Trim().Length == 0 ? (object)DBNull.Value : carModel.Text.Trim();

            cmd.Parameters.Add("@Цвет", SqlDbType.VarChar, 30).Value =
                carColor.Text.Trim().Length == 0 ? (object)DBNull.Value : carColor.Text.Trim();

            cmd.Parameters.Add("@Гос_номер", SqlDbType.VarChar, 15).Value =
                carPlate.Text.Trim().Length == 0 ? (object)DBNull.Value : carPlate.Text.Trim();

            // Год выпуска
            if (short.TryParse(carYear.Text.Trim(), out short year))
                cmd.Parameters.AddWithValue("@Год_Выпуска", year);
            else
                cmd.Parameters.AddWithValue("@Год_Выпуска", DBNull.Value);

            // Паспорт владельца — ВСЕГДА строка, не int
            cmd.Parameters.Add("@ПаспортВладельца", SqlDbType.VarChar, 20).Value =
                passportOwner.Text.Trim().Length == 0 ? (object)DBNull.Value : passportOwner.Text.Trim();

            // -------------------------
            // Считываем PRINT из SQL
            // -------------------------
            cmd.ExecuteNonQuery();

            SqlCommand msgCmd = new SqlCommand("SELECT @@ROWCOUNT", db.getConnection());
            // Важно: вызвать reader для получения PRINT
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // SQL может вернуть PRINT — показываем его пользователю
                if (!reader.IsDBNull(0))
                {
                    string message = reader.GetString(0);
                    if (!string.IsNullOrWhiteSpace(message))
                    {
                        MessageBox.Show(message, "Сообщение SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reader.Close();
                        db.closeConnection();
                        return;
                    }
                }
            }
            reader.Close();

            db.closeConnection();
            MessageBox.Show("Данные ТС успешно обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}