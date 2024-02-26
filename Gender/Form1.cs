namespace Gender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value >= 0 && trackBar1.Value <= 14)
            {
                label3.Text = ("Gender: male");
                pictureBox1.Visible = false;
            }
            if (trackBar1.Value >= 15 && trackBar1.Value <= 28)
            {
                label3.Text = ("Gender: femboy");
                pictureBox1.Visible = true;
            }
            if (trackBar1.Value >= 29 && trackBar1.Value <= 42)
            {
                label3.Text = ("Gender: gay");
                pictureBox1.Visible = true;
            }
            if (trackBar1.Value >= 43 && trackBar1.Value <= 56)
            {
                label3.Text = ("Gender: neutral");
                pictureBox1.Visible = false;
            }
            if (trackBar1.Value >= 57 && trackBar1.Value <= 70)
            {
                label3.Text = ("Gender: lesbian");
                pictureBox1.Visible = false;
            }
            if (trackBar1.Value >= 71 && trackBar1.Value <= 84)
            {
                label3.Text = ("Gender: tomboy");
                pictureBox1.Visible = false;
            }
            if (trackBar1.Value >= 85 && trackBar1.Value <= 98)
            {
                label3.Text = ("Gender: female");
                pictureBox1.Visible = false;
            }


        }
    }
}
