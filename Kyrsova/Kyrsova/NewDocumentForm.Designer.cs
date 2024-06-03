namespace Kyrsova
{
    partial class NewDocumentForm
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
            buttonNewDocument = new Button();
            panel7 = new Panel();
            textBoxidClient = new TextBox();
            textBoxOpis = new TextBox();
            labelOpis = new Label();
            panel3 = new Panel();
            textBoxTsenaZagal = new TextBox();
            labelDollar = new Label();
            labelTitle = new Label();
            comboBoxClient = new ComboBox();
            panel8 = new Panel();
            textBoxClientEmail = new TextBox();
            labelClientEmail = new Label();
            textBoxClientFhone = new TextBox();
            textBoxClientFahter = new TextBox();
            labelFatherClient = new Label();
            textBoxClientName = new TextBox();
            labelNameClient = new Label();
            textBoxClientSur = new TextBox();
            labelClientTel = new Label();
            labelClient = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            textBoxIdObj = new TextBox();
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
            panel2 = new Panel();
            close_Button = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 94);
            panel1.Controls.Add(buttonNewDocument);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 550);
            panel1.TabIndex = 0;
            // 
            // buttonNewDocument
            // 
            buttonNewDocument.Location = new Point(323, 503);
            buttonNewDocument.Name = "buttonNewDocument";
            buttonNewDocument.Size = new Size(355, 35);
            buttonNewDocument.TabIndex = 10;
            buttonNewDocument.Text = "Створити договір!";
            buttonNewDocument.UseVisualStyleBackColor = true;
            buttonNewDocument.Click += buttonNewDocument_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Controls.Add(textBoxidClient);
            panel7.Controls.Add(textBoxOpis);
            panel7.Controls.Add(labelOpis);
            panel7.Location = new Point(12, 303);
            panel7.Name = "panel7";
            panel7.Size = new Size(977, 195);
            panel7.TabIndex = 9;
            // 
            // textBoxidClient
            // 
            textBoxidClient.Location = new Point(3, 0);
            textBoxidClient.Name = "textBoxidClient";
            textBoxidClient.ReadOnly = true;
            textBoxidClient.Size = new Size(232, 23);
            textBoxidClient.TabIndex = 15;
            // 
            // textBoxOpis
            // 
            textBoxOpis.Location = new Point(3, 24);
            textBoxOpis.Multiline = true;
            textBoxOpis.Name = "textBoxOpis";
            textBoxOpis.Size = new Size(971, 168);
            textBoxOpis.TabIndex = 13;
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOpis.Location = new Point(453, 0);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(61, 25);
            labelOpis.TabIndex = 12;
            labelOpis.Text = "Опис:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(textBoxTsenaZagal);
            panel3.Controls.Add(labelDollar);
            panel3.Controls.Add(labelTitle);
            panel3.Controls.Add(comboBoxClient);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(684, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 263);
            panel3.TabIndex = 8;
            // 
            // textBoxTsenaZagal
            // 
            textBoxTsenaZagal.Location = new Point(6, 230);
            textBoxTsenaZagal.Name = "textBoxTsenaZagal";
            textBoxTsenaZagal.ReadOnly = true;
            textBoxTsenaZagal.Size = new Size(216, 23);
            textBoxTsenaZagal.TabIndex = 13;
            // 
            // labelDollar
            // 
            labelDollar.AutoSize = true;
            labelDollar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDollar.ForeColor = Color.White;
            labelDollar.Location = new Point(228, 223);
            labelDollar.Name = "labelDollar";
            labelDollar.Size = new Size(24, 30);
            labelDollar.TabIndex = 10;
            labelDollar.Text = "$";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 192);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(226, 30);
            labelTitle.TabIndex = 8;
            labelTitle.Text = "Загальна сума купівлі:";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(3, 4);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(299, 23);
            comboBoxClient.TabIndex = 7;
            comboBoxClient.SelectedIndexChanged += comboBoxClient_SelectedIndexChanged;
            comboBoxClient.TextChanged += comboBoxClient_TextChanged;
            comboBoxClient.KeyPress += comboBoxClient_KeyPress;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Controls.Add(textBoxClientEmail);
            panel8.Controls.Add(labelClientEmail);
            panel8.Controls.Add(textBoxClientFhone);
            panel8.Controls.Add(textBoxClientFahter);
            panel8.Controls.Add(labelFatherClient);
            panel8.Controls.Add(textBoxClientName);
            panel8.Controls.Add(labelNameClient);
            panel8.Controls.Add(textBoxClientSur);
            panel8.Controls.Add(labelClientTel);
            panel8.Controls.Add(labelClient);
            panel8.Location = new Point(3, 33);
            panel8.Name = "panel8";
            panel8.Size = new Size(299, 161);
            panel8.TabIndex = 6;
            // 
            // textBoxClientEmail
            // 
            textBoxClientEmail.Location = new Point(50, 104);
            textBoxClientEmail.Name = "textBoxClientEmail";
            textBoxClientEmail.ReadOnly = true;
            textBoxClientEmail.Size = new Size(236, 23);
            textBoxClientEmail.TabIndex = 14;
            // 
            // labelClientEmail
            // 
            labelClientEmail.AutoSize = true;
            labelClientEmail.Location = new Point(5, 107);
            labelClientEmail.Name = "labelClientEmail";
            labelClientEmail.Size = new Size(39, 15);
            labelClientEmail.TabIndex = 13;
            labelClientEmail.Text = "Email:";
            // 
            // textBoxClientFhone
            // 
            textBoxClientFhone.Location = new Point(40, 133);
            textBoxClientFhone.Name = "textBoxClientFhone";
            textBoxClientFhone.ReadOnly = true;
            textBoxClientFhone.Size = new Size(246, 23);
            textBoxClientFhone.TabIndex = 12;
            // 
            // textBoxClientFahter
            // 
            textBoxClientFahter.Location = new Point(84, 64);
            textBoxClientFahter.Name = "textBoxClientFahter";
            textBoxClientFahter.ReadOnly = true;
            textBoxClientFahter.Size = new Size(202, 23);
            textBoxClientFahter.TabIndex = 11;
            // 
            // labelFatherClient
            // 
            labelFatherClient.AutoSize = true;
            labelFatherClient.Location = new Point(3, 67);
            labelFatherClient.Name = "labelFatherClient";
            labelFatherClient.Size = new Size(75, 15);
            labelFatherClient.TabIndex = 10;
            labelFatherClient.Text = "По батькові:";
            // 
            // textBoxClientName
            // 
            textBoxClientName.Location = new Point(40, 35);
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.ReadOnly = true;
            textBoxClientName.Size = new Size(246, 23);
            textBoxClientName.TabIndex = 9;
            // 
            // labelNameClient
            // 
            labelNameClient.AutoSize = true;
            labelNameClient.Location = new Point(3, 38);
            labelNameClient.Name = "labelNameClient";
            labelNameClient.Size = new Size(31, 15);
            labelNameClient.TabIndex = 8;
            labelNameClient.Text = "Ім'я:";
            // 
            // textBoxClientSur
            // 
            textBoxClientSur.Location = new Point(73, 6);
            textBoxClientSur.Name = "textBoxClientSur";
            textBoxClientSur.ReadOnly = true;
            textBoxClientSur.Size = new Size(213, 23);
            textBoxClientSur.TabIndex = 7;
            // 
            // labelClientTel
            // 
            labelClientTel.AutoSize = true;
            labelClientTel.Location = new Point(5, 136);
            labelClientTel.Name = "labelClientTel";
            labelClientTel.Size = new Size(29, 15);
            labelClientTel.TabIndex = 6;
            labelClientTel.Text = "Тел:";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(3, 9);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(64, 15);
            labelClient.TabIndex = 4;
            labelClient.Text = "Прізвище:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(323, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(textBoxIdObj);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(12, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 263);
            panel4.TabIndex = 6;
            // 
            // textBoxIdObj
            // 
            textBoxIdObj.Location = new Point(3, 4);
            textBoxIdObj.Name = "textBoxIdObj";
            textBoxIdObj.ReadOnly = true;
            textBoxIdObj.Size = new Size(299, 23);
            textBoxIdObj.TabIndex = 8;
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
            panel6.Location = new Point(3, 121);
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
            panel5.Location = new Point(3, 33);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(close_Button);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 28);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // close_Button
            // 
            close_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_Button.Cursor = Cursors.Hand;
            close_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            close_Button.ForeColor = Color.FromArgb(54, 61, 94);
            close_Button.Location = new Point(973, -2);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(27, 30);
            close_Button.TabIndex = 9;
            close_Button.Text = "X";
            close_Button.TextAlign = ContentAlignment.MiddleRight;
            close_Button.Click += close_Button_Click;
            close_Button.MouseEnter += close_Button_MouseEnter;
            close_Button.MouseLeave += close_Button_MouseLeave;
            // 
            // NewDocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewDocumentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewDocumentForm";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label close_Button;
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
        private Label labelVlasnikNameBatDB;
        private Label labelVlasnikNameDB;
        private Label labelVlasEmailDB;
        private Label labelVlasEmail;
        private Label labelVlasTelDB;
        private Label labelVlasTel;
        private Label labelVlasnikDB;
        private Label labelVlasnikInit;
        private TextBox textBoxIdObj;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label labelTitle;
        private ComboBox comboBoxClient;
        private Panel panel8;
        private Label labelClientTel;
        private Label labelClient;
        private TextBox textBoxClientName;
        private Label labelNameClient;
        private TextBox textBoxClientSur;
        private TextBox textBoxTsenaZagal;
        private Label labelDollar;
        private TextBox textBoxClientFhone;
        private TextBox textBoxClientFahter;
        private Label labelFatherClient;
        private TextBox textBoxClientEmail;
        private Label labelClientEmail;
        private Button buttonNewDocument;
        private Panel panel7;
        private TextBox textBoxOpis;
        private Label labelOpis;
        private TextBox textBoxidClient;
    }
}