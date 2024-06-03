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
using System.IO;

namespace Kyrsova
{
    public partial class NewDocumentForm : Form
    {
        private SqlConnection _connection;
        private string _selectedIdObject;

        public NewDocumentForm(SqlConnection connection, string selectedIdObject)
        {
            InitializeComponent();
            _connection = connection;
            _selectedIdObject = selectedIdObject;
            FillFormFields();
            LoadClientEmails(); // Завантаження електронних адрес клієнтів

            // Прив'язка методу до події SelectedIndexChanged
            comboBoxClient.SelectedIndexChanged += comboBoxClient_SelectedIndexChanged;
        }

        private void LoadClientEmails()
        {
            try
            {
                string sqlQuery = "SELECT Email FROM Client";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, _connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxClient.Items.Add(reader["Email"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні електронних адрес клієнтів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterClientEmails(string searchText)
        {
            try
            {
                string sqlQuery = "SELECT Email FROM Client WHERE Email LIKE @searchText";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBoxClient.Items.Clear();

                    while (reader.Read())
                    {
                        comboBoxClient.Items.Add(reader["Email"].ToString());
                    }

                    reader.Close();

                    // Показати випадаючий список після оновлення
                    if (comboBoxClient.Items.Count > 0)
                    {
                        comboBoxClient.DroppedDown = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при фільтрації електронних адрес клієнтів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillFormFields()
        {
            try
            {
                // SQL запит для отримання даних з таблиці Real_object
                string sqlRealObject = "SELECT * FROM Real_object WHERE idObject = @idObject";
                using (SqlCommand cmd = new SqlCommand(sqlRealObject, _connection))
                {
                    cmd.Parameters.AddWithValue("@idObject", _selectedIdObject);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxIdObj.Text = reader["idObject"].ToString();
                        labelPloshDB.Text = reader["Area"].ToString();
                        labelTsenaDB.Text = reader["PriceMeter"].ToString();
                        labelAdresDB.Text = reader["Adres"].ToString();

                        string idType = reader["idType"].ToString();
                        string idOwner = reader["idOwner"].ToString();
                        string fotoFileName = reader["Foto"].ToString();
                        string imagePath = Path.Combine(@"C:\Users\Юрец\Desktop\BD\Kyrsova\Kyrsova\image", fotoFileName);

                        // Завантаження зображення в pictureBox1
                        if (File.Exists(imagePath))
                        {
                            pictureBox1.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("Зображення не знайдено: " + imagePath, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();

                        // SQL запит для отримання даних з таблиці TypeObject
                        string sqlTypeObject = "SELECT TypeName, Coefficient FROM TypeObject WHERE idType = @idType";
                        using (SqlCommand cmdType = new SqlCommand(sqlTypeObject, _connection))
                        {
                            cmdType.Parameters.AddWithValue("@idType", idType);
                            reader = cmdType.ExecuteReader();

                            if (reader.Read())
                            {
                                labelNameTypeDB.Text = reader["TypeName"].ToString();
                                labelKoefDB.Text = reader["Coefficient"].ToString();
                            }
                            reader.Close();
                        }

                        // SQL запит для отримання даних з таблиці OwnerObject
                        string sqlOwnerObject = "SELECT Surname, NameOwner, Father, Fhone, Email FROM OwnerObject WHERE idOwner = @idOwner";
                        using (SqlCommand cmdOwner = new SqlCommand(sqlOwnerObject, _connection))
                        {
                            cmdOwner.Parameters.AddWithValue("@idOwner", idOwner);
                            reader = cmdOwner.ExecuteReader();

                            if (reader.Read())
                            {
                                labelVlasnikDB.Text = reader["Surname"].ToString();
                                labelVlasnikNameDB.Text = reader["NameOwner"].ToString();
                                labelVlasnikNameBatDB.Text = reader["Father"].ToString();
                                labelVlasTelDB.Text = reader["Fhone"].ToString();
                                labelVlasEmailDB.Text = reader["Email"].ToString();
                            }
                            reader.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено запис з idObject: " + _selectedIdObject, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                double coefficient, area, pricePerMeter;

                // Перевірка та отримання значень коефіцієнта, площі та ціни за метр
                if (double.TryParse(labelKoefDB.Text, out coefficient) &&
                    double.TryParse(labelPloshDB.Text, out area) &&
                    double.TryParse(labelTsenaDB.Text, out pricePerMeter))
                {
                    // Обчислення загальної ціни
                    double totalPrice = coefficient * area * pricePerMeter;
                    textBoxTsenaZagal.Text = totalPrice.ToString("F2"); ;
                }
                else
                {
                    MessageBox.Show("Некоректні дані для обчислення загальної ціни.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Point lastPoint;
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

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm(_connection);
            MainForm.Show();
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

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedItem != null)
                {
                    string selectedEmail = comboBoxClient.SelectedItem.ToString();

                    // SQL-запит для вибору даних клієнта за вибраним електронною адресою
                    string sqlQuery = "SELECT idClient, Surname, NameClient, Father,Email, Fhone FROM Client WHERE Email = @selectedEmail";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, _connection))
                    {
                        cmd.Parameters.AddWithValue("@selectedEmail", selectedEmail);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            textBoxClientSur.Text = reader["Surname"].ToString();
                            textBoxClientName.Text = reader["NameClient"].ToString();
                            textBoxClientFahter.Text = reader["Father"].ToString();
                            textBoxClientEmail.Text = reader["Email"].ToString();
                            textBoxClientFhone.Text = reader["Fhone"].ToString();
                            textBoxidClient.Text = reader["idClient"].ToString();
                            
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при виборі клієнта: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                string currentText = comboBoxClient.Text;
                int selectionStart = comboBoxClient.SelectionStart;

                comboBoxClient.Items.Clear();

                string newText = currentText.Insert(selectionStart, e.KeyChar.ToString());

                // Виконайте фільтрацію та заповнення варіантів для комбобокса на основі newText
                FilterClientEmails(newText);

                comboBoxClient.Text = newText;
                comboBoxClient.SelectionStart = selectionStart + 1;

                e.Handled = true;
            }
        }

        private void comboBoxClient_TextChanged(object sender, EventArgs e)
        {
            FilterClientEmails(comboBoxClient.Text.Trim());
        }

        private void buttonNewDocument_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdObj.Text) ||
        string.IsNullOrWhiteSpace(textBoxClientSur.Text) ||
        string.IsNullOrWhiteSpace(textBoxClientName.Text) ||
        string.IsNullOrWhiteSpace(textBoxClientFahter.Text) ||
        string.IsNullOrWhiteSpace(textBoxClientEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxClientFhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxTsenaZagal.Text) ||
        string.IsNullOrWhiteSpace(textBoxOpis.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля перед створенням нового документу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Перевіряє, чи вже існує клієнт з таким ID
                string clientCheckQuery = "SELECT COUNT(*) FROM Client WHERE idClient = @idClient";
                using (SqlCommand cmd = new SqlCommand(clientCheckQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("@idClient", textBoxidClient.Text);
                    int clientCount = (int)cmd.ExecuteScalar();

                    if (clientCount == 0)
                    {
                        // Якщо клієнта з таким ID не існує, створює нового клієнта
                        string clientInsertQuery = "INSERT INTO Client (idClient, Surname, NameClient, Father, Fhone, Email) VALUES (@idClient, @Surname, @NameClient, @Father, @Fhone, @Email)";
                        using (SqlCommand cmdInsert = new SqlCommand(clientInsertQuery, _connection))
                        {
                            cmdInsert.Parameters.AddWithValue("@idClient", textBoxidClient.Text);
                            cmdInsert.Parameters.AddWithValue("@Surname", textBoxClientSur.Text);
                            cmdInsert.Parameters.AddWithValue("@NameClient", textBoxClientName.Text);
                            cmdInsert.Parameters.AddWithValue("@Father", textBoxClientFahter.Text);
                            cmdInsert.Parameters.AddWithValue("@Fhone", textBoxClientFhone.Text);
                            cmdInsert.Parameters.AddWithValue("@Email", textBoxClientEmail.Text);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }

                // Перевіряє, чи вже існує власник з таким ID
                string ownerCheckQuery = "SELECT COUNT(*) FROM OwnerObject WHERE idOwner = @idOwner";
                using (SqlCommand cmd = new SqlCommand(ownerCheckQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("@idOwner", textBoxidClient.Text);
                    int ownerCount = (int)cmd.ExecuteScalar();

                    if (ownerCount == 0)
                    {
                        // Якщо власника з таким ID не існує, створює нового власника
                        string ownerInsertQuery = "INSERT INTO OwnerObject (idOwner, Surname, NameOwner, Father, Fhone, Email) VALUES (@idOwner, @Surname, @NameOwner, @Father, @Fhone, @Email)";
                        using (SqlCommand cmdInsert = new SqlCommand(ownerInsertQuery, _connection))
                        {
                            cmdInsert.Parameters.AddWithValue("@idOwner", textBoxidClient.Text);
                            cmdInsert.Parameters.AddWithValue("@Surname", textBoxClientSur.Text);
                            cmdInsert.Parameters.AddWithValue("@NameOwner", textBoxClientName.Text);
                            cmdInsert.Parameters.AddWithValue("@Father", textBoxClientFahter.Text);
                            cmdInsert.Parameters.AddWithValue("@Fhone", textBoxClientFhone.Text);
                            cmdInsert.Parameters.AddWithValue("@Email", textBoxClientEmail.Text);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }

                // Отримати idOwner з таблиці Real_object
                string idOwner = null;
                string getOwnerQuery = "SELECT idOwner FROM Real_object WHERE idObject = @idObject";
                using (SqlCommand cmd = new SqlCommand(getOwnerQuery, _connection))
                {
                    cmd.Parameters.AddWithValue("@idObject", textBoxIdObj.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idOwner = reader["idOwner"].ToString();
                    }
                    reader.Close();
                }

                if (string.IsNullOrEmpty(idOwner))
                {
                    throw new Exception("idOwner not found for the selected Real_object.");
                }

                // Створення нового запису у таблиці Document
                string documentInsertQuery = "INSERT INTO Document (idDocument, idClient, Price, DateDocument, desObject, idOwner) VALUES (@idDocument, @idClient, @Price, @DateDocument, @desObject, @idOwner)";
                using (SqlCommand cmdInsert = new SqlCommand(documentInsertQuery, _connection))
                {
                    cmdInsert.Parameters.AddWithValue("@idDocument", Guid.NewGuid().ToString());
                    cmdInsert.Parameters.AddWithValue("@idClient", textBoxidClient.Text);
                    cmdInsert.Parameters.AddWithValue("@Price", decimal.Parse(textBoxTsenaZagal.Text));
                    cmdInsert.Parameters.AddWithValue("@DateDocument", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@desObject", textBoxOpis.Text);
                    cmdInsert.Parameters.AddWithValue("@idOwner", idOwner);
                    cmdInsert.ExecuteNonQuery();
                }

                // Оновлення таблиці Real_object
                string realObjectUpdateQuery = "UPDATE Real_object SET idOwner = @idOwner WHERE idObject = @idObject";
                using (SqlCommand cmdUpdate = new SqlCommand(realObjectUpdateQuery, _connection))
                {
                    cmdUpdate.Parameters.AddWithValue("@idOwner", textBoxidClient.Text);
                    cmdUpdate.Parameters.AddWithValue("@idObject", textBoxIdObj.Text);
                    cmdUpdate.ExecuteNonQuery();
                }

                MessageBox.Show("Новий документ успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при створенні нового документу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
