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
    public partial class LoginForm : Form
    {

        public static string getConnectionFile()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) +
            "\\DBConnectionString";
        }

        public static string getConnectionString(string connectionFile)
        {
            StreamReader rdr = new StreamReader(connectionFile);
            string connectionString = rdr.ReadToEnd();
            rdr.Close();
            return connectionString;
        }



        public LoginForm()
        {
            InitializeComponent();
            this.passFild.AutoSize = false;
            this.passFild.Size = new Size(this.passFild.Size.Width, 64);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(54, 61, 94);
            CloseButton.BackColor = Color.FromArgb(255, 192, 128);
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

        

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionFile = getConnectionFile();
                string connectionString = getConnectionString(connectionFile);
                string login = "User ID =" + LoginField.Text + ";";
                string pass = "Password =" + passFild.Text + "";
                connectionString = connectionString + login + pass;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                this.Hide();
                MainForm mainForm = new MainForm(connection);
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
