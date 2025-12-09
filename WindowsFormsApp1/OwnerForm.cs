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
    public partial class OwnerForm : Form
    {
        private int ownerId;
        private DataBase db = new DataBase(); // подключение к БД
        public OwnerForm(int id)
        {
            InitializeComponent();

            ownerId = id;
            LoadOwnerInfo();
        }
        private void LoadOwnerInfo()
        {
            db.openConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT ФИО FROM Владелец WHERE Id_Владельца = @Id",
                db.getConnection()
            );
            cmd.Parameters.AddWithValue("@Id", ownerId);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            // Заполняем текстбокс ФИО
            textBoxFio.Text = reader["ФИО"].ToString();

            reader.Close();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerDoverie ownerDoverie = new OwnerDoverie(ownerId);
            ownerDoverie.Show();
            this.Hide();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerFines ownerFines = new OwnerFines(ownerId);
            ownerFines.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OwnerTS ownerTS = new OwnerTS(ownerId);
            ownerTS.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
