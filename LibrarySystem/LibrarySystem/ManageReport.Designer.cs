namespace LibrarySystem
{
    partial class ManageReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReport));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 460);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(18, 169);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 6;
            button1.Text = "Manage Reports";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(22, 216);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 7;
            button2.Text = "User Management";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Aqua;
            button3.Location = new Point(34, 350);
            button3.Name = "button3";
            button3.Size = new Size(114, 39);
            button3.TabIndex = 8;
            button3.Text = "LOGOUT";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(197, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 256);
            panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(197, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 34);
            textBox1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(436, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(675, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 28);
            comboBox1.TabIndex = 16;
            // 
            // button4
            // 
            button4.BackColor = Color.Aqua;
            button4.Location = new Point(647, 403);
            button4.Name = "button4";
            button4.Size = new Size(114, 39);
            button4.TabIndex = 9;
            button4.Text = "Export";
            button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F);
            label6.Location = new Point(539, 16);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 22;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F);
            label5.Location = new Point(427, 14);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 21;
            label5.Text = "Time out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F);
            label4.Location = new Point(327, 14);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 20;
            label4.Text = "Time in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 7.8F);
            label3.Location = new Point(218, 14);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 19;
            label3.Text = "ID no.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F);
            label2.Location = new Point(117, 14);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 18;
            label2.Text = "Course";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F);
            label1.Location = new Point(27, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // ManageReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox3);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageReport";
            Text = "ManageReport";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private Button button4;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}