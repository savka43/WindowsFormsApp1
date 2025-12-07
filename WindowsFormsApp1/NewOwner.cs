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
    public partial class NewOwner : Form
    {
        DataBase db = new DataBase();

        public NewOwner()
        {
            InitializeComponent();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FIO.Text))
            {
                MessageBox.Show("Введите ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Birthdate.Checked)
            {
                MessageBox.Show("Укажите дату рождения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Passport.Text))
            {
                MessageBox.Show("Введите номер паспорта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Passport.Text.Length != 10 || !Passport.Text.All(char.IsDigit))
            {
                MessageBox.Show("Паспорт должен содержать ровно 10 цифр!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string resultMessage = AddOwnerProcedure(
                FIO.Text.Trim(),
                Birthdate.Value,
                Passport.Text.Trim()
            );


            MessageBox.Show(resultMessage, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string AddOwnerProcedure(string fio, DateTime birthDate, string passport)
        {
            string result = "";

            using (SqlCommand cmd = new SqlCommand("ДобавитьВладельца", db.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FIO", fio);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Passport", passport);

            
                SqlParameter output = new SqlParameter("@ResultMessage", SqlDbType.NVarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                db.openConnection();
                cmd.ExecuteNonQuery();
                result = output.Value.ToString();
                db.closeConnection();
            }

            return result;
        }

        private void NewOwner_Load(object sender, EventArgs e)
        {

        }
    }
}
