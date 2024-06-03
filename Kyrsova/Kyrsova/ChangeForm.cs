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
    public partial class ChangeForm : Form
    {
        private SqlConnection _connection;
        private string _idObject;
        private DataTable _originalDataTable; // Змінна для зберігання оригінального DataTable
        private string selectedImagePath;
        public ChangeForm(SqlConnection connection, string idObject)
        {
            InitializeComponent();
            _connection = connection;
            _idObject = idObject;
            LoadData();
        }
        Point lastPoint;

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm(_connection);
            MainForm.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private void LoadData()
        {
            // Використовуйте _idObject для виконання SQL-запиту або заповнення полів форми
            textBoxIdObject.Text = _idObject;

            // Приклад виконання SQL-запиту для завантаження додаткових даних
            try
            {
                string sql = "SELECT * FROM Real_object WHERE idObject = @idObject";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@idObject", _idObject);


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Заповніть поля форми відповідно до отриманих даних

                    textBoxPloshcha.Text = reader["Area"].ToString();
                    textBoxTsena.Text = reader["PriceMeter"].ToString();
                    textBoxAdresa.Text = reader["Adres"].ToString();
                    textBoxOpis.Text = reader["DescriptionObject"].ToString();
                    // Інші поля форми

                    // Отримання назви файлу зі стовбчика "Foto"
                    string fileName = reader["Foto"].ToString();

                    // Побудова шляху до файлу зображення
                    string imagePath = @"C:\Users\Юрец\Desktop\BD\Kyrsova\Kyrsova\image\" + fileName;

                    // Встановлення тексту у textBoxNameimg
                    textBoxNameimg.Text = fileName;

                    // Завантаження зображення в pictureBox1
                    if (System.IO.File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Зображення не знайдено: " + imagePath, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChangeGo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE Real_object SET Area = @Area, PriceMeter = @PriceMeter, Adres = @Adres, DescriptionObject = @DescriptionObject, Foto = @Foto WHERE idObject = @idObject";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@Area", textBoxPloshcha.Text);
                cmd.Parameters.AddWithValue("@PriceMeter", textBoxTsena.Text);
                cmd.Parameters.AddWithValue("@Adres", textBoxAdresa.Text);
                cmd.Parameters.AddWithValue("@DescriptionObject", textBoxOpis.Text);
                cmd.Parameters.AddWithValue("@Foto", textBoxNameimg.Text);
                cmd.Parameters.AddWithValue("@idObject", _idObject);

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    string newFileName = Path.GetFileNameWithoutExtension(selectedImagePath) + "_" + Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
                    string newImagePath = Path.Combine(@"C:\Users\Юрец\Desktop\BD\Kyrsova\Kyrsova\image\", newFileName);
                    File.Copy(selectedImagePath, newImagePath);
                    textBoxNameimg.Text = newFileName;
                    cmd.Parameters["@Foto"].Value = newFileName;
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Дані успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
