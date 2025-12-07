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
    public partial class Form1 : Form
    {
        private DataBase db = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginUser(string role, string message)
        {
            InputForm input = new InputForm(message);

            if (input.ShowDialog() != DialogResult.OK)
                return;

            string value = input.InputValue;

            db.openConnection();

            SqlCommand cmd = new SqlCommand("ЛогинПользователя", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@InputValue", value);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() && reader["Result"].ToString() == "OK")
            {
                int id = Convert.ToInt32(reader["UserId"]);
                db.closeConnection();

                // Открываем нужную форму
                switch (role)
                {
                    case "Driver":
                        DriverMainForm driver = new DriverMainForm();
                        driver.Show();
                        break;

                    case "Owner":
                        OwnerForm owner = new OwnerForm();
                        owner.Show();
                        break;

                    case "Inspector":
                        InspectorMainForm inspector = new InspectorMainForm();
                        inspector.Show();
                        break;
                }

                this.Hide();
                return;
            }

            db.closeConnection();
            MessageBox.Show("Данные не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            LoginUser("Driver", "Введите номер ВУ:");
        }

        private void ownerButton_Click(object sender, EventArgs e)
        {
            LoginUser("Owner", "Введите номер паспорта:");
        }

        private void inspectorButton_Click(object sender, EventArgs e)
        {
            LoginUser("Inspector", "Введите номер значка:");
        }
    }
}