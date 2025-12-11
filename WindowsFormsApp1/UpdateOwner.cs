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

        public int OwnerId { get; set; }
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
            try
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand("ОбновитьВладельца", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Владельца", OwnerId);
                cmd.Parameters.AddWithValue("@Паспорт", passporNUmber.Text.Trim());
                cmd.Parameters.AddWithValue("@ФИО", textFio.Text.Trim());
                cmd.Parameters.AddWithValue("@Дата_рождения", birthDate.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные владельца успешно обновлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить этого владельца?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand("УдалитьВладельца", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Паспорт", passporNUmber.Text.Trim());

                cmd.ExecuteNonQuery();

                // Если до сюда дошли без исключений → удаление реально прошло
                MessageBox.Show("Владелец успешно удалён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                // Любой RAISERROR попадёт сюда
                MessageBox.Show(ex.Message, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
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
