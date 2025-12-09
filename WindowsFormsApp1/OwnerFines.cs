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
    public partial class OwnerFines : Form
    {
        private DataBase db = new DataBase();
        private int ownerId;
        public OwnerFines(int id)
        {
            InitializeComponent();
            radioButton3.Checked = true;
            ownerId = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm(ownerId);
            ownerForm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                LoadFines("Оплачен");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                LoadFines("Не оплачен");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                LoadFines("Все");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void LoadFines(string status)
        {
            try
            {
             
                db.openConnection();

           
                SqlCommand command = new SqlCommand("ПолучитьШтрафы", db.getConnection());
                command.CommandType = CommandType.StoredProcedure;

               
                command.Parameters.AddWithValue("@Id_ТС", ownerId); 
                command.Parameters.AddWithValue("@Статус", status);

                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

               
                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                db.closeConnection();
            }
        }

        private void OwnerFines_Load_1(object sender, EventArgs e)
        {
            LoadFines("Все");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}