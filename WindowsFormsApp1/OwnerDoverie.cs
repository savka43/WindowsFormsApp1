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
    public partial class OwnerDoverie : Form
    {
        DataBase dataBase = new DataBase();
        private int currentDriverId = 101;

        public OwnerDoverie()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.Show();
            this.Hide();
        }

        private void OwnerDoverie_Load(object sender, EventArgs e)
        {
            LoadDoverenosti();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LoadDoverenosti();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LoadDoverenosti();
            }
        }

        private void LoadDoverenosti()
        {
            dataBase.openConnection();

            string procedureName = "ПолучитьДоверенностиВодителя";
            string tipDoverenosti = "";

            if (radioButton1.Checked)
            {
                tipDoverenosti = "received";
            }
            else if (radioButton2.Checked)
            {
                tipDoverenosti = "issued";
            }
            else
            {
                tipDoverenosti = "received";
                radioButton1.Checked = true;
            }

            using (SqlCommand command = new SqlCommand(procedureName, dataBase.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id_Водителя", SqlDbType.Int).Value = currentDriverId;
                command.Parameters.Add("@Тип_доверенности", SqlDbType.VarChar, 20).Value = tipDoverenosti;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

            dataBase.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DobavlenieDoverennosti dobavlenieDoverennosti = new DobavlenieDoverennosti();
            dobavlenieDoverennosti.Show();
            this.Hide();
        }
    }
}