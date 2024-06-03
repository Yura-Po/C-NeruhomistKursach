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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Kyrsova
{
    public partial class MainForm : Form
    {
        private SqlConnection _connection;
        private DataTable _originalDataTable; // Змінна для зберігання оригінального DataTable
        private string selectedIdObject; // Змінна для збереження idObject обраного рядка

        public MainForm(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;


            // Прив'язка обробників подій для радіокнопок
            radioButtonType.CheckedChanged += radioButtonType_CheckedChanged;
            radioButtonPloshcha.CheckedChanged += radioButtonPloshcha_CheckedChanged;
            radioButtonTsena.CheckedChanged += radioButtonTsena_CheckedChanged;

            // Прив'язка обробника подій для поля пошуку
            Search.TextChanged += Search_TextChanged;

            //-----------------------------------

            try
            {
                // SQL запит для отримання всієї інформації з таблиці Real_object
                string sql = "SELECT * FROM Real_object";
                SqlCommand cmd = new SqlCommand(sql, _connection);

                // Виконання запиту та отримання результатів
                SqlDataReader reader = cmd.ExecuteReader();

                // Створення DataTable для збереження результатів
                _originalDataTable = new DataTable();
                _originalDataTable.Load(reader);

                // Закриття SqlDataReader
                reader.Close();

                // Прив'язка DataTable до dataGridView1
                dataGridView1.DataSource = _originalDataTable;

                // Приховати всі стовпці, крім потрібних
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Visible = false;
                }

                // Показати лише потрібні стовпці та задати їх заголовки
                dataGridView1.Columns["Area"].Visible = true;
                dataGridView1.Columns["Area"].HeaderText = "Площа";

                dataGridView1.Columns["PriceMeter"].Visible = true;
                dataGridView1.Columns["PriceMeter"].HeaderText = "Ціна за м^2";

                dataGridView1.Columns["DescriptionObject"].Visible = true;
                dataGridView1.Columns["DescriptionObject"].HeaderText = "Опис";

                dataGridView1.Columns["Adres"].Visible = true;
                dataGridView1.Columns["Adres"].HeaderText = "Адреса";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //-----------------------------------
        }

        Point lastPoint;

        private void close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Leave(object sender, EventArgs e)
        {

        }

        private void Search_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void close_Button_MouseEnter(object sender, EventArgs e)
        {
            close_Button.ForeColor = Color.White;
            close_Button.BackColor = Color.Red;
        }

        private void close_Button_MouseLeave(object sender, EventArgs e)
        {
            close_Button.ForeColor = Color.FromArgb(54, 61, 94);
            close_Button.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void labelNew_MouseEnter(object sender, EventArgs e)
        {
            labelNew.ForeColor = Color.Gray;
        }

        private void labelNew_MouseLeave(object sender, EventArgs e)
        {
            labelNew.ForeColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewObject FormNewObject = new FormNewObject(_connection);
            FormNewObject.Show();
        }

        private void hide_button_MouseEnter(object sender, EventArgs e)
        {
            hide_button.ForeColor = Color.Black;
            hide_button.BackColor = Color.Gray;
        }

        private void hide_button_MouseLeave(object sender, EventArgs e)
        {
            hide_button.ForeColor = Color.FromArgb(54, 61, 94);
            hide_button.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void radioButtonType_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void radioButtonPloshcha_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void radioButtonTsena_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void ApplyFilterAndSort()
        {
            if (_originalDataTable == null)
            {
                return; // Переконайтесь, що _originalDataTable не є null
            }

            string filterExpression = string.Empty;
            string searchText = Search.Text.Trim().Replace("'", "''"); // Захист від SQL-ін'єкцій

            if (!string.IsNullOrEmpty(searchText) && searchText != "Пошук...")
            {
                foreach (DataColumn column in _originalDataTable.Columns)
                {
                    if (column.DataType == typeof(string))
                    {
                        if (filterExpression.Length > 0)
                        {
                            filterExpression += " OR ";
                        }
                        filterExpression += $"[{column.ColumnName}] LIKE '%{searchText}%'";
                    }
                }
            }

            string sortExpression = string.Empty;
            if (radioButtonType.Checked)
            {
                sortExpression = "[idType] ASC";
            }
            else if (radioButtonPloshcha.Checked)
            {
                sortExpression = "[Area] ASC";
            }
            else if (radioButtonTsena.Checked)
            {
                sortExpression = "[PriceMeter] ASC";
            }

            DataView dv = _originalDataTable.DefaultView;
            dv.RowFilter = filterExpression;
            dv.Sort = sortExpression;

            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                selectedIdObject = dataGridView1.Rows[e.RowIndex].Cells["idObject"].Value.ToString(); // Збереження idObject обраного рядка

                // Отримання значень з вибраного рядка
                string idType = dataGridView1.Rows[e.RowIndex].Cells["idType"].Value.ToString();

                // Виконання SQL запиту для отримання даних з таблиці TypeObject
                try
                {
                    string sql = "SELECT TypeName, Coefficient FROM TypeObject WHERE idType = @idType";
                    SqlCommand cmd = new SqlCommand(sql, _connection);
                    cmd.Parameters.AddWithValue("@idType", idType);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string typeName = reader["TypeName"].ToString();
                        string coefficient = reader["Coefficient"].ToString();

                        // Виведення значень в відповідні лейбли
                        labelNameTypeDB.Text = typeName;
                        labelKoefDB.Text = coefficient;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Отримання значень з вибраного рядка
                string idOwner = dataGridView1.Rows[e.RowIndex].Cells["idOwner"].Value.ToString();

                // Виконання SQL запиту для отримання даних з таблиці OwnerObject
                try
                {
                    string sql = "SELECT Surname, Fhone, Email, NameOwner, Father FROM OwnerObject WHERE idOwner = @idOwner";
                    SqlCommand cmd = new SqlCommand(sql, _connection);
                    cmd.Parameters.AddWithValue("@idOwner", idOwner);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string surname = reader["Surname"].ToString();
                        string phone = reader["Fhone"].ToString();
                        string email = reader["Email"].ToString();
                        string nameOwner = reader["NameOwner"].ToString();
                        string Father = reader["Father"].ToString();

                        // Виведення значень в відповідні лейбли
                        labelVlasnikDB.Text = surname;
                        labelVlasTelDB.Text = phone;
                        labelVlasEmailDB.Text = email;
                        labelVlasnikNameDB.Text = nameOwner;
                        labelVlasnikNameBatDB.Text = Father;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Отримання значень з вибраного рядка
                string area = dataGridView1.Rows[e.RowIndex].Cells["Area"].Value.ToString();
                string priceMeter = dataGridView1.Rows[e.RowIndex].Cells["PriceMeter"].Value.ToString();
                string address = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
                string description = dataGridView1.Rows[e.RowIndex].Cells["DescriptionObject"].Value.ToString();

                // Виведення значень в відповідні лейбли та текстове поле
                labelPloshDB.Text = area;
                labelTsenaDB.Text = priceMeter;
                labelAdresDB.Text = address;
                textBoxOpis.Text = description;

                // Отримання значення з стовпця Foto вибраного рядка
                string fotoFileName = dataGridView1.Rows[e.RowIndex].Cells["Foto"].Value.ToString();

                // Завантаження та відображення зображення
                try
                {
                    string imagePath = Path.Combine(@"C:\Users\Юрец\Desktop\BD\Kyrsova\Kyrsova\image", fotoFileName);
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null; // Якщо зображення не знайдено, очистіть PictureBox
                        MessageBox.Show("Зображення не знайдено: " + imagePath, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Зображення занадто велике або пошкоджене: " + fotoFileName, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Image = null; // Очистити PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedIdObject))
            {
                var result = MessageBox.Show("Ви дійсно бажаєте видалити даний запис з бази даних?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    DeleteRecordFromDatabase(selectedIdObject);
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    selectedIdObject = null; // Скидання змінної після видалення
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteRecordFromDatabase(string idObject)
        {
            try
            {

                string query = "DELETE FROM Real_object WHERE idObject = @idObject"; // Змінили на вашу таблицю та колонку idObject
                using (SqlCommand cmd = new SqlCommand(query, _connection))
                {
                    // Переконайтеся, що значення не є null або порожнім
                    if (!string.IsNullOrEmpty(idObject))
                    {
                        cmd.Parameters.AddWithValue("@idObject", idObject);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Помилка: idObject не може бути пустим або null.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні запису: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedIdObject = dataGridView1.SelectedRows[0].Cells["idObject"].Value.ToString();
                this.Hide();
                ChangeForm changeForm = new ChangeForm(_connection, selectedIdObject);
                changeForm.Show();
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рядок для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelNewClient_MouseEnter(object sender, EventArgs e)
        {
            labelNewClient.ForeColor = Color.Gray;
        }

        private void labelNewClient_MouseLeave(object sender, EventArgs e)
        {
            labelNewClient.ForeColor = Color.White;
        }

        private void labelNewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registr Registr = new Registr(_connection);
            Registr.Show();
        }

        private void labelDogovir_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentForm DocumentForm = new DocumentForm(_connection);
            DocumentForm.Show();
        }

        private void labelDogovir_MouseEnter(object sender, EventArgs e)
        {
            labelDogovir.ForeColor = Color.Gray;
        }

        private void labelDogovir_MouseLeave(object sender, EventArgs e)
        {
            labelDogovir.ForeColor = Color.White;
        }

        private void labelNewDogovir_MouseEnter(object sender, EventArgs e)
        {
            labelNewDogovir.ForeColor = Color.Gray;
        }

        private void labelNewDogovir_MouseLeave(object sender, EventArgs e)
        {
            labelNewDogovir.ForeColor = Color.White;
        }

        private void labelNewDogovir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримання значення idObject з обраного рядка
                string selectedIdObject = dataGridView1.SelectedRows[0].Cells["idObject"].Value.ToString();

                // Приховуємо поточну форму
                this.Hide();

                // Переходимо на нову форму, передаючи _connection і selectedIdObject
                NewDocumentForm newDocumentForm = new NewDocumentForm(_connection, selectedIdObject);
                newDocumentForm.Show();
            }
            else
            {
                // Виведення повідомлення про помилку, якщо жоден рядок не обраний
                MessageBox.Show("Будь ласка, оберіть рядок для створення нового документа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelZvit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZvitObjectForm ZvitObjectForm = new ZvitObjectForm(_connection);
            ZvitObjectForm.Show();
        }
    }
}


