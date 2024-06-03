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
    public partial class FormNewObject : Form
    {
        private SqlConnection _connection;
        private DataTable _originalDataTable; // Змінна для зберігання оригінального DataTable
        private string selectedImagePath;
        public FormNewObject(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            LoadComboBoxData();
            LoadComboBoxDataOwner();

        }
        Point lastPoint;

        private void LoadComboBoxData()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT idType, TypeName FROM TypeObject", _connection);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                comboBoxType.DataSource = dt;
                comboBoxType.DisplayMember = "TypeName";
                comboBoxType.ValueMember = "idType";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadComboBoxDataOwner()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT idOwner, Email FROM OwnerObject", _connection);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                comboBoxVlas.DataSource = dt;
                comboBoxVlas.DisplayMember = "Email";
                comboBoxVlas.ValueMember = "idOwner";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPloshcha.Text) ||
            string.IsNullOrEmpty(textBoxTsena.Text) ||
            string.IsNullOrEmpty(textBoxAdresa.Text) ||
            string.IsNullOrEmpty(textBoxKoef.Text) ||
            string.IsNullOrEmpty(textBoxNameimg.Text) ||
            string.IsNullOrEmpty(textBoxOpis.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                string destinationFolder = @"C:\Users\Юрец\Desktop\BD\Kyrsova\Kyrsova\image";
                string uniqueFileName = GenerateUniqueFileName(Path.GetFileName(selectedImagePath), destinationFolder);
                string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                File.Copy(selectedImagePath, destinationPath);

                
                    try
                    {
                    string uniqueIdObject = GenerateUniqueString(36);
                    string query = @"INSERT INTO Real_object 
                                     (idObject, idType, idOwner, Area, PriceMeter, DescriptionObject, Adres, Foto) 
                                     VALUES (@idObject, @idType, @idOwner, @Area, @PriceMeter, @DescriptionObject, @Adres, @Foto)";
                        SqlCommand cmd = new SqlCommand(query, _connection);
                    cmd.Parameters.AddWithValue("@idObject", uniqueIdObject);
                    cmd.Parameters.AddWithValue("@idType", comboBoxType.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@idOwner", comboBoxVlas.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Area", textBoxPloshcha.Text);
                    cmd.Parameters.AddWithValue("@PriceMeter", textBoxTsena.Text);
                    cmd.Parameters.AddWithValue("@DescriptionObject", textBoxOpis.Text);
                    cmd.Parameters.AddWithValue("@Adres", textBoxAdresa.Text);
                    cmd.Parameters.AddWithValue("@Foto", uniqueFileName);

                    cmd.ExecuteNonQuery();
                        MessageBox.Show("New record added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            
            else
            {
                MessageBox.Show("No image selected.");
            }
        }

        private string GenerateUniqueFileName(string originalFileName, string folderPath)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);
            string extension = Path.GetExtension(originalFileName);
            string newFileName = originalFileName;
            int counter = 1;

            while (File.Exists(Path.Combine(folderPath, newFileName)))
            {
                newFileName = $"{fileNameWithoutExtension}_{counter}{extension}";
                counter++;
            }

            return newFileName;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedValue != null && !(comboBoxType.SelectedValue is DataRowView))
            {
                if (int.TryParse(comboBoxType.SelectedValue.ToString(), out int selectedId))
                {
                    LoadCoefficient(selectedId);
                }
                else
                {
                    // Це повідомлення буде показано тільки якщо значення не можна конвертувати в int,
                    // що не має статися при правильних даних у базі даних
                    MessageBox.Show("Invalid selected value type.");
                }
            }
        }

        private void LoadCoefficient(int typeId)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Coefficient FROM TypeObject WHERE idType = @TypeId", _connection);
                cmd.Parameters.AddWithValue("@TypeId", typeId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    textBoxKoef.Text = result.ToString();
                }
                else
                {
                    textBoxKoef.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static string GenerateUniqueString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ButtonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    textBoxNameimg.Text = Path.GetFileName(selectedImagePath);
                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void textBoxTsena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
