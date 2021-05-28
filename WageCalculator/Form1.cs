using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageCalculator
{
    public partial class Form1 : Form
    {
        double hours;
        double rate;
        double gross;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void calculateBTN_Click(object sender, EventArgs e)
        {
            hours = Convert.ToDouble(hoursBox.Text);
            rate = Convert.ToDouble(rateBox.Text);
            gross = hours * rate;
            grossLBL.Text = gross.ToString("C");
            grossLBL.Visible = true;

        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            hours = 0;
            rate = 0;
            gross = 0;
            hoursBox.Text = "0";
            rateBox.Text = "0";
            grossLBL.Text = "000.00";
            grossLBL.Visible = false;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
