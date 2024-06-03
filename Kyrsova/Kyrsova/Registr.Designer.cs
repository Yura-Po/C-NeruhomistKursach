namespace Kyrsova
{
    partial class Registr
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
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            UserEmail = new TextBox();
            label6 = new Label();
            UserTel = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            UserFather = new TextBox();
            label4 = new Label();
            UserSurName = new TextBox();
            label3 = new Label();
            UserName = new TextBox();
            buttonRegister = new Button();
            panel2 = new Panel();
            close_Button = new Label();
            CloseButton = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(805, 55);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 94);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 390);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(UserEmail);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(UserTel);
            panel5.Location = new Point(407, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 212);
            panel5.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(9, 110);
            label7.Name = "label7";
            label7.Size = new Size(93, 29);
            label7.TabIndex = 10;
            label7.Text = "E-mail:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserEmail
            // 
            UserEmail.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserEmail.Location = new Point(3, 142);
            UserEmail.Multiline = true;
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(383, 64);
            UserEmail.TabIndex = 9;
            UserEmail.Enter += UserEmail_Enter;
            UserEmail.Leave += UserEmail_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(9, 7);
            label6.Name = "label6";
            label6.Size = new Size(196, 29);
            label6.TabIndex = 8;
            label6.Text = "Ном.Телефону:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserTel
            // 
            UserTel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserTel.Location = new Point(3, 40);
            UserTel.Multiline = true;
            UserTel.Name = "UserTel";
            UserTel.Size = new Size(383, 64);
            UserTel.TabIndex = 7;
            UserTel.Enter += UserTel_Enter;
            UserTel.Leave += UserTel_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(UserFather);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(UserSurName);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(UserName);
            panel4.Location = new Point(3, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(393, 311);
            panel4.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(7, 209);
            label5.Name = "label5";
            label5.Size = new Size(158, 29);
            label5.TabIndex = 8;
            label5.Text = "По Батькові:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserFather
            // 
            UserFather.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserFather.Location = new Point(7, 242);
            UserFather.Multiline = true;
            UserFather.Name = "UserFather";
            UserFather.Size = new Size(383, 64);
            UserFather.TabIndex = 7;
            UserFather.Enter += UserFather_Enter;
            UserFather.Leave += UserFather_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(7, 107);
            label4.Name = "label4";
            label4.Size = new Size(132, 29);
            label4.TabIndex = 6;
            label4.Text = "Прізвище:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserSurName
            // 
            UserSurName.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserSurName.Location = new Point(7, 142);
            UserSurName.Multiline = true;
            UserSurName.Name = "UserSurName";
            UserSurName.Size = new Size(383, 64);
            UserSurName.TabIndex = 5;
            UserSurName.Enter += UserSurName_Enter;
            UserSurName.Leave += UserSurName_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(7, 8);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 4;
            label3.Text = "Ім'я:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserName.Location = new Point(7, 40);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(383, 64);
            UserName.TabIndex = 3;
            UserName.Enter += UserName_Enter;
            UserName.Leave += UserName_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.AutoSize = true;
            buttonRegister.BackColor = Color.Silver;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderColor = Color.White;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = SystemColors.ControlLightLight;
            buttonRegister.Location = new Point(407, 312);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(393, 60);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Створити";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(close_Button);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 55);
            panel2.TabIndex = 0;
            // 
            // close_Button
            // 
            close_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_Button.Cursor = Cursors.Hand;
            close_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            close_Button.ForeColor = Color.FromArgb(54, 61, 94);
            close_Button.Location = new Point(778, 0);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(27, 30);
            close_Button.TabIndex = 6;
            close_Button.Text = "X";
            close_Button.TextAlign = ContentAlignment.MiddleRight;
            close_Button.Click += close_Button_Click;
            close_Button.MouseEnter += close_Button_MouseEnter;
            close_Button.MouseLeave += close_Button_MouseLeave;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.FromArgb(54, 61, 94);
            CloseButton.Location = new Point(994, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(27, 30);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Registr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 390);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registr";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button buttonRegister;
        private Panel panel2;
        private Label CloseButton;
        private Label close_Button;
        private Panel panel4;
        private TextBox UserName;
        private Label label4;
        private TextBox UserSurName;
        private Label label3;
        private Panel panel5;
        private Label label7;
        private TextBox UserEmail;
        private Label label6;
        private TextBox UserTel;
        private Label label5;
        private TextBox UserFather;
    }
}