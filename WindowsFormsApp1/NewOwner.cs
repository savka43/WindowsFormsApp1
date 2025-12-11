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
                MessageBox.Show("Паспорт должен содержать ровно 10 цифр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("ДобавитьВладельца", db.getConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FIO", FIO.Text.Trim());
                    cmd.Parameters.AddWithValue("@BirthDate", Birthdate.Value);
                    cmd.Parameters.AddWithValue("@Passport", Passport.Text.Trim());

                    db.openConnection();
                    cmd.ExecuteNonQuery();
                    db.closeConnection();
                }

                MessageBox.Show("Владелец успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // Сообщение из RAISERROR
                MessageBox.Show(ex.Message, "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
            }
        }


       

        private void NewOwner_Load(object sender, EventArgs e)
        {

        }
    }
}
