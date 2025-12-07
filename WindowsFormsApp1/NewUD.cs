using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class NewUD : Form
    {
        private DataBase db = new DataBase();

        public NewUD()
        {
            InitializeComponent();
        }

        private void NewUD_Load(object sender, EventArgs e)
        {
            LoadCategories();

            // Привязываем событие изменения даты выдачи
            startDate.ValueChanged += StartDate_ValueChanged;

            // Устанавливаем дату окончания сразу при загрузке
            endDate.Value = startDate.Value.AddYears(10);
        }

        private void LoadCategories()
        {
            categoryLicense.Items.Clear();
            string[] categories = new string[]
            {
                "A", "A1", "A2", "B", "B1", "C", "C1", "D", "D1",
                "BE", "CE", "C1E", "DE", "D1E", "M", "Tm", "Tb"
            };

            foreach (var cat in categories)
                categoryLicense.Items.Add(cat);
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            // Автоматически выставляем дату окончания через 10 лет
            endDate.Value = startDate.Value.AddYears(10);
        }

        private bool ValidateForm()
        {
            // Проверка ФИО: Иванов И.И.
            string fioPattern = @"^[А-ЯЁ][а-яё]+ [А-ЯЁ]\.[А-ЯЁ]\.$";
            if (!Regex.IsMatch(name.Text.Trim(), fioPattern))
            {
                MessageBox.Show("ФИО должно быть в формате: Иванов И.И.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка возраста
            int age = DateTime.Now.Year - birthDate.Value.Year;
            if (birthDate.Value.Date > DateTime.Now.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("Возраст водителя должен быть не менее 18 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка выбора категории
            if (categoryLicense.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию водительского удостоверения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка номера ВУ
            if (string.IsNullOrWhiteSpace(numberDriverLicense.Text))
            {
                MessageBox.Show("Введите номер водительского удостоверения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            db.openConnection();

            SqlCommand cmd = new SqlCommand("ДобавитьВодителя", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ФИО", name.Text.Trim());
            cmd.Parameters.AddWithValue("@Дата_рождения", birthDate.Value.Date);
            cmd.Parameters.AddWithValue("@Номер_BY", numberDriverLicense.Text.Trim());
            cmd.Parameters.AddWithValue("@Дата_Выдачи", startDate.Value.Date);
            cmd.Parameters.AddWithValue("@Дата_Окончания", startDate.Value.Date.AddYears(10)); // дата окончания через 10 лет
            cmd.Parameters.AddWithValue("@Категория", categoryLicense.SelectedItem.ToString());

            SqlParameter returnParam = new SqlParameter("@ReturnVal", SqlDbType.Int)
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnParam);

            cmd.ExecuteNonQuery(); // выполняем процедуру

            MessageBox.Show("Водитель успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.closeConnection();

            this.Close(); // закрываем форму
        }

     
    }
}