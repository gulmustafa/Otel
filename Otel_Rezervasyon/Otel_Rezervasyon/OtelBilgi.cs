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
    public partial class OtelBilgi : Form
    {
        public OtelBilgi()
        {
            InitializeComponent();
        }

        private void OtelBilgi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnYorum_Click(object sender, EventArgs e)
        {
            Yorumlar yrm = new Yorumlar();
            yrm.Show();
            this.Hide();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            OtelSecim oScm = new OtelSecim();
            oScm.Show();
            this.Hide();
        }
    }
}
