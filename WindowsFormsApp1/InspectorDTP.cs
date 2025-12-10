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
    public partial class InspectorDTP : Form
    {
        DataBase db = new DataBase(); // Создаём экземпляр твоего класса для работы с БД
        private int inspectorId;
        public InspectorDTP(int id)
        {
            InitializeComponent();
            inspectorId = id;

            // Событие нажатия Enter в TextBox
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDTPData();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void InspectorDTP_Load(object sender, EventArgs e)
        {
            // Можно оставить пустым или инициализировать данные при загрузке формы
        }

        private void LoadDTPData()
        {
            if (!int.TryParse(textBox1.Text, out int dtpId))
            {
                MessageBox.Show("Введите корректный номер ДТП.");
                return;
            }

            try
            {
                db.openConnection(); // открываем соединение

                using (SqlCommand cmd = new SqlCommand("GetДТППоId", db.getConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_ДТП", dtpId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection(); // закрываем соединение
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InspectorMainForm frm = new InspectorMainForm(inspectorId);
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           NewDTP newDTP = new NewDTP(inspectorId);
           newDTP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewParticipant newParticipant = new NewParticipant();
            newParticipant.Show();
        }
    }
}