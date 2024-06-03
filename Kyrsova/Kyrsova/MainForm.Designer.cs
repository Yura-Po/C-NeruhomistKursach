namespace Kyrsova
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonDelete = new Button();
            textBoxOpis = new TextBox();
            labelOpis = new Label();
            buttonChange = new Button();
            panel4 = new Panel();
            panel6 = new Panel();
            labelAdresDB = new Label();
            labelAdres = new Label();
            labelTsenaDB = new Label();
            labelTsena = new Label();
            labelPloshDB = new Label();
            labelPlosh = new Label();
            labelKoefDB = new Label();
            labelKoef = new Label();
            labelNameTypeDB = new Label();
            labelNameType = new Label();
            panel5 = new Panel();
            labelVlasnikNameBatDB = new Label();
            labelVlasnikNameDB = new Label();
            labelVlasEmailDB = new Label();
            labelVlasEmail = new Label();
            labelVlasTelDB = new Label();
            labelVlasTel = new Label();
            labelVlasnikDB = new Label();
            labelVlasnikInit = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            radioButtonTsena = new RadioButton();
            radioButtonPloshcha = new RadioButton();
            radioButtonType = new RadioButton();
            Search = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            labelNewDogovir = new Label();
            labelDogovir = new Label();
            labelNewClient = new Label();
            hide_button = new Label();
            labelNew = new Label();
            close_Button = new Label();
            labelZvit = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 94);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(textBoxOpis);
            panel1.Controls.Add(labelOpis);
            panel1.Controls.Add(buttonChange);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 450);
            panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(483, 406);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(305, 32);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Видалити запис!";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxOpis
            // 
            textBoxOpis.Location = new Point(794, 61);
            textBoxOpis.Multiline = true;
            textBoxOpis.Name = "textBoxOpis";
            textBoxOpis.ReadOnly = true;
            textBoxOpis.Size = new Size(284, 339);
            textBoxOpis.TabIndex = 8;
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOpis.ForeColor = Color.FromArgb(255, 192, 128);
            labelOpis.Location = new Point(902, 33);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(59, 25);
            labelOpis.TabIndex = 7;
            labelOpis.Text = "Опис";
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(794, 406);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(284, 32);
            buttonChange.TabIndex = 6;
            buttonChange.Text = "Внести зміни!";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(483, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 232);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(labelAdresDB);
            panel6.Controls.Add(labelAdres);
            panel6.Controls.Add(labelTsenaDB);
            panel6.Controls.Add(labelTsena);
            panel6.Controls.Add(labelPloshDB);
            panel6.Controls.Add(labelPlosh);
            panel6.Controls.Add(labelKoefDB);
            panel6.Controls.Add(labelKoef);
            panel6.Controls.Add(labelNameTypeDB);
            panel6.Controls.Add(labelNameType);
            panel6.Location = new Point(3, 91);
            panel6.Name = "panel6";
            panel6.Size = new Size(299, 137);
            panel6.TabIndex = 7;
            // 
            // labelAdresDB
            // 
            labelAdresDB.AutoSize = true;
            labelAdresDB.Location = new Point(58, 108);
            labelAdresDB.Name = "labelAdresDB";
            labelAdresDB.Size = new Size(10, 15);
            labelAdresDB.TabIndex = 13;
            labelAdresDB.Text = ".";
            // 
            // labelAdres
            // 
            labelAdres.AutoSize = true;
            labelAdres.Location = new Point(3, 108);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(49, 15);
            labelAdres.TabIndex = 12;
            labelAdres.Text = "Адреса:";
            // 
            // labelTsenaDB
            // 
            labelTsenaDB.AutoSize = true;
            labelTsenaDB.Location = new Point(155, 83);
            labelTsenaDB.Name = "labelTsenaDB";
            labelTsenaDB.Size = new Size(10, 15);
            labelTsenaDB.TabIndex = 11;
            labelTsenaDB.Text = ".";
            // 
            // labelTsena
            // 
            labelTsena.AutoSize = true;
            labelTsena.Location = new Point(3, 83);
            labelTsena.Name = "labelTsena";
            labelTsena.Size = new Size(146, 15);
            labelTsena.TabIndex = 10;
            labelTsena.Text = "Ціна за Квадратний метр:";
            // 
            // labelPloshDB
            // 
            labelPloshDB.AutoSize = true;
            labelPloshDB.Location = new Point(58, 58);
            labelPloshDB.Name = "labelPloshDB";
            labelPloshDB.Size = new Size(10, 15);
            labelPloshDB.TabIndex = 9;
            labelPloshDB.Text = ".";
            // 
            // labelPlosh
            // 
            labelPlosh.AutoSize = true;
            labelPlosh.Location = new Point(3, 58);
            labelPlosh.Name = "labelPlosh";
            labelPlosh.Size = new Size(50, 15);
            labelPlosh.TabIndex = 8;
            labelPlosh.Text = "Площа:";
            // 
            // labelKoefDB
            // 
            labelKoefDB.AutoSize = true;
            labelKoefDB.Location = new Point(79, 34);
            labelKoefDB.Name = "labelKoefDB";
            labelKoefDB.Size = new Size(10, 15);
            labelKoefDB.TabIndex = 7;
            labelKoefDB.Text = ".";
            // 
            // labelKoef
            // 
            labelKoef.AutoSize = true;
            labelKoef.Location = new Point(3, 34);
            labelKoef.Name = "labelKoef";
            labelKoef.Size = new Size(70, 15);
            labelKoef.TabIndex = 6;
            labelKoef.Text = "Коефіцієнт:";
            // 
            // labelNameTypeDB
            // 
            labelNameTypeDB.AutoSize = true;
            labelNameTypeDB.Location = new Point(38, 9);
            labelNameTypeDB.Name = "labelNameTypeDB";
            labelNameTypeDB.Size = new Size(10, 15);
            labelNameTypeDB.TabIndex = 5;
            labelNameTypeDB.Text = ".";
            // 
            // labelNameType
            // 
            labelNameType.AutoSize = true;
            labelNameType.Location = new Point(3, 9);
            labelNameType.Name = "labelNameType";
            labelNameType.Size = new Size(30, 15);
            labelNameType.TabIndex = 4;
            labelNameType.Text = "Тип:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(labelVlasnikNameBatDB);
            panel5.Controls.Add(labelVlasnikNameDB);
            panel5.Controls.Add(labelVlasEmailDB);
            panel5.Controls.Add(labelVlasEmail);
            panel5.Controls.Add(labelVlasTelDB);
            panel5.Controls.Add(labelVlasTel);
            panel5.Controls.Add(labelVlasnikDB);
            panel5.Controls.Add(labelVlasnikInit);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(299, 82);
            panel5.TabIndex = 6;
            // 
            // labelVlasnikNameBatDB
            // 
            labelVlasnikNameBatDB.AutoSize = true;
            labelVlasnikNameBatDB.Location = new Point(202, 9);
            labelVlasnikNameBatDB.Name = "labelVlasnikNameBatDB";
            labelVlasnikNameBatDB.Size = new Size(10, 15);
            labelVlasnikNameBatDB.TabIndex = 11;
            labelVlasnikNameBatDB.Text = ".";
            // 
            // labelVlasnikNameDB
            // 
            labelVlasnikNameDB.AutoSize = true;
            labelVlasnikNameDB.Location = new Point(139, 9);
            labelVlasnikNameDB.Name = "labelVlasnikNameDB";
            labelVlasnikNameDB.Size = new Size(10, 15);
            labelVlasnikNameDB.TabIndex = 10;
            labelVlasnikNameDB.Text = ".";
            // 
            // labelVlasEmailDB
            // 
            labelVlasEmailDB.AutoSize = true;
            labelVlasEmailDB.Location = new Point(48, 58);
            labelVlasEmailDB.Name = "labelVlasEmailDB";
            labelVlasEmailDB.Size = new Size(10, 15);
            labelVlasEmailDB.TabIndex = 9;
            labelVlasEmailDB.Text = ".";
            // 
            // labelVlasEmail
            // 
            labelVlasEmail.AutoSize = true;
            labelVlasEmail.Location = new Point(3, 58);
            labelVlasEmail.Name = "labelVlasEmail";
            labelVlasEmail.Size = new Size(39, 15);
            labelVlasEmail.TabIndex = 8;
            labelVlasEmail.Text = "Email:";
            // 
            // labelVlasTelDB
            // 
            labelVlasTelDB.AutoSize = true;
            labelVlasTelDB.Location = new Point(38, 34);
            labelVlasTelDB.Name = "labelVlasTelDB";
            labelVlasTelDB.Size = new Size(10, 15);
            labelVlasTelDB.TabIndex = 7;
            labelVlasTelDB.Text = ".";
            // 
            // labelVlasTel
            // 
            labelVlasTel.AutoSize = true;
            labelVlasTel.Location = new Point(3, 34);
            labelVlasTel.Name = "labelVlasTel";
            labelVlasTel.Size = new Size(29, 15);
            labelVlasTel.TabIndex = 6;
            labelVlasTel.Text = "Тел:";
            // 
            // labelVlasnikDB
            // 
            labelVlasnikDB.AutoSize = true;
            labelVlasnikDB.Location = new Point(65, 9);
            labelVlasnikDB.Name = "labelVlasnikDB";
            labelVlasnikDB.Size = new Size(10, 15);
            labelVlasnikDB.TabIndex = 5;
            labelVlasnikDB.Text = ".";
            // 
            // labelVlasnikInit
            // 
            labelVlasnikInit.AutoSize = true;
            labelVlasnikInit.Location = new Point(3, 9);
            labelVlasnikInit.Name = "labelVlasnikInit";
            labelVlasnikInit.Size = new Size(56, 15);
            labelVlasnikInit.TabIndex = 4;
            labelVlasnikInit.Text = "Власник:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(radioButtonTsena);
            panel3.Controls.Add(radioButtonPloshcha);
            panel3.Controls.Add(radioButtonType);
            panel3.Controls.Add(Search);
            panel3.Location = new Point(12, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 30);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.lupa;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(18, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // radioButtonTsena
            // 
            radioButtonTsena.AutoSize = true;
            radioButtonTsena.Location = new Point(385, 7);
            radioButtonTsena.Name = "radioButtonTsena";
            radioButtonTsena.Size = new Size(64, 19);
            radioButtonTsena.TabIndex = 6;
            radioButtonTsena.TabStop = true;
            radioButtonTsena.Text = "По ціні";
            radioButtonTsena.UseVisualStyleBackColor = true;
            // 
            // radioButtonPloshcha
            // 
            radioButtonPloshcha.AutoSize = true;
            radioButtonPloshcha.Location = new Point(300, 7);
            radioButtonPloshcha.Name = "radioButtonPloshcha";
            radioButtonPloshcha.Size = new Size(79, 19);
            radioButtonPloshcha.TabIndex = 5;
            radioButtonPloshcha.TabStop = true;
            radioButtonPloshcha.Text = "По площі";
            radioButtonPloshcha.UseVisualStyleBackColor = true;
            // 
            // radioButtonType
            // 
            radioButtonType.AutoSize = true;
            radioButtonType.Location = new Point(225, 7);
            radioButtonType.Name = "radioButtonType";
            radioButtonType.Size = new Size(69, 19);
            radioButtonType.TabIndex = 4;
            radioButtonType.TabStop = true;
            radioButtonType.Text = "По типу";
            radioButtonType.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.Location = new Point(53, 3);
            Search.Name = "Search";
            Search.Size = new Size(166, 23);
            Search.TabIndex = 3;
            Search.TextChanged += Search_TextChanged;
            Search.Enter += Search_Enter;
            Search.Leave += Search_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(483, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(452, 361);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(labelZvit);
            panel2.Controls.Add(labelNewDogovir);
            panel2.Controls.Add(labelDogovir);
            panel2.Controls.Add(labelNewClient);
            panel2.Controls.Add(hide_button);
            panel2.Controls.Add(labelNew);
            panel2.Controls.Add(close_Button);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 27);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // labelNewDogovir
            // 
            labelNewDogovir.AutoSize = true;
            labelNewDogovir.Cursor = Cursors.Hand;
            labelNewDogovir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNewDogovir.ForeColor = Color.White;
            labelNewDogovir.Location = new Point(319, -3);
            labelNewDogovir.Name = "labelNewDogovir";
            labelNewDogovir.Size = new Size(167, 30);
            labelNewDogovir.TabIndex = 12;
            labelNewDogovir.Text = "Новий договір...";
            labelNewDogovir.Click += labelNewDogovir_Click;
            labelNewDogovir.MouseEnter += labelNewDogovir_MouseEnter;
            labelNewDogovir.MouseLeave += labelNewDogovir_MouseLeave;
            // 
            // labelDogovir
            // 
            labelDogovir.AutoSize = true;
            labelDogovir.Cursor = Cursors.Hand;
            labelDogovir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDogovir.ForeColor = Color.White;
            labelDogovir.Location = new Point(492, -1);
            labelDogovir.Name = "labelDogovir";
            labelDogovir.Size = new Size(122, 30);
            labelDogovir.TabIndex = 11;
            labelDogovir.Text = "Договори...";
            labelDogovir.Click += labelDogovir_Click;
            labelDogovir.MouseEnter += labelDogovir_MouseEnter;
            labelDogovir.MouseLeave += labelDogovir_MouseLeave;
            // 
            // labelNewClient
            // 
            labelNewClient.AutoSize = true;
            labelNewClient.Cursor = Cursors.Hand;
            labelNewClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNewClient.ForeColor = Color.White;
            labelNewClient.Location = new Point(160, -1);
            labelNewClient.Name = "labelNewClient";
            labelNewClient.Size = new Size(153, 30);
            labelNewClient.TabIndex = 10;
            labelNewClient.Text = "Новий клієнт...";
            labelNewClient.Click += labelNewClient_Click;
            labelNewClient.MouseEnter += labelNewClient_MouseEnter;
            labelNewClient.MouseLeave += labelNewClient_MouseLeave;
            // 
            // hide_button
            // 
            hide_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hide_button.Cursor = Cursors.Hand;
            hide_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            hide_button.ForeColor = Color.FromArgb(54, 61, 94);
            hide_button.Location = new Point(1026, -2);
            hide_button.Name = "hide_button";
            hide_button.Size = new Size(27, 30);
            hide_button.TabIndex = 9;
            hide_button.Text = "-";
            hide_button.TextAlign = ContentAlignment.MiddleRight;
            hide_button.Click += hide_button_Click;
            hide_button.MouseEnter += hide_button_MouseEnter;
            hide_button.MouseLeave += hide_button_MouseLeave;
            // 
            // labelNew
            // 
            labelNew.AutoSize = true;
            labelNew.Cursor = Cursors.Hand;
            labelNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNew.ForeColor = Color.White;
            labelNew.Location = new Point(0, -1);
            labelNew.Name = "labelNew";
            labelNew.Size = new Size(154, 30);
            labelNew.TabIndex = 8;
            labelNew.Text = "Новий об'єкт...";
            labelNew.Click += labelNew_Click;
            labelNew.MouseEnter += labelNew_MouseEnter;
            labelNew.MouseLeave += labelNew_MouseLeave;
            // 
            // close_Button
            // 
            close_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_Button.Cursor = Cursors.Hand;
            close_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            close_Button.ForeColor = Color.FromArgb(54, 61, 94);
            close_Button.Location = new Point(1053, -3);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(27, 30);
            close_Button.TabIndex = 7;
            close_Button.Text = "X";
            close_Button.TextAlign = ContentAlignment.MiddleRight;
            close_Button.Click += close_Button_Click;
            close_Button.MouseEnter += close_Button_MouseEnter;
            close_Button.MouseLeave += close_Button_MouseLeave;
            // 
            // labelZvit
            // 
            labelZvit.AutoSize = true;
            labelZvit.Cursor = Cursors.Hand;
            labelZvit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelZvit.ForeColor = Color.White;
            labelZvit.Location = new Point(620, -1);
            labelZvit.Name = "labelZvit";
            labelZvit.Size = new Size(200, 30);
            labelZvit.TabIndex = 13;
            labelZvit.Text = "Звіти по Об'єктам...";
            labelZvit.Click += labelZvit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label close_Button;
        private TextBox Search;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Label labelAdresDB;
        private Label labelAdres;
        private Label labelTsenaDB;
        private Label labelTsena;
        private Label labelPloshDB;
        private Label labelPlosh;
        private Label labelKoefDB;
        private Label labelKoef;
        private Label labelNameTypeDB;
        private Label labelNameType;
        private Panel panel5;
        private Label labelVlasEmailDB;
        private Label labelVlasEmail;
        private Label labelVlasTelDB;
        private Label labelVlasTel;
        private Label labelVlasnikDB;
        private Label labelVlasnikInit;
        private Button buttonChange;
        private Label labelNew;
        private Label hide_button;
        private RadioButton radioButtonType;
        private RadioButton radioButtonPloshcha;
        private RadioButton radioButtonTsena;
        private TextBox textBoxOpis;
        private Label labelOpis;
        private Label labelVlasnikNameDB;
        private Label labelVlasnikNameBatDB;
        private PictureBox pictureBox2;
        private Button buttonDelete;
        private Label labelNewClient;
        private Label labelDogovir;
        private Label labelNewDogovir;
        private Label labelZvit;
    }
}