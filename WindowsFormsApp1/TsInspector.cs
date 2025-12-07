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
    public partial class TsInspector : Form
    {
        DataBase db = new DataBase();
        public TsInspector()
        {
            InitializeComponent();

            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InspectorMainForm frm = new InspectorMainForm();
            frm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TsInspector_Load(object sender, EventArgs e)
        {
            LoadOffenseTypes();   
            LoadAllFines();     
        }
        private void LoadAllFines()
        {
            SqlCommand cmd = new SqlCommand("ФильтрШтрафовИнспектор", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Дата_постановления"].DisplayIndex = 0;

            db.closeConnection();
        }
        private void LoadOffenseTypes()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Вид_штрафа FROM Штраф", db.getConnection());

            db.openConnection();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                offense.Items.Add(reader["Вид_штрафа"].ToString());
            }

            reader.Close();
            db.closeConnection();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void unpaidradiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ФильтрШтрафовИнспектор", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

          
            if (dateTimePicker1.Checked)
                cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value);

            if (dateTimePicker2.Checked)
                cmd.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);

            if (!string.IsNullOrWhiteSpace(textboxVIN.Text))
                cmd.Parameters.AddWithValue("@VIN", textboxVIN.Text);

            if (!string.IsNullOrWhiteSpace(textboxnumber.Text))
                cmd.Parameters.AddWithValue("@LicenseNumber", textboxnumber.Text);

            if (!string.IsNullOrWhiteSpace(insertName.Text))
                cmd.Parameters.AddWithValue("@DriverName", insertName.Text);

            if (!string.IsNullOrWhiteSpace(insertCertificate.Text))
                cmd.Parameters.AddWithValue("@CertificateNumber", insertCertificate.Text);

            if (offense.SelectedItem != null)
                cmd.Parameters.AddWithValue("@OffenseType", offense.SelectedItem.ToString());

            if (Paidradiobutton.Checked)
                cmd.Parameters.AddWithValue("@PaymentStatus", "Оплачен");
            else if (unpaidradiobutton.Checked)
                cmd.Parameters.AddWithValue("@PaymentStatus", "Не оплачен");

            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addFines addFines = new addFines();
            addFines.Show();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            textboxVIN.Text = "";
            textboxnumber.Text = "";
            insertName.Text = "";
            insertCertificate.Text = "";


            offense.SelectedIndex = -1;

   
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;

  
            Paidradiobutton.Checked = false;
            unpaidradiobutton.Checked = false;

            LoadAllFines();

        }
    }
}
