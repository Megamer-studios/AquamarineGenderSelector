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
            if (trackBar1.Value >= 0 && trackBar1.Value <= 25)
            {
                label3.Text = ("Gender: male");
            }
            if (trackBar1.Value >= 26 && trackBar1.Value <= 35)
            {
                label3.Text = ("Gender: femboy");
            }
            if (trackBar1.Value >= 36 && trackBar1.Value <= 55)
            {
                label3.Text = ("Gender: gay");
            }
            if (trackBar1.Value >= 56 && trackBar1.Value <= 65)
            {
                label3.Text = ("Gender: neutral");
            }
            if (trackBar1.Value >= 66 && trackBar1.Value <= 75)
            {
                label3.Text = ("Gender: lesbian");
            }
            if (trackBar1.Value >= 76 && trackBar1.Value <= 85)
            {
                label3.Text = ("Gender: tomboy");
            }
            if (trackBar1.Value >= 86 && trackBar1.Value <= 100)
            {
                label3.Text = ("Gender: female");
            }


        }
    }
}