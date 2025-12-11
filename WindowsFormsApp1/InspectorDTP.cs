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
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверка, что кликнули по строке, а не по заголовку
            if (e.RowIndex < 0) return;

            // Берем Id участника ДТП из строки (предположим, колонка называется "Id_Участник_ДТП")
            int selectedParticipantId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id_Участник_ДТП"].Value);

            // Первый диалог подтверждения
            if (MessageBox.Show("Вы действительно хотите удалить этого участника ДТП?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            // Второй диалог подтверждения
            if (MessageBox.Show("Вы уверены, что хотите окончательно удалить этого участника ДТП?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand("УдалитьУчастникаДТП", db.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Участник_ДТП", selectedParticipantId);

                // Подписка на InfoMessage для RAISERROR
                db.getConnection().InfoMessage += (s, ev) =>
                {
                    MessageBox.Show(ev.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };

                cmd.ExecuteNonQuery();

                MessageBox.Show("Участник ДТП успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Удаляем строку из DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            catch (SqlException ex)
            {
                string userMessage = "Произошла ошибка при удалении участника ДТП.";

                if (ex.Message.Contains("не найден"))
                    userMessage = "Участник ДТП не найден.";

                MessageBox.Show(userMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                db.closeConnection();
            }
        }


    }
}