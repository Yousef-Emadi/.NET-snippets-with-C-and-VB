using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber7
{
    public partial class LuckyNumber7 : Form
        
    {
        int counter7, counterAll = 0;
        Random rand = new Random();

        public LuckyNumber7()
        {
            InitializeComponent();
        }

        private void spinBTN_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            counterAll++;

            digit1LBL.Text = rand.Next(0, 9).ToString();
            digit2LBL.Text = rand.Next(0, 9).ToString();
            digit3LBL.Text = rand.Next(0, 9).ToString();

            if (digit1LBL.Text.Equals("7") || digit2LBL.Text.Equals("7") || digit3LBL.Text.Equals("7"))
            {
                counter7++;
                pictureBox1.Visible = true;
            }

            rateLBL.Visible = true;
            rateLBL.Text = "Your successful spin rate: " + (counter7 * 100 / counterAll).ToString() + "%";

        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            rateLBL.Visible = false;
            counter7 = counterAll = 0;
            digit1LBL.Text = digit2LBL.Text = digit3LBL.Text = "0";

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
