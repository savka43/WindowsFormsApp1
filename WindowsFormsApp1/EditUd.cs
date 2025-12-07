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
    public partial class EditUd : Form
    {
        private DataBase db = new DataBase();
        private int driverId;

   
        private string initialFio;
        private DateTime initialBirth;
        private string initialNumber;
        private DateTime initialStart;
        private DateTime initialEnd;
        private string initialCategory;

        public EditUd(int id, string fio, DateTime birth, string number, DateTime start, DateTime end, string category)
        {
            InitializeComponent();

            driverId = id;

            initialFio = fio;
            initialBirth = birth;
            initialNumber = number;
            initialStart = start;
            initialEnd = end;
            initialCategory = category;

            LoadDataToForm();

           
            string[] categories = new string[]
            {
                "A", "A1", "A2", "B", "B1", "C", "C1", "D", "D1",
                "BE", "CE", "C1E", "DE", "D1E", "M", "Tm", "Tb"
            };
            categoryLicense.Items.AddRange(categories);

            if (!string.IsNullOrEmpty(initialCategory))
                categoryLicense.SelectedItem = initialCategory;

         
            ResetButton.Click += ResetButton_Click;
        }

        private void EditUd_Load(object sender, EventArgs e)
        {
     
        }

        private void LoadDataToForm()
        {
            name.Text = initialFio;
            birthDate.Value = initialBirth;
            numberDriverLicense.Text = initialNumber;
            startDate.Value = initialStart;
            endDate.Value = initialEnd;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try { 
           
                if (birthDate.Value > DateTime.Today.AddYears(-18))
                {
                    MessageBox.Show("Возраст водителя должен быть не меньше 18 лет!");
                    return;
                }

                if ((endDate.Value - startDate.Value).TotalDays <= 0)
                {
                    MessageBox.Show("Дата окончания должна быть позже даты выдачи!");
                    return;
                }

                if (categoryLicense.SelectedItem == null)
                {
                    MessageBox.Show("Выберите категорию!");
                    return;
                }

      
                SqlCommand cmd = new SqlCommand("ОбновитьВодителя", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Водителя", driverId);
                cmd.Parameters.AddWithValue("@ФИО", name.Text.Trim());
                cmd.Parameters.AddWithValue("@Дата_рождения", birthDate.Value.Date);
                cmd.Parameters.AddWithValue("@Номер_BY", numberDriverLicense.Text.Trim());
                cmd.Parameters.AddWithValue("@Дата_Выдачи", startDate.Value.Date);
                cmd.Parameters.AddWithValue("@Дата_Окончания", endDate.Value.Date);
                cmd.Parameters.AddWithValue("@Категория", categoryLicense.SelectedItem.ToString());

                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Данные успешно обновлены!");

   
                initialFio = name.Text;
                initialBirth = birthDate.Value;
                initialNumber = numberDriverLicense.Text;
                initialStart = startDate.Value;
                initialEnd = endDate.Value;
                initialCategory = categoryLicense.SelectedItem.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Вы действительно хотите удалить это удостоверение?",
                                          "Подтверждение удаления",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("УдалитьУдостоверение", db.getConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Водителя", driverId);

                    SqlParameter resultParam = new SqlParameter("@ResultMessage", SqlDbType.NVarChar, 200);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    db.openConnection();
                    cmd.ExecuteNonQuery();
                    db.closeConnection();

                
                    MessageBox.Show(resultParam.Value.ToString(), "Удаление удостоверения", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    if (resultParam.Value.ToString() == "Удостоверение успешно удалено.")
                    {
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка при удалении: " + ex.Message);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadDataToForm();

            if (!string.IsNullOrEmpty(initialCategory))
                categoryLicense.SelectedItem = initialCategory;
            else
                categoryLicense.SelectedIndex = -1;
        }
    }
}