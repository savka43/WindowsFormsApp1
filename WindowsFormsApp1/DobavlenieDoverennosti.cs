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
        private int ownerId;
        public DobavlenieDoverennosti(int id)
        {
            InitializeComponent();
            ownerId = id;
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
            SqlConnection conn = dataBase.getConnection();

           
            conn.FireInfoMessageEventOnUserErrors = true;
            conn.InfoMessage += (s, ev) =>
            {
                MessageBox.Show(ev.Message, "Сообщение");
            };

            SqlCommand command = new SqlCommand("ДобавитьДоверенность", conn);
            command.CommandType = CommandType.StoredProcedure;

    
            command.Parameters.AddWithValue("@Id_Владельца", 101); 
            command.Parameters.AddWithValue("@ВУ_Водителя", textBox3.Text.Trim());
            command.Parameters.AddWithValue("@Гос_номер_ТС", textBox4.Text.Trim());

         
            command.ExecuteNonQuery();


   
            textBox3.Clear();
            textBox4.Clear();

            dataBase.closeConnection();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OwnerDoverie ownerDoverie = new OwnerDoverie(ownerId);
            ownerDoverie.Show();
            this.Hide();
        }
    }
}