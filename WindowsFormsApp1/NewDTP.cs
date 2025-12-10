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
    public partial class NewDTP : Form
    {
        DataBase db = new DataBase();
        private int inspectorId;
        public NewDTP(int id)
        {
            InitializeComponent();
            inspectorId = id;

            // Настройка DateTimePicker для выбора даты и времени
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.ShowUpDown = true; // Стрелки для удобного выбора времени
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка адреса
            if (string.IsNullOrWhiteSpace(adress.Text))
            {
                MessageBox.Show("Введите адрес ДТП!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Значение даты и времени
            DateTime dtpDateTime = dateTimePicker1.Value;

            // Айди инспектора пока фиксированный

            string resultMessage = AddDTPProcedure(inspectorId, adress.Text.Trim(), dtpDateTime);

            MessageBox.Show(resultMessage, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string AddDTPProcedure(int inspectorId, string address, DateTime dtpDateTime)
        {
            string result = "";

            using (SqlCommand cmd = new SqlCommand("ДобавитьДТП", db.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InspectorId", inspectorId);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@DTPDateTime", dtpDateTime);

                SqlParameter output = new SqlParameter("@ResultMessage", SqlDbType.NVarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();

                result = output.Value.ToString();
            }

            return result;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Можно оставить пустым, т.к. клики на label обычно не нужны
        }

        private void NewDTP_Load(object sender, EventArgs e)
        {

        }
    }
}
