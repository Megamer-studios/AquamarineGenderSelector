namespace Gender
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 316);
            trackBar1.Maximum = 98;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1110, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 298);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Male";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1077, 298);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Female";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 27);
            button1.Name = "button1";
            button1.Size = new Size(131, 39);
            button1.TabIndex = 3;
            button1.Text = "Check gender";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(445, 66);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Gender:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(192, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 138);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genders";
            groupBox1.Enter += groupBox1_Enter;
            groupBox1.MouseHover += groupBox1_MouseHover;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 110);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 6;
            label10.Text = "85-98: female";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 95);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 5;
            label9.Text = "71-84: tomboy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 80);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 4;
            label8.Text = "57-70: lesbian";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 64);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 3;
            label7.Text = "43-56: neutral";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 49);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 2;
            label6.Text = "29-42: gay";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 34);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 1;
            label5.Text = "15-28: femboy";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "0-14: male";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1110, 172);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controls";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1138, 455);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 150;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Gender Selector";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
