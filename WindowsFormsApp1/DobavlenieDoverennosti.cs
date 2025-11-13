using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DobavlenieDoverennosti : Form
    {
        DataBase dataBase = new DataBase();

        public DobavlenieDoverennosti()
        {
            InitializeComponent();
        }

        private void DobavlenieDoverennosti_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataBase.openConnection();

            SqlCommand command = new SqlCommand("ДобавитьДоверенностьПоДанным", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;

     
            command.Parameters.AddWithValue("@ФИО_Владельца", "Иванов И.И.");
            command.Parameters.AddWithValue("@Паспорт_Владельца", textBox2.Text); 
            command.Parameters.AddWithValue("@ФИО_Водителя", textBox1.Text); 
            command.Parameters.AddWithValue("@Номер_ВУ_Водителя", textBox3.Text); 
            command.Parameters.AddWithValue("@Гос_номер_ТС", textBox4.Text); 
            command.Parameters.AddWithValue("@Дата_Выдачи", DateTime.Now);
            command.Parameters.AddWithValue("@Дата_Окончания", DateTime.Now.AddYears(1)); 

            command.ExecuteNonQuery();

            dataBase.closeConnection();

            MessageBox.Show("Доверенность успешно добавлена!");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerDoverie ownerDoverie = new OwnerDoverie();
            ownerDoverie.Show();
            this.Hide();
        }
    }
}