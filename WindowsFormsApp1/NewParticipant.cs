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
    public partial class NewParticipant : Form
    {
        DataBase database = new DataBase();

        public NewParticipant()
        {
            InitializeComponent();

            FillComboBoxes();
            addButton.Click += AddButton_Click;
        }

        private void FillComboBoxes()
        {
       
            damage.Items.Add("Отсутствуют");
            damage.Items.Add("Минимальные");
            damage.Items.Add("Средние");
            damage.Items.Add("Серьезные");
            damage.Items.Add("Тотальные");

           
            guiltiness.Items.Add("Виновен");
            guiltiness.Items.Add("Не виновен");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string driverName = nameFIO.Text.Trim();
            string driverLicense = DriverLicense.Text.Trim();
            string carPlateNumber = carPlate.Text.Trim();
            string accidentIdText = numberOfProtocol.Text.Trim();
            string damageLevel = damage.SelectedItem?.ToString();
            string guiltinessText = guiltiness.SelectedItem?.ToString();

           
            if (string.IsNullOrWhiteSpace(driverName) ||
                string.IsNullOrWhiteSpace(driverLicense) ||
                string.IsNullOrWhiteSpace(carPlateNumber) ||
                string.IsNullOrWhiteSpace(accidentIdText) ||
                damageLevel == null ||
                guiltinessText == null)
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(accidentIdText, out int accidentId))
            {
                MessageBox.Show("Номер протокола должен быть числом.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                database.openConnection();

                SqlCommand cmd = new SqlCommand("ДобавитьУчастника", database.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DriverName", driverName);
                cmd.Parameters.AddWithValue("@DriverLicense", driverLicense);
                cmd.Parameters.AddWithValue("@CarNumber", carPlateNumber);
                cmd.Parameters.AddWithValue("@AccidentId", accidentId);
                cmd.Parameters.AddWithValue("@DamageLevel", damageLevel);
                cmd.Parameters.AddWithValue("@GuiltinessText", guiltinessText);

                SqlParameter resultParam = new SqlParameter("@ResultMessage", SqlDbType.NVarChar, 300)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                string resultMessage = resultParam.Value.ToString();

                MessageBox.Show(resultMessage, "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewParticipant_Load(object sender, EventArgs e)
        {

        }
    }
}