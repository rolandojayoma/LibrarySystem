namespace LibrarySystem
{
    partial class StudentTimeinTimeout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTimeinTimeout));
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(95, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 283);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(101, 152);
            button1.Name = "button1";
            button1.Size = new Size(407, 46);
            button1.TabIndex = 10;
            button1.Text = "Time in";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(101, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 38);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 47);
            label3.Name = "label3";
            label3.Size = new Size(324, 20);
            label3.TabIndex = 4;
            label3.Text = "Welcome, Student! Please enter your ID number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(147, 12);
            label5.Name = "label5";
            label5.Size = new Size(306, 35);
            label5.TabIndex = 3;
            label5.Text = "Jose Maria College Library";
            label5.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(335, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(101, 204);
            button2.Name = "button2";
            button2.Size = new Size(407, 46);
            button2.TabIndex = 11;
            button2.Text = "Time out";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 253);
            label1.Name = "label1";
            label1.Size = new Size(377, 20);
            label1.TabIndex = 12;
            label1.Text = "Note: Ensure your ID number is accurate to avoid errors.";
            // 
            // StudentTimeinTimeout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 459);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Name = "StudentTimeinTimeout";
            Text = "Student Time in/out";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label1;
    }
}