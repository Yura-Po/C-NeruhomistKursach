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
    public partial class ZvitDocumentForm : Form
    {
        private SqlConnection _connection;
        public ZvitDocumentForm(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            FillDataGridView();
        }
        Point lastPoint;
        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentForm DocumentForm = new DocumentForm(_connection);
            DocumentForm.Show();
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
            dgvPrinter.CreateReport("Звіт по всім Документам", dataGridView1);
        }

        private void FillDataGridView()
        {
            try
            {


                // SQL-запит для вибірки даних з таблиці Real_object
                string query = "SELECT * FROM Document";

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

                dataGridView1.Columns["idDocument"].HeaderText = "Код Документу";
                dataGridView1.Columns["idDocument"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["idDocument"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["idClient"].HeaderText = "Код нового власника";
                dataGridView1.Columns["idClient"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["idClient"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["Price"].HeaderText = "Загальна ціна";
                dataGridView1.Columns["Price"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["Price"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["DateDocument"].HeaderText = "Дата заключення договору";
                dataGridView1.Columns["DateDocument"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["DateDocument"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["idOwner"].HeaderText = "Код попереднього власника";
                dataGridView1.Columns["idOwner"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["idOwner"].HeaderCell.Style = headerStyle;

                dataGridView1.Columns["desObject"].HeaderText = "Опис Документа";
                dataGridView1.Columns["desObject"].DefaultCellStyle = cellStyle;
                dataGridView1.Columns["desObject"].HeaderCell.Style = headerStyle;

                
            }
            catch (Exception ex)
            {
                // Обробка помилок
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
