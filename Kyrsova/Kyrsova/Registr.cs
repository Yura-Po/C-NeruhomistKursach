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
using System.Text.RegularExpressions;

namespace Kyrsova
{
    public partial class Registr : Form
    {
        private SqlConnection _connection;
        public Registr(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            UserName.Text = "Ім'я...";
            UserSurName.Text = "Прізвище...";
            UserFather.Text = "По-батькові...";
            UserTel.Text = "Номер телефону...";
            UserEmail.Text = "Email...";
            UserName.ForeColor = Color.Gray;
            UserSurName.ForeColor = Color.Gray;
            UserFather.ForeColor = Color.Gray;
            UserTel.ForeColor = Color.Gray;
            UserEmail.ForeColor = Color.Gray;
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm(_connection);
            MainForm.Show();
        }
        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }









        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "Ім'я...")
            {
                UserName.Text = "";
                UserName.ForeColor = Color.Black;
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Text = "Ім'я...";
                UserName.ForeColor = Color.Gray;
            }
        }

        private void UserSurName_Enter(object sender, EventArgs e)
        {
            if (UserSurName.Text == "Прізвище...")
            {
                UserSurName.Text = "";
                UserSurName.ForeColor = Color.Black;
            }
        }

        private void UserSurName_Leave(object sender, EventArgs e)
        {
            if (UserSurName.Text == "")
            {
                UserSurName.Text = "Прізвище...";
                UserSurName.ForeColor = Color.Gray;
            }
        }

        private void UserFather_Enter(object sender, EventArgs e)
        {
            if (UserFather.Text == "По-батькові...")
            {
                UserFather.Text = "";
                UserFather.ForeColor = Color.Black;
            }
        }

        private void UserFather_Leave(object sender, EventArgs e)
        {
            if (UserFather.Text == "")
            {
                UserFather.Text = "По-батькові...";
                UserFather.ForeColor = Color.Gray;
            }
        }

        private void UserTel_Enter(object sender, EventArgs e)
        {
            if (UserTel.Text == "Номер телефону...")
            {
                UserTel.Text = "";
                UserTel.ForeColor = Color.Black;
            }
        }

        private void UserTel_Leave(object sender, EventArgs e)
        {
            if (UserTel.Text == "")
            {
                UserTel.Text = "Номер телефону...";
                UserTel.ForeColor = Color.Gray;
            }
        }

        private void UserEmail_Enter(object sender, EventArgs e)
        {
            if (UserEmail.Text == "Email...")
            {
                UserEmail.Text = "";
                UserEmail.ForeColor = Color.Black;
            }
        }

        private void UserEmail_Leave(object sender, EventArgs e)
        {
            if (UserEmail.Text == "")
            {
                UserEmail.Text = "Email...";
                UserEmail.ForeColor = Color.Gray;
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (ValidateEmail(UserEmail.Text))
                {
                    if (CheckUniqueFields(UserTel.Text, UserEmail.Text))
                    {
                        try
                        {
                            string idClient = Guid.NewGuid().ToString();
                            string sql = "INSERT INTO Client (idClient, Surname, NameClient, Father, Fhone, Email) VALUES (@idClient, @Surname, @NameClient, @Father, @Fhone, @Email)";
                            SqlCommand cmd = new SqlCommand(sql, _connection);
                            cmd.Parameters.AddWithValue("@idClient", idClient);
                            cmd.Parameters.AddWithValue("@Surname", UserSurName.Text);
                            cmd.Parameters.AddWithValue("@NameClient", UserName.Text);
                            cmd.Parameters.AddWithValue("@Father", UserFather.Text);
                            cmd.Parameters.AddWithValue("@Fhone", UserTel.Text);
                            cmd.Parameters.AddWithValue("@Email", UserEmail.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Невірний формат Email!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            return !(UserName.Text == "Ім'я..." || UserSurName.Text == "Прізвище..." || UserFather.Text == "По-батькові..." ||
                     UserTel.Text == "Номер телефону..." || UserEmail.Text == "Email..." || UserName.Text == "" ||
                     UserSurName.Text == "" || UserFather.Text == "" || UserTel.Text == "" || UserEmail.Text == "");
        }

        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool CheckUniqueFields(string phone, string email)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Client WHERE Fhone = @Fhone OR Email = @Email";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@Fhone", phone);
                cmd.Parameters.AddWithValue("@Email", email);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Користувач з таким номером телефону або Email вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
