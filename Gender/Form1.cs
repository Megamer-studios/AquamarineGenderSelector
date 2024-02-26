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
                timer1.Enabled = false;
            }
            if (trackBar1.Value >= 15 && trackBar1.Value <= 28)
            {
                label3.Text = ("Gender: femboy");
                pictureBox1.Visible = true;
                timer1.Enabled = true;

            }
            if (trackBar1.Value >= 29 && trackBar1.Value <= 42)
            {
                label3.Text = ("Gender: gay");
                pictureBox1.Visible = true;
                timer1.Enabled = true;


            }
            if (trackBar1.Value >= 43 && trackBar1.Value <= 56)
            {
                label3.Text = ("Gender: neutral");
                pictureBox1.Visible = false;
                timer1.Enabled = false;

            }
            if (trackBar1.Value >= 57 && trackBar1.Value <= 70)
            {
                label3.Text = ("Gender: lesbian");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
            }
            if (trackBar1.Value >= 71 && trackBar1.Value <= 84)
            {
                label3.Text = ("Gender: tomboy");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
            }
            if (trackBar1.Value >= 85 && trackBar1.Value <= 98)
            {
                label3.Text = ("Gender: female");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
            }
            if (timer1.Enabled == false)
            {
                groupBox2.BackColor = Color.FromArgb(255, 240, 240, 240);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Genders(object sender, DrawToolTipEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rng = rnd.Next(1, 255);
            Random rndd = new Random();
            int rngg = rndd.Next(1, 255);
            Random rnddd = new Random();
            int rnggg = rnddd.Next(1, 255);
            groupBox2.BackColor = Color.FromArgb(255, rng, rngg, rnggg);
        }
    }
}
