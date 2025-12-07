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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            SqlCommand command = new SqlCommand("ДобавитьДоверенность", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;

            // Передаем только Id владельца, номер ВУ и госномер
            command.Parameters.AddWithValue("@Id_Владельца", 101); // Например, текущий владелец
            command.Parameters.AddWithValue("@Номер_ВУ_Водителя", textBox3.Text);
            command.Parameters.AddWithValue("@Гос_номер_ТС", textBox4.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Доверенность успешно создана");
            }

            textBox3.Clear();
            textBox4.Clear();

            dataBase.closeConnection();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OwnerDoverie ownerDoverie = new OwnerDoverie();
            ownerDoverie.Show();
            this.Hide();
        }
    }
}