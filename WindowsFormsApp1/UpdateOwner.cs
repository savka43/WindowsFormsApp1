using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UpdateOwner : Form
    {
        private DataBase db = new DataBase();

        // Свойства для передачи данных из InspectorOwner
        public string OwnerFIO { get; set; }
        public string OwnerPassport { get; set; }
        public DateTime OwnerBirthDate { get; set; }

        public UpdateOwner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Кнопка для заполнения полей
            textFio.Text = OwnerFIO;
            passporNUmber.Text = OwnerPassport;
            birthDate.Value = OwnerBirthDate;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            // Подписка на вывод PRINT из SQL как сообщения для пользователя
            db.getConnection().InfoMessage += (s, ev) =>
            {
                foreach (SqlError err in ev.Errors)
                {
                    MessageBox.Show(err.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            SqlCommand cmd = new SqlCommand("ОбновитьВладельца", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Паспорт", passporNUmber.Text.Trim());
            cmd.Parameters.AddWithValue("@ФИО", textFio.Text.Trim());
            cmd.Parameters.AddWithValue("@Дата_рождения", birthDate.Value.Date);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные владельца успешно обновлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Вы действительно хотите удалить этого владельца?",
       "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand("УдалитьВладельца", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Паспорт", passporNUmber.Text.Trim());

                // Здесь ExecuteScalar получает строку с сообщением об успешном удалении
                string message = (string)cmd.ExecuteScalar();

                MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                this.Close();
            }
        }

        private void UpdateOwner_Load(object sender, EventArgs e)
        {
            textFio.Text = OwnerFIO;
            passporNUmber.Text = OwnerPassport;
            birthDate.Value = OwnerBirthDate;
        }
    }
}
