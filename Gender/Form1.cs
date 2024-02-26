using System.Windows.Forms;

namespace Gender
{
    public partial class Form1 : Form
    {
        int hue = 0;
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
                timer2.Enabled = false;
            }
            if (trackBar1.Value >= 15 && trackBar1.Value <= 28)
            {
                label3.Text = ("Gender: femboy");
                pictureBox1.Visible = true;
                timer1.Enabled = true;
                timer2.Enabled = true;

            }
            if (trackBar1.Value >= 29 && trackBar1.Value <= 42)
            {
                label3.Text = ("Gender: gay");
                pictureBox1.Visible = true;
                timer1.Enabled = true;
                timer2.Enabled = true;


            }
            if (trackBar1.Value >= 43 && trackBar1.Value <= 56)
            {
                label3.Text = ("Gender: neutral");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }
            if (trackBar1.Value >= 57 && trackBar1.Value <= 70)
            {
                label3.Text = ("Gender: lesbian");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            if (trackBar1.Value >= 71 && trackBar1.Value <= 84)
            {
                label3.Text = ("Gender: tomboy");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            if (trackBar1.Value >= 85 && trackBar1.Value <= 98)
            {
                label3.Text = ("Gender: female");
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            if (timer1.Enabled == false)
            {
                groupBox2.BackColor = Color.FromArgb(255, 240, 240, 240);
                
            }
            if (timer2.Enabled == false)
            {
               
                trackBar1.BackColor = Color.FromArgb(255, 240, 240, 240);
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
        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            // ######################################################################
            // T. Nathan Mundhenk
            // mundhenk@usc.edu
            // C/C++ Macro HSV to RGB

            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hue = hue + 1;
            if (hue == 360)
            {
                hue = 0;
            }
            int r, g, b;
            HsvToRgb(hue, 1, 1, out r, out g, out b);
            trackBar1.BackColor = Color.FromArgb(255, r, g, b);
        }
    }

}
