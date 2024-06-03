namespace Kyrsova
{
    partial class LoginForm
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
            buttonVhod = new Button();
            passFild = new TextBox();
            LoginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CloseButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 61, 94);
            panel1.Controls.Add(buttonVhod);
            panel1.Controls.Add(passFild);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 330);
            panel1.TabIndex = 0;
            // 
            // buttonVhod
            // 
            buttonVhod.BackColor = Color.Silver;
            buttonVhod.Cursor = Cursors.Hand;
            buttonVhod.FlatAppearance.BorderColor = Color.White;
            buttonVhod.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            buttonVhod.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonVhod.FlatStyle = FlatStyle.Flat;
            buttonVhod.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonVhod.ForeColor = SystemColors.ControlLightLight;
            buttonVhod.Location = new Point(91, 261);
            buttonVhod.Name = "buttonVhod";
            buttonVhod.Size = new Size(313, 51);
            buttonVhod.TabIndex = 5;
            buttonVhod.Text = "Вхід";
            buttonVhod.UseVisualStyleBackColor = false;
            buttonVhod.Click += buttonVhod_Click;
            // 
            // passFild
            // 
            passFild.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passFild.Location = new Point(91, 182);
            passFild.Name = "passFild";
            passFild.Size = new Size(313, 57);
            passFild.TabIndex = 4;
            passFild.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(91, 91);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(313, 64);
            LoginField.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.castle;
            pictureBox2.Location = new Point(21, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(21, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 55);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.FromArgb(54, 61, 94);
            CloseButton.Location = new Point(389, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(27, 30);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.TextAlign = ContentAlignment.MiddleRight;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 55);
            label1.TabIndex = 0;
            label1.Text = "Авторизація";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(416, 330);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label CloseButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox passFild;
        private TextBox LoginField;
        private Button buttonVhod;
    }
}