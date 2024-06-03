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
using DGVPrinterHelper;

namespace Kyrsova
{
    public partial class ZvitObjectForm : Form
    {
        private SqlConnection _connection;
        public ZvitObjectForm(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            FillDataGridView();
        }

        Point lastPoint;

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm(_connection);
            MainForm.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void buttonZvit_Click(object sender, EventArgs e)
        {
            var dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Звіт по всім обєктам нерухомості", dataGridView1);
        }

        private void FillDataGridView()
        {
            try
            {
                

                // SQL-запит для вибірки даних з таблиці Real_object
                string query = "SELECT * FROM Real_object";

                // Створення SqlDataAdapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, _connection);

                // Створення і заповнення DataTable
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                // Прив'язка DataTable до DataGridView
                dataGridView1.DataSource = dataTable;


                // Зміна назв стовпців і вирівнювання по центру
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns["idObject"].HeaderText = "Код об'єкту";
                dataGridView1.Columns["idObject"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["idObject"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["idType"].HeaderText = "Код типу об'єкту";
                dataGridView1.Columns["idType"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["idType"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["idOwner"].HeaderText = "Код Власника";
                dataGridView1.Columns["idOwner"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["idOwner"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["Area"].HeaderText = "Площа";
                dataGridView1.Columns["Area"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["Area"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["PriceMeter"].HeaderText = "Ціна за квадратний метр";
                dataGridView1.Columns["PriceMeter"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["PriceMeter"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["DescriptionObject"].HeaderText = "Опис об'єкта";
                dataGridView1.Columns["DescriptionObject"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["DescriptionObject"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["Adres"].HeaderText = "Адреса об'єкта";
                dataGridView1.Columns["Adres"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["Adres"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["Foto"].HeaderText = "Назва файлу фото";
                dataGridView1.Columns["Foto"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["Foto"].HeaderCell.Style = headerStyle;
            }
            catch (Exception ex)
            {
                // Обробка помилок
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        
    }
}
