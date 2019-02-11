using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        int resimIndex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            resimIndex++;
            if (resimIndex>4)
            {
                resimIndex = 1;
            }
            List<Bitmap> rsm = new List<Bitmap>();
            rsm.Add(Properties.Resources._1);
            rsm.Add(Properties.Resources._2);
            rsm.Add(Properties.Resources._3);
            rsm.Add(Properties.Resources._4);
            rsm.Add(Properties.Resources._5);
            this.BackgroundImage = rsm[resimIndex];
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
