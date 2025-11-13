using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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

            const string DriverLogin = "Driver";
            const string DriverPassword = "123";

            const string OwnerLogin = "Owner";
            const string OwnerPassword = "321";

            const string InspectorLogin = "Inspector";
            const string InspectorPassword = "456";

            string enteredLogin = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if (enteredLogin == DriverLogin && enteredPassword == DriverPassword)
            {
                // Успешный вход как водитель
                try
                {
                    DriverMainForm driverForm = new DriverMainForm();
                    driverForm.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка: Невозможно найти форму 'DriverMainForm'. Убедитесь, что она создана.", "Критическая ошибка");
                }
            }
            else if (enteredLogin == OwnerLogin && enteredPassword == OwnerPassword)
            {
                // Успешный вход как владелец
                try
                {
                    OwnerForm ownerForm = new OwnerForm();
                    ownerForm.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка: Невозможно найти форму 'OwnerForm'. Убедитесь, что она создана.", "Критическая ошибка");
                }
            }
            else if (enteredLogin == InspectorLogin && enteredPassword == InspectorPassword)
            {
                // Успешный вход как инспектор
                try
                {
                    InspectorMainForm inspectorForm = new InspectorMainForm();
                    inspectorForm.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка: Невозможно найти форму 'InspectorMainForm'. Убедитесь, что она создана.", "Критическая ошибка");
                }
            }
            else
            {
                // Неуспешный вход
                MessageBox.Show("Неверный логин или пароль.", "Ошибка входа",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}