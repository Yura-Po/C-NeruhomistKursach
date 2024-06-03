namespace Kyrsova
{
    partial class ZvitObjectForm
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
            close_Button = new Label();
            buttonZvit = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(close_Button);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // close_Button
            // 
            close_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_Button.Cursor = Cursors.Hand;
            close_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            close_Button.ForeColor = Color.FromArgb(54, 61, 94);
            close_Button.Location = new Point(773, -5);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(27, 30);
            close_Button.TabIndex = 8;
            close_Button.Text = "X";
            close_Button.TextAlign = ContentAlignment.MiddleRight;
            close_Button.Click += close_Button_Click;
            close_Button.MouseEnter += close_Button_MouseEnter;
            close_Button.MouseLeave += close_Button_MouseLeave;
            // 
            // buttonZvit
            // 
            buttonZvit.Dock = DockStyle.Top;
            buttonZvit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonZvit.Location = new Point(0, 25);
            buttonZvit.Name = "buttonZvit";
            buttonZvit.Size = new Size(800, 37);
            buttonZvit.TabIndex = 1;
            buttonZvit.Text = "Сформувати звіт!";
            buttonZvit.UseVisualStyleBackColor = true;
            buttonZvit.Click += buttonZvit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 388);
            dataGridView1.TabIndex = 2;
            // 
            // ZvitObjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonZvit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZvitObjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZvitObjectForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close_Button;
        private Button buttonZvit;
        private DataGridView dataGridView1;
    }
}