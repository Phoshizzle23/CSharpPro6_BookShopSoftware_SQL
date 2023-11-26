namespace BookShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1357, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(604, 21);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 2;
            label1.Text = "Book Shop";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 590);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.BlueViolet;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 681);
            panel3.Name = "panel3";
            panel3.Size = new Size(1357, 27);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 154);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 2;
            label2.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 257);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "Author:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 203);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 5;
            label5.Text = "BookName:";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(167, 335);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 6;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.BlueViolet;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(304, 335);
            button2.Name = "button2";
            button2.Size = new Size(95, 37);
            button2.TabIndex = 7;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Indigo;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(445, 335);
            button3.Name = "button3";
            button3.Size = new Size(95, 37);
            button3.TabIndex = 8;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MediumOrchid;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(152, 393);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(492, 260);
            dataGridView1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 26);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 26);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(286, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 26);
            textBox3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(659, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(686, 535);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1316, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1357, 708);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}