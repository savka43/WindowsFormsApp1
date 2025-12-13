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
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class addFines : Form
    {
        private DataBase db = new DataBase();

        public addFines()
        {
            InitializeComponent();
            LoadFineTypes();
            addButton.Click += AddButton_Click;
        }

        private void LoadFineTypes()
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Вид_штрафа FROM Штраф", db.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fineType.Items.Add(reader["Вид_штрафа"].ToString());
            }

            reader.Close();
            db.closeConnection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(plateNumber.Text))
            {
                MessageBox.Show("Введите госномер ТС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fineType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите вид правонарушения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.openConnection();
            SqlConnection connection = db.getConnection();

            // ✔ получение Id_ТС из таблицы ТС (все буквы русские)
            SqlCommand cmdGetId = new SqlCommand(
                "SELECT [Id_ТС] FROM [ТС] WHERE [Гос_номер] = @plate",
                connection
            );

            cmdGetId.Parameters.AddWithValue("@plate", plateNumber.Text.Trim());
            object result = cmdGetId.ExecuteScalar();

            if (result == null)
            {
                MessageBox.Show("ТС с таким госномером не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return;
            }

            int idTC = Convert.ToInt32(result);

            // Новый ID штрафа
            SqlCommand cmdNewId = new SqlCommand(
                "SELECT ISNULL(MAX([Id_Штрафа]), 0) + 1 FROM [Штраф]",
                connection
            );

            int newFineId = Convert.ToInt32(cmdNewId.ExecuteScalar());

            // Случайная сумма штрафа
            Random rnd = new Random();
            int amountValue = rnd.Next(100, 5001);

            // ✔ вставка штрафа с правильным Id_ТС
            SqlCommand cmdInsert = new SqlCommand(
                "INSERT INTO [Штраф] ([Id_Штрафа], [Id_ТС], [Вид_штрафа], [Сумма], [Дата_постановления], [Статус_оплаты]) " +
                "VALUES (@Id_Штрафа, @Id_ТС, @Вид_штрафа, @Сумма, @Дата_постановления, @Статус_оплаты)",
                connection
            );

            cmdInsert.Parameters.AddWithValue("@Id_Штрафа", newFineId);
            cmdInsert.Parameters.AddWithValue("@Id_ТС", idTC);   
            cmdInsert.Parameters.AddWithValue("@Вид_штрафа", fineType.SelectedItem.ToString());
            cmdInsert.Parameters.AddWithValue("@Сумма", amountValue);
            cmdInsert.Parameters.AddWithValue("@Дата_постановления", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@Статус_оплаты", "Не оплачен");

            cmdInsert.ExecuteNonQuery();

            MessageBox.Show(
                $"Штраф успешно добавлен!\nId штрафа: {newFineId}\nСумма: {amountValue} руб.",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            plateNumber.Clear();
            fineType.SelectedIndex = -1;

            db.closeConnection();
        }

        private void NewFines_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addFines_Load(object sender, EventArgs e)
        {
            // код при загрузке формы
        }
    }
}
