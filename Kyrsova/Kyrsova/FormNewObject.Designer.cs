namespace Kyrsova
{
    partial class FormNewObject
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
            panel5 = new Panel();
            ButtonSelectImage = new Button();
            labelNameimg = new Label();
            textBoxNameimg = new TextBox();
            buttonNew = new Button();
            panel4 = new Panel();
            textBoxOpis = new TextBox();
            labelOpis = new Label();
            panel3 = new Panel();
            textBoxAdresa = new TextBox();
            labelAdresa = new Label();
            textBoxTsena = new TextBox();
            labelTsena = new Label();
            textBoxPloshcha = new TextBox();
            labelPloshcha = new Label();
            textBoxKoef = new TextBox();
            labelKoef = new Label();
            comboBoxVlas = new ComboBox();
            labelSeVlas = new Label();
            comboBoxType = new ComboBox();
            labelType = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            close_Button = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 94);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(buttonNew);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 470);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(ButtonSelectImage);
            panel5.Controls.Add(labelNameimg);
            panel5.Controls.Add(textBoxNameimg);
            panel5.Location = new Point(300, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(488, 32);
            panel5.TabIndex = 5;
            // 
            // ButtonSelectImage
            // 
            ButtonSelectImage.Location = new Point(21, 5);
            ButtonSelectImage.Name = "ButtonSelectImage";
            ButtonSelectImage.Size = new Size(193, 23);
            ButtonSelectImage.TabIndex = 2;
            ButtonSelectImage.Text = "Обрати фото";
            ButtonSelectImage.UseVisualStyleBackColor = true;
            ButtonSelectImage.Click += ButtonSelectImage_Click;
            // 
            // labelNameimg
            // 
            labelNameimg.AutoSize = true;
            labelNameimg.Location = new Point(263, 12);
            labelNameimg.Name = "labelNameimg";
            labelNameimg.Size = new Size(80, 15);
            labelNameimg.TabIndex = 1;
            labelNameimg.Text = "Назва Файлу:";
            // 
            // textBoxNameimg
            // 
            textBoxNameimg.Location = new Point(349, 6);
            textBoxNameimg.Name = "textBoxNameimg";
            textBoxNameimg.ReadOnly = true;
            textBoxNameimg.Size = new Size(136, 23);
            textBoxNameimg.TabIndex = 0;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(321, 430);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(172, 32);
            buttonNew.TabIndex = 4;
            buttonNew.Text = "Створити!";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(textBoxOpis);
            panel4.Controls.Add(labelOpis);
            panel4.Location = new Point(12, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(779, 195);
            panel4.TabIndex = 3;
            // 
            // textBoxOpis
            // 
            textBoxOpis.Location = new Point(3, 24);
            textBoxOpis.Multiline = true;
            textBoxOpis.Name = "textBoxOpis";
            textBoxOpis.Size = new Size(770, 168);
            textBoxOpis.TabIndex = 13;
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOpis.Location = new Point(357, 0);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(61, 25);
            labelOpis.TabIndex = 12;
            labelOpis.Text = "Опис:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(textBoxAdresa);
            panel3.Controls.Add(labelAdresa);
            panel3.Controls.Add(textBoxTsena);
            panel3.Controls.Add(labelTsena);
            panel3.Controls.Add(textBoxPloshcha);
            panel3.Controls.Add(labelPloshcha);
            panel3.Controls.Add(textBoxKoef);
            panel3.Controls.Add(labelKoef);
            panel3.Controls.Add(comboBoxVlas);
            panel3.Controls.Add(labelSeVlas);
            panel3.Controls.Add(comboBoxType);
            panel3.Controls.Add(labelType);
            panel3.Location = new Point(12, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 193);
            panel3.TabIndex = 2;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(77, 129);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(174, 23);
            textBoxAdresa.TabIndex = 11;
            // 
            // labelAdresa
            // 
            labelAdresa.AutoSize = true;
            labelAdresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAdresa.Location = new Point(7, 131);
            labelAdresa.Name = "labelAdresa";
            labelAdresa.Size = new Size(64, 21);
            labelAdresa.TabIndex = 10;
            labelAdresa.Text = "Адреса:";
            // 
            // textBoxTsena
            // 
            textBoxTsena.Location = new Point(137, 100);
            textBoxTsena.Name = "textBoxTsena";
            textBoxTsena.Size = new Size(114, 23);
            textBoxTsena.TabIndex = 9;
            textBoxTsena.TextChanged += textBoxTsena_TextChanged;
            // 
            // labelTsena
            // 
            labelTsena.AutoSize = true;
            labelTsena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTsena.Location = new Point(7, 102);
            labelTsena.Name = "labelTsena";
            labelTsena.Size = new Size(124, 21);
            labelTsena.TabIndex = 8;
            labelTsena.Text = "Ціна за метр^2:";
            // 
            // textBoxPloshcha
            // 
            textBoxPloshcha.Location = new Point(141, 71);
            textBoxPloshcha.Name = "textBoxPloshcha";
            textBoxPloshcha.Size = new Size(110, 23);
            textBoxPloshcha.TabIndex = 7;
            // 
            // labelPloshcha
            // 
            labelPloshcha.AutoSize = true;
            labelPloshcha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPloshcha.Location = new Point(7, 73);
            labelPloshcha.Name = "labelPloshcha";
            labelPloshcha.Size = new Size(128, 21);
            labelPloshcha.TabIndex = 6;
            labelPloshcha.Text = "Загальна площа:";
            // 
            // textBoxKoef
            // 
            textBoxKoef.Enabled = false;
            textBoxKoef.Location = new Point(104, 167);
            textBoxKoef.Name = "textBoxKoef";
            textBoxKoef.Size = new Size(111, 23);
            textBoxKoef.TabIndex = 5;
            // 
            // labelKoef
            // 
            labelKoef.AutoSize = true;
            labelKoef.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelKoef.Location = new Point(7, 169);
            labelKoef.Name = "labelKoef";
            labelKoef.Size = new Size(91, 21);
            labelKoef.TabIndex = 4;
            labelKoef.Text = "Коефіцієнт:";
            // 
            // comboBoxVlas
            // 
            comboBoxVlas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVlas.FormattingEnabled = true;
            comboBoxVlas.Location = new Point(80, 38);
            comboBoxVlas.Name = "comboBoxVlas";
            comboBoxVlas.Size = new Size(171, 23);
            comboBoxVlas.TabIndex = 3;
            // 
            // labelSeVlas
            // 
            labelSeVlas.AutoSize = true;
            labelSeVlas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSeVlas.Location = new Point(3, 40);
            labelSeVlas.Name = "labelSeVlas";
            labelSeVlas.Size = new Size(71, 21);
            labelSeVlas.TabIndex = 2;
            labelSeVlas.Text = "Власник:";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(104, 9);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(147, 23);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelType.Location = new Point(3, 11);
            labelType.Name = "labelType";
            labelType.Size = new Size(95, 21);
            labelType.TabIndex = 0;
            labelType.Text = "Тип о'бєкта:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(300, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(close_Button);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 27);
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
            close_Button.Location = new Point(773, -3);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(27, 30);
            close_Button.TabIndex = 8;
            close_Button.Text = "X";
            close_Button.TextAlign = ContentAlignment.MiddleRight;
            close_Button.Click += close_Button_Click;
            close_Button.MouseEnter += close_Button_MouseEnter;
            close_Button.MouseLeave += close_Button_MouseLeave;
            // 
            // FormNewObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNewObject";
            Text = "FormNewObject";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label close_Button;
        private Panel panel3;
        private PictureBox pictureBox1;
        private ComboBox comboBoxVlas;
        private Label labelSeVlas;
        private ComboBox comboBoxType;
        private Label labelType;
        private TextBox textBoxKoef;
        private Label labelKoef;
        private TextBox textBoxTsena;
        private Label labelTsena;
        private TextBox textBoxPloshcha;
        private Label labelPloshcha;
        private TextBox textBoxAdresa;
        private Label labelAdresa;
        private Panel panel4;
        private TextBox textBoxOpis;
        private Label labelOpis;
        private Button buttonNew;
        private Panel panel5;
        private Label labelNameimg;
        private TextBox textBoxNameimg;
        private Button ButtonSelectImage;
    }
}