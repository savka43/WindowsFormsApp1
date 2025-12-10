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
    public partial class InspectorUD : Form
    {
        DataBase db = new DataBase();
        private int inspectorId;
        public InspectorUD(int id)
        {
            InitializeComponent();

            inspectorId = id;

            this.dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void InspectorUD_Load(object sender, EventArgs e)
        {
            dateStart.Checked = false;
            dateEnd.Checked = false;
            LoadAllDrivers();
        }

        private void LoadAllDrivers()
        {
            SqlCommand cmd = new SqlCommand("ФильтрУдостоверений", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FIO", DBNull.Value);
            cmd.Parameters.AddWithValue("@Номер_BY", DBNull.Value);
            cmd.Parameters.AddWithValue("@ДатаОт", DBNull.Value);
            cmd.Parameters.AddWithValue("@ДатаДо", DBNull.Value);

            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.closeConnection();

            dataGridView1.DataSource = dt;

         
            if (dataGridView1.Columns.Contains("Id_Водителя"))
                dataGridView1.Columns["Id_Водителя"].Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ФильтрУдостоверений", db.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FIO", string.IsNullOrWhiteSpace(textFio.Text) ? (object)DBNull.Value : textFio.Text);
            cmd.Parameters.AddWithValue("@Номер_BY", string.IsNullOrWhiteSpace(textNumber.Text) ? (object)DBNull.Value : textNumber.Text);
            cmd.Parameters.AddWithValue("@ДатаОт", dateStart.Checked ? (object)dateStart.Value.Date : DBNull.Value);
            cmd.Parameters.AddWithValue("@ДатаДо", dateEnd.Checked ? (object)dateEnd.Value.Date : DBNull.Value);

            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.closeConnection();

            dataGridView1.DataSource = dt;

            if (dataGridView1.Columns.Contains("Id_Водителя"))
                dataGridView1.Columns["Id_Водителя"].Visible = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textFio.Text = "";
            textNumber.Text = "";
            dateStart.Value = DateTime.Today;
            dateEnd.Value = DateTime.Today;
            dateStart.Checked = false;
            dateEnd.Checked = false;

            LoadAllDrivers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InspectorMainForm inspectorMainForm = new InspectorMainForm(inspectorId);
            inspectorMainForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["Id_Водителя"].Value);
                string fio = row.Cells["ФИО"].Value.ToString();
                DateTime birth = Convert.ToDateTime(row.Cells["Дата_рождения"].Value);
                string number = row.Cells["Номер_BY"].Value.ToString();
                DateTime start = Convert.ToDateTime(row.Cells["Дата_Выдачи"].Value);
                DateTime end = Convert.ToDateTime(row.Cells["Дата_Окончания"].Value);
                string category = row.Cells["Категория"].Value.ToString();

                EditUd editForm = new EditUd(id, fio, birth, number, start, end, category);
                editForm.ShowDialog();

                LoadAllDrivers();
            }
        }

   
        private void label3_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            NewUD newUDForm = new NewUD();
            newUDForm.Show();
        }
    }
}