namespace Kyrsova
{
    partial class DocumentForm
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
            panel4 = new Panel();
            labelOldVlas = new Label();
            labelNewVlas = new Label();
            panel6 = new Panel();
            labeldiuchBat = new Label();
            labeldiuchName = new Label();
            labeldiuchEmail = new Label();
            label4 = new Label();
            labeldiuchTel = new Label();
            label6 = new Label();
            labeldiuch = new Label();
            label8 = new Label();
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
            radioButtonDate = new RadioButton();
            Search = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            close_Button = new Label();
            buttonzvit = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 94);
            panel1.Controls.Add(buttonzvit);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 450);
            panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(461, 269);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(305, 46);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Видалити запис!";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(labelOldVlas);
            panel4.Controls.Add(labelNewVlas);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(461, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 232);
            panel4.TabIndex = 7;
            // 
            // labelOldVlas
            // 
            labelOldVlas.AutoSize = true;
            labelOldVlas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOldVlas.ForeColor = Color.White;
            labelOldVlas.Location = new Point(68, 9);
            labelOldVlas.Name = "labelOldVlas";
            labelOldVlas.Size = new Size(159, 21);
            labelOldVlas.TabIndex = 10;
            labelOldVlas.Text = "Попередній власник:";
            // 
            // labelNewVlas
            // 
            labelNewVlas.AutoSize = true;
            labelNewVlas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNewVlas.ForeColor = Color.White;
            labelNewVlas.Location = new Point(86, 123);
            labelNewVlas.Name = "labelNewVlas";
            labelNewVlas.Size = new Size(129, 21);
            labelNewVlas.TabIndex = 9;
            labelNewVlas.Text = "Діючий власник:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(labeldiuchBat);
            panel6.Controls.Add(labeldiuchName);
            panel6.Controls.Add(labeldiuchEmail);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(labeldiuchTel);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(labeldiuch);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(3, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(299, 82);
            panel6.TabIndex = 7;
            // 
            // labeldiuchBat
            // 
            labeldiuchBat.AutoSize = true;
            labeldiuchBat.Location = new Point(202, 9);
            labeldiuchBat.Name = "labeldiuchBat";
            labeldiuchBat.Size = new Size(10, 15);
            labeldiuchBat.TabIndex = 11;
            labeldiuchBat.Text = ".";
            // 
            // labeldiuchName
            // 
            labeldiuchName.AutoSize = true;
            labeldiuchName.Location = new Point(139, 9);
            labeldiuchName.Name = "labeldiuchName";
            labeldiuchName.Size = new Size(10, 15);
            labeldiuchName.TabIndex = 10;
            labeldiuchName.Text = ".";
            // 
            // labeldiuchEmail
            // 
            labeldiuchEmail.AutoSize = true;
            labeldiuchEmail.Location = new Point(48, 58);
            labeldiuchEmail.Name = "labeldiuchEmail";
            labeldiuchEmail.Size = new Size(10, 15);
            labeldiuchEmail.TabIndex = 9;
            labeldiuchEmail.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 58);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // labeldiuchTel
            // 
            labeldiuchTel.AutoSize = true;
            labeldiuchTel.Location = new Point(38, 34);
            labeldiuchTel.Name = "labeldiuchTel";
            labeldiuchTel.Size = new Size(10, 15);
            labeldiuchTel.TabIndex = 7;
            labeldiuchTel.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 34);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 6;
            label6.Text = "Тел:";
            // 
            // labeldiuch
            // 
            labeldiuch.AutoSize = true;
            labeldiuch.Location = new Point(65, 9);
            labeldiuch.Name = "labeldiuch";
            labeldiuch.Size = new Size(10, 15);
            labeldiuch.TabIndex = 5;
            labeldiuch.Text = ".";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 4;
            label8.Text = "Ініціали:";
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
            panel5.Location = new Point(3, 36);
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
            labelVlasnikInit.Size = new Size(53, 15);
            labelVlasnikInit.TabIndex = 4;
            labelVlasnikInit.Text = "Ініціали:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(radioButtonTsena);
            panel3.Controls.Add(radioButtonDate);
            panel3.Controls.Add(Search);
            panel3.Location = new Point(3, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 30);
            panel3.TabIndex = 6;
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
            radioButtonTsena.Location = new Point(300, 7);
            radioButtonTsena.Name = "radioButtonTsena";
            radioButtonTsena.Size = new Size(64, 19);
            radioButtonTsena.TabIndex = 6;
            radioButtonTsena.TabStop = true;
            radioButtonTsena.Text = "По ціні";
            radioButtonTsena.UseVisualStyleBackColor = true;
            radioButtonTsena.CheckedChanged += radioButtonTsena_CheckedChanged;
            // 
            // radioButtonDate
            // 
            radioButtonDate.AutoSize = true;
            radioButtonDate.Location = new Point(225, 7);
            radioButtonDate.Name = "radioButtonDate";
            radioButtonDate.Size = new Size(66, 19);
            radioButtonDate.TabIndex = 4;
            radioButtonDate.TabStop = true;
            radioButtonDate.Text = "По Даті";
            radioButtonDate.UseVisualStyleBackColor = true;
            radioButtonDate.CheckedChanged += radioButtonDate_CheckedChanged;
            // 
            // Search
            // 
            Search.Location = new Point(53, 3);
            Search.Name = "Search";
            Search.Size = new Size(166, 23);
            Search.TabIndex = 3;
            Search.TextChanged += Search_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(452, 361);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(close_Button);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 27);
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
            close_Button.Location = new Point(743, -3);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(27, 30);
            close_Button.TabIndex = 8;
            close_Button.Text = "X";
            close_Button.TextAlign = ContentAlignment.MiddleRight;
            close_Button.Click += close_Button_Click;
            close_Button.MouseEnter += close_Button_MouseEnter;
            close_Button.MouseLeave += close_Button_MouseLeave;
            // 
            // buttonzvit
            // 
            buttonzvit.Location = new Point(462, 321);
            buttonzvit.Name = "buttonzvit";
            buttonzvit.Size = new Size(305, 46);
            buttonzvit.TabIndex = 11;
            buttonzvit.Text = "Створити звіт!";
            buttonzvit.UseVisualStyleBackColor = true;
            buttonzvit.Click += buttonzvit_Click;
            // 
            // DocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocumentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentForm";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label close_Button;
        private Panel panel3;
        private PictureBox pictureBox2;
        private RadioButton radioButtonTsena;
        private RadioButton radioButtonDate;
        private TextBox Search;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label labelOldVlas;
        private Label labelNewVlas;
        private Panel panel6;
        private Label labeldiuchBat;
        private Label labeldiuchName;
        private Label labeldiuchEmail;
        private Label label4;
        private Label labeldiuchTel;
        private Label label6;
        private Label labeldiuch;
        private Label label8;
        private Panel panel5;
        private Label labelVlasnikNameBatDB;
        private Label labelVlasnikNameDB;
        private Label labelVlasEmailDB;
        private Label labelVlasEmail;
        private Label labelVlasTelDB;
        private Label labelVlasTel;
        private Label labelVlasnikDB;
        private Label labelVlasnikInit;
        private Button buttonDelete;
        private Button buttonzvit;
    }
}