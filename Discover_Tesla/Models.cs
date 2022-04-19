using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discover_Tesla
{
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            label2.Text = "Range: 637 km\n\n0-100 km/h: 2.1 s\n\nTop speed: 322 km/h\n\nPrices starting at: $93,740.00";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label2.Text = "Range: 576 km\n\n0-100 km/h: 3.3 s\n\nTop speed: 261 km/h\n\nPrices starting at: $50,940.00";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            label2.Text = "Range: 534 km\n\n0-100 km/h: 3.9 s\n\nTop speed: 250 km/h\n\nPrices starting at: $108,940.00";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            label2.Text = "Range: 512 km\n\n0-100 km/h: 4.8 s\n\nTop speed: 217 km/h\n\nPrices starting at: $82,990.00";
        }
    }
}
