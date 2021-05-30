using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class FutureValueForm : Form
    {

        double initial, rate, futureValue, gain = 0;
        int year = 0;
        public FutureValueForm()
        {
            InitializeComponent();
        }

        private void FutureValueForm_Load(object sender, EventArgs e)
        {
            initialTextBox.Focus();
        }

        private void FutureValueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Are you sure about exit from the form?", "Don't say goodbye so soon", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel) e.Cancel = true;
        }


        private void initialTextBox_Click(object sender, EventArgs e)
        {
            statusBar.Text = "Input initial payment for your investment";
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            initialTextBox.Text = rateTextBox.Text = termTextBox.Text = fvTextBox.Text = gainTextBox.Text = string.Empty;
            
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void termTextBox_Click(object sender, EventArgs e)
        {
            statusBar.Text = "Input years of terms for your investment";
        }

        private void rateTextBox_Click(object sender, EventArgs e)
        {
            statusBar.Text = "Input rate of interest for your investment as percentage number";
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
            initial = Double.Parse(initialTextBox.Text);
            rate = Double.Parse(rateTextBox.Text) / 100 ;
            year = Int32.Parse(termTextBox.Text);
            //FV = PV * (1 + I)^T
            futureValue = (Math.Pow((1 + rate), year)) * initial;
            fvTextBox.Text = futureValue.ToString("C");
            gainTextBox.Text = (futureValue - initial).ToString("C");


            //Format entered data
            initialTextBox.Text = initial.ToString("C");
            rateTextBox.Text = rate.ToString("##.00%");
            } catch (FormatException fe)
            {
                MessageBox.Show("Fill out Initial deposit, Terms and rate with proper numbers", "Don't leave us with wrong or null data plz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
