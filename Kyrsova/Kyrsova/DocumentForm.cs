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

namespace Kyrsova
{
    public partial class DocumentForm : Form
    {
        private SqlConnection _connection;
        private DataTable _documentDataTable;
        public DocumentForm(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadDocumentData();

            radioButtonDate.CheckedChanged += radioButtonDate_CheckedChanged;
            radioButtonTsena.CheckedChanged += radioButtonTsena_CheckedChanged;
            Search.TextChanged += Search_TextChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadDataGridView();
        }

        private void LoadDocumentData()
        {
            try
            {
                // SQL query to retrieve data from the Document table
                string sql = "SELECT * FROM Document";
                SqlCommand cmd = new SqlCommand(sql, _connection);

                // Execute the query and get the results
                SqlDataReader reader = cmd.ExecuteReader();

                // Create a DataTable to store the results
                _documentDataTable = new DataTable();
                _documentDataTable.Load(reader);

                // Close the SqlDataReader
                reader.Close();

                // Bind the DataTable to the dataGridView1
                dataGridView1.DataSource = _documentDataTable;

                // Hide all columns except the desired ones and set their headers
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Visible = false;
                }

                dataGridView1.Columns["Price"].Visible = true;
                dataGridView1.Columns["Price"].HeaderText = "Ціна";

                dataGridView1.Columns["DateDocument"].Visible = true;
                dataGridView1.Columns["DateDocument"].HeaderText = "Дата заключення договору";
                dataGridView1.Columns["DateDocument"].Width = 200; // Adjust column width

                dataGridView1.Columns["desObject"].Visible = true;
                dataGridView1.Columns["desObject"].HeaderText = "Текст договору";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilterAndSort()
        {
            if (_documentDataTable == null)
            {
                return; // Ensure _documentDataTable is not null
            }

            string filterExpression = string.Empty;
            string searchText = Search.Text.Trim().Replace("'", "''"); // Protect against SQL injection

            if (!string.IsNullOrEmpty(searchText) && searchText != "Пошук...")
            {
                foreach (DataColumn column in _documentDataTable.Columns)
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
            if (radioButtonDate.Checked)
            {
                sortExpression = "[DateDocument] ASC";
            }
            else if (radioButtonTsena.Checked)
            {
                sortExpression = "[Price] ASC";
            }

            DataView dv = _documentDataTable.DefaultView;
            dv.RowFilter = filterExpression;
            dv.Sort = sortExpression;

            dataGridView1.DataSource = dv;
        }


        Point lastPoint;
        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm(_connection);
            MainForm.Show();
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

        private void Search_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void radioButtonTsena_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                try
                {
                    // Навіть якщо стовпці приховані, ви все ще можете отримати їхні значення
                    string idOwner = dataGridView1.Rows[e.RowIndex].Cells["idOwner"].Value.ToString();
                    string idClient = dataGridView1.Rows[e.RowIndex].Cells["idClient"].Value.ToString();

                    LoadOwnerData(idOwner, "Owner");
                    LoadOwnerData(idClient, "Client");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Column Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadOwnerData(string idOwner, string type)
        {
            try
            {
                string sql = "SELECT Surname, NameOwner, Father, Fhone, Email FROM OwnerObject WHERE idOwner = @idOwner";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@idOwner", idOwner);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string surname = reader["Surname"].ToString();
                    string nameOwner = reader["NameOwner"].ToString();
                    string father = reader["Father"].ToString();
                    string phone = reader["Fhone"].ToString();
                    string email = reader["Email"].ToString();

                    if (type == "Owner")
                    {
                        labelVlasnikDB.Text = surname;
                        labelVlasnikNameDB.Text = nameOwner;
                        labelVlasnikNameBatDB.Text = father;
                        labelVlasTelDB.Text = phone;
                        labelVlasEmailDB.Text = email;
                    }
                    else if (type == "Client")
                    {
                        labeldiuch.Text = surname;
                        labeldiuchName.Text = nameOwner;
                        labeldiuchBat.Text = father;
                        labeldiuchTel.Text = phone;
                        labeldiuchEmail.Text = email;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримуємо idOwner і idClient з вибраного рядка
                string idOwner = dataGridView1.SelectedRows[0].Cells["idOwner"].Value.ToString();
                string idClient = dataGridView1.SelectedRows[0].Cells["idClient"].Value.ToString();

                // Підтвердження видалення
                var result = MessageBox.Show("Ви дійсно хочете видалити запис?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteRecord(idOwner, idClient);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть запис для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecord(string idOwner, string idClient)
        {
            string query = "DELETE FROM Document WHERE idOwner = @idOwner AND idClient = @idClient";

            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@idOwner", idOwner);
                command.Parameters.AddWithValue("@idClient", idClient);

                try
                {

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запис успішно видалено.", "Видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Оновити DataGridView
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Запис не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void LoadDataGridView()
        {
            string query = "SELECT * FROM Document"; // Змінити відповідно до вашого запиту
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            // Переконайтеся, що стовпці idOwner та idClient приховані
            dataGridView1.Columns["idOwner"].Visible = false;
            dataGridView1.Columns["idClient"].Visible = false;
        }

        // Викликати LoadDataGridView() у вашому конструкторі або методі завантаження форми
        private void DocumentForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void buttonzvit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZvitDocumentForm ZvitDocumentForm = new ZvitDocumentForm(_connection);
            ZvitDocumentForm.Show();
        }
    }
}
