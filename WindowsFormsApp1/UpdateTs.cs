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
            if (MessageBox.Show("Вы действительно хотите снять это ТС с учета?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand("СнятьТССУчета", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_ТС", IdТС);

                // Подписываемся на InfoMessage для RAISERROR с уровнем <= 10 (информационные)
                db.getConnection().InfoMessage += (s, ev) =>
                {
                    MessageBox.Show(ev.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };

                cmd.ExecuteNonQuery();

                // Если процедура вернула SELECT с сообщением
                SqlCommand cmdResult = new SqlCommand("SELECT 'Машина успешно снята с учета.' AS ResultMessage", db.getConnection());
                var result = cmdResult.ExecuteScalar();
                MessageBox.Show(result.ToString(), "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (SqlException ex)
            {
                // RAISERROR с уровнем >= 11 попадает сюда
                string userMessage = "Произошла ошибка при снятии машины с учета.";

                if (ex.Message.Contains("участвовала в ДТП"))
                    userMessage = "Невозможно снять с учета машину: она участвовала в ДТП.";
                else if (ex.Message.Contains("неоплаченные штрафы"))
                    userMessage = "Невозможно снять с учета машину: есть неоплаченные штрафы.";

                MessageBox.Show(userMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                db.closeConnection();
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

            cmd.Parameters.AddWithValue("@Id_ТС", IdТС);

            // Строковые поля — передаём либо текст, либо DBNull
            cmd.Parameters.Add("@Марка", SqlDbType.VarChar, 50).Value =
                string.IsNullOrWhiteSpace(carBrand.Text) ? (object)DBNull.Value : carBrand.Text.Trim();

            cmd.Parameters.Add("@Модель", SqlDbType.VarChar, 50).Value =
                string.IsNullOrWhiteSpace(carModel.Text) ? (object)DBNull.Value : carModel.Text.Trim();

            cmd.Parameters.Add("@Цвет", SqlDbType.VarChar, 30).Value =
                string.IsNullOrWhiteSpace(carColor.Text) ? (object)DBNull.Value : carColor.Text.Trim();

            cmd.Parameters.Add("@Гос_номер", SqlDbType.VarChar, 15).Value =
                string.IsNullOrWhiteSpace(carPlate.Text) ? (object)DBNull.Value : carPlate.Text.Trim();

            // Год выпуска
            if (short.TryParse(carYear.Text.Trim(), out short year))
                cmd.Parameters.AddWithValue("@Год_Выпуска", year);
            else
                cmd.Parameters.AddWithValue("@Год_Выпуска", DBNull.Value);

            // Паспорт владельца
            cmd.Parameters.Add("@ПаспортВладельца", SqlDbType.Char, 10).Value =
                string.IsNullOrWhiteSpace(passportOwner.Text) ? (object)DBNull.Value : passportOwner.Text.Trim();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные ТС успешно обновлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // Выводим сообщение из RAISERROR
                MessageBox.Show(ex.Message, "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}