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
    public partial class InspectorOwner : Form
    {
        DataBase db = new DataBase();

        public InspectorOwner()
        {
            InitializeComponent();
            SearchButton.Click += SearchButton_Click;
            ResetButton.Click += ResetButton_Click;
        }

        private void InspectorOwner_Load(object sender, EventArgs e)
        {
         
            LoadOwners();
     
            birthStart.Checked = false;
            BirthEnd.Checked = false;
        }

        private void LoadOwners(string fio = null, string passport = null, DateTime? birthFrom = null, DateTime? birthTo = null,
                                int? cars = null, int? trusts = null)
        {
            try
            {
                db.openConnection();

                using (SqlCommand cmd = new SqlCommand("ФильтрВладельцев", db.getConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ФИО", string.IsNullOrWhiteSpace(fio) ? (object)DBNull.Value : fio);
                    cmd.Parameters.AddWithValue("@Паспорт", string.IsNullOrWhiteSpace(passport) ? (object)DBNull.Value : passport);
                    cmd.Parameters.AddWithValue("@ДатаРождОт", birthFrom.HasValue ? (object)birthFrom.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ДатаРождДо", birthTo.HasValue ? (object)birthTo.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@КоличествоАвто", cars.HasValue ? (object)cars.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@КоличествоДоверенностей", trusts.HasValue ? (object)trusts.Value : DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["Id_Владельца"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int? cars = null;
            int? trusts = null;

      
            if (!string.IsNullOrWhiteSpace(numberofCars.Text))
            {
                if (int.TryParse(numberofCars.Text, out int carsVal))
                    cars = carsVal;
                else
                {
                    MessageBox.Show("Введите корректное число для количества авто!");
                    return;
                }
            }

            
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (int.TryParse(textBox2.Text, out int trustsVal))
                    trusts = trustsVal;
                else
                {
                    MessageBox.Show("Введите корректное число для количества доверенностей!");
                    return;
                }
            }

    
            DateTime? birthFrom = birthStart.Checked ? birthStart.Value.Date : (DateTime?)null;
            DateTime? birthTo = BirthEnd.Checked ? BirthEnd.Value.Date : (DateTime?)null;

            
            LoadOwners(
                fio: textBoxFIO.Text,
                passport: textBox1.Text,
                birthFrom: birthFrom,
                birthTo: birthTo,
                cars: cars,
                trusts: trusts
            );
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
      
            textBoxFIO.Clear();
            textBox1.Clear();
            numberofCars.Clear();
            textBox2.Clear();
            birthStart.Checked = false;
            BirthEnd.Checked = false;

            LoadOwners();
        }
        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InspectorMainForm inspectorMainForm = new InspectorMainForm();
            inspectorMainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewOwner newOwnerForm = new NewOwner();
            newOwnerForm.Show();
        }
    }
}