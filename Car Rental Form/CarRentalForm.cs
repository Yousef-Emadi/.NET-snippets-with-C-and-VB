/**
 *   Car REntal Form
 *   C# .NET Core project
 *   Developed by: Yousef Emadi
 *   Date: Jun 2021
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        /* >>>>>>>>>>      Constants      <<<<<<<<<<<<<<<<<*/
        //base rate for each car category
        const Double cdblLuxuryRate = 54.84;
        const Double cdblFullSizeRate = 48.22;
        const Double cdblMidSizeRate = 44.91;
        const Double cdblCompactRate = 30.26;
        //Approximate tank size for each car category
        const int cintLuxuryGallons = 25;
        const int cintFullSizeGallons = 20;
        const int cintMidSizeGallons = 15;
        const int cintCompactGallons = 10;
        
        const Double cdblFuelRate = 1.66;          //Fuel cost per gallon
        
        const Double cdblInsuranceRate = 11.95;    //Insurance rate per day


        /* >>>>>>>>>>      Variables      <<<<<<<<<<<<<<<<<*/

        //Double mdblWeeksRate;   //weekly hourly rate
        //Double mdblDaysRate;    //Daily hourly rate
        //Double mdblHoursRate;   //Hourly rate

        Double mdblWeeksCost;    //weekly cost
        Double mdblDaysCost;     //Daily cost
        Double mdblHoursCost;    //Hourly cost
        Double mdblInsuranceCost;     //Total cost for insurance
        Double mdblFuelCost;          //Total cost for fuel
        Double mdblTotalCost;          //Total cost for the car rental
       
        Double mdblCurrentRate;         //Current rate

        Int64 mlngWeeks;                //Number of elapsed weeks
        Int64 mlngDays;                 //Number of elapsed days
        Int64 mlngHours;                //Number of elapsed hours
        Int64 mlngTotalDays;            //Number of total days
        
        //The following variables store the starting and ending date and time.
        DateTime mdatStart;             //Start Date of rent
        DateTime mdatEnd;               //End date of rent



        /* >>>>>>>>>>      Independent Methods      <<<<<<<<<<<<<<<<<*/
        public void clearForm()
        {
            labelUnitWeeks.Text = String.Empty;
            labelUnitDays.Text = String.Empty;
            labelUnitHours.Text = String.Empty;
            labelUnitInsurance.Text = String.Empty;
            labelUnitFuel.Text = String.Empty;

            labelRateWeeks.Text = String.Empty;
            labelRateDays.Text = String.Empty;
            labelRateHours.Text = String.Empty;
            labelRateInsurance.Text = String.Empty;
            labelRateFuel.Text = String.Empty;

            labelCostWeeks.Text = String.Empty;
            labelCostDays.Text = String.Empty;
            labelCostHours.Text = String.Empty;
            labelCostInsurance.Text = String.Empty;
            labelCostFuel.Text = String.Empty;

            labelCostTotal.Text = String.Empty;
        }

        public void clearData()
        {
            mlngDays = 0;
            mlngHours = 0;
            mlngWeeks = 0;
            mdblTotalCost = mdblWeeksCost = mdblDaysCost = mdblHoursCost = mdblInsuranceCost = mdblFuelCost = 0;


        }

        //Time calculator  to calculate weeks, dyas, hours, total days (for insurance)
        public Boolean calculateTime()
        {
            //Read the values for filling variables
            mdatStart = dateTimePickerPickup.Value;
            mdatEnd = dateTimePickerReturn.Value;

            //Validator for time sequence
            if ((mdatEnd < mdatStart) || ((mdatEnd == mdatStart) && (numericUpDownReturn.Value < numericUpDownPickup.Value)))
            {
                MessageBox.Show(
                    "Return date/time must be later than pickup date/time",
                    "Wrong Date Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                return false;  //to cancel the event
            }

            //Validation for empty datetime value
            if (dateTimePickerPickup.Value == dateTimePickerReturn.Value && numericUpDownReturn.Value == numericUpDownPickup.Value)
            {
                MessageBox.Show(
                     "Rental time duration is null",
                     "Null Date/time",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                     );
                return false;
            }

            mlngDays = (mdatEnd - mdatStart).Days;
            mlngHours = (long)(numericUpDownReturn.Value - numericUpDownPickup.Value);  //calculate hours

            if (mlngHours < 0)
            {
                mlngDays--;
                mlngHours = 24 - Math.Abs(mlngHours);
            }
            if (mlngDays >= 7)
            {
                mlngWeeks = mlngDays / 7;    //calculate weeks
                mlngDays = mlngDays % 7;     //calculate days as the remainder
            }
            mlngTotalDays = (mlngWeeks * 7 + mlngDays);     //calculate total days
            return true;
        }


        //Cost and grand total calculator
        public void costCalculator()
        {
            mdblWeeksCost = mlngWeeks * mdblCurrentRate * 7;
            mdblDaysCost = mlngDays * mdblCurrentRate;
            mdblHoursCost = mlngHours * mdblCurrentRate / 24;
            if (checkBoxAcceptInsurance.Checked) 
                mdblInsuranceCost = mlngTotalDays * cdblInsuranceRate;
            else 
                mdblInsuranceCost = 0;
            mdblFuelCost = hScrollBarFuel.Value * cdblFuelRate;
            mdblTotalCost = mdblWeeksCost + mdblDaysCost + mdblHoursCost + mdblInsuranceCost + mdblFuelCost;
        }



        //Fill the lables of "Units" column

        public void fillLabelUnitWeeks()
        {
            labelUnitWeeks.Text = mlngWeeks.ToString();
        }
        public void fillLabelUnitDays()
        {
            labelUnitDays.Text = mlngDays.ToString();
        }
        public void fillLabelUnitHours()
        {
            labelUnitHours.Text = mlngHours.ToString();
        }
        public void fillLabelUnitInsurance()
        {
            if (checkBoxAcceptInsurance.Checked)
            {
                labelUnitInsurance.Text = mlngTotalDays.ToString() + " day(s)";

            }
        }
        public void fillLabelUnitFuel()
        {
            if (hScrollBarFuel.Value != 0) labelUnitFuel.Text = labelFuel.Text + " gal(s)";
        }

        //Fill the lables of "Rate" column
        public void fillLabelRateWeeks()
        {
            labelRateWeeks.Text = (mdblCurrentRate * 7).ToString("C");
        }

        public void fillLabelRateDays()
        {
            labelRateDays.Text = mdblCurrentRate.ToString("C");
        }
        public void fillLabelRateHours()
        {
            labelRateHours.Text = (mdblCurrentRate / 24).ToString("C");
        }
        public void fillLabelRateInsurance()
        {
            if (checkBoxAcceptInsurance.Checked)
            {
                labelRateInsurance.Text = cdblInsuranceRate.ToString("C");
            } 
        }
        public void fillLabelRateFuel()
        {
            if (hScrollBarFuel.Value != 0)
            {
                labelRateFuel.Text = cdblFuelRate.ToString("C");
            }
        }


        //Fill the lables of "Cost" column
        public void fillLabelCostWeeks()
        {
            labelCostWeeks.Text = mdblWeeksCost.ToString("C");
        }
        public void fillLabelCostDays()
        {
            labelCostDays.Text = mdblDaysCost.ToString("C");
        }
        public void fillLabelCostHours()
        {
            labelCostHours.Text = mdblHoursCost.ToString("C");
        }
        public void fillLabelCostInsurance()
        {
            if (checkBoxAcceptInsurance.Checked)
            {
                labelCostInsurance.Text = mdblInsuranceCost.ToString("C");
            }
            else
            {
                labelCostInsurance.Text = String.Empty;
            }
                
        }
        public void fillLabelCostFuel()
        {
            if (hScrollBarFuel.Value != 0)
            {
                labelCostFuel.Text = mdblFuelCost.ToString("C");
            }
            else
            {
                labelCostFuel.Text = String.Empty;
            }
        }
        public void fillLabelCostTotal()
        {
            labelCostTotal.Text = mdblTotalCost.ToString("C");
        }


        /* >>>>>>>>>>      Event Handler Methods      <<<<<<<<<<<<<<<<<*/

        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void CarRentalForm_Load(object sender, EventArgs e)
        {
            //set Today as MinDate for datetime pickers and the lable box in form 
            labelToday.Text = DateTime.Today.ToString("d");
            dateTimePickerPickup.MinDate = DateTime.Today;
            dateTimePickerPickup.Value = DateTime.Today;
            dateTimePickerReturn.MinDate = DateTime.Today;
            dateTimePickerReturn.Value = DateTime.Today;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonCompact_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCompact.Checked)
            {
                mdblCurrentRate = cdblCompactRate;
                hScrollBarFuel.Value = cintCompactGallons;
            }
        }

        private void radioButtonMidSize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMidSize.Checked)
            {
                mdblCurrentRate = cdblMidSizeRate;
                hScrollBarFuel.Value = cintMidSizeGallons;
            }
        }

        private void radioButtonFullSize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFullSize.Checked)
            {
                mdblCurrentRate = cdblFullSizeRate;
                hScrollBarFuel.Value = cintFullSizeGallons;
            }
        }

        private void radioButtonLuxury_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLuxury.Checked)
            {
                mdblCurrentRate = cdblLuxuryRate;
                hScrollBarFuel.Value = cintLuxuryGallons;
            }
        }

        private void hScrollBarFuel_ValueChanged(object sender, EventArgs e)
        {
            labelFuel.Text = hScrollBarFuel.Value.ToString();

        }

        //Calculate button handler
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            clearData();

            //calculate time           
            if (calculateTime() == false) return;
            costCalculator();

            //Reset for the new result
            clearForm();

            //Fill the lables of "Units" column
            fillLabelUnitWeeks();
            fillLabelUnitDays();
            fillLabelUnitHours();
            fillLabelUnitInsurance();
            fillLabelUnitFuel();

            //Fill the lables of "Rate" column
            fillLabelRateWeeks();
            fillLabelRateDays();
            fillLabelRateHours();
            fillLabelRateInsurance();
            fillLabelRateFuel();

            //Fill the lables of "Cost" column
            fillLabelCostWeeks();
            fillLabelCostDays();
            fillLabelCostHours();
            fillLabelCostInsurance();
            fillLabelCostFuel();
            fillLabelCostTotal();

        }

        //Closing verification
        private void CarRentalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = new DialogResult();
            result = MessageBox.Show(
                "Are you sure you want to quit the form?",
                "Exit Confirmation", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Cancel) e.Cancel = true; 

        }

        //Clear Button handler
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearForm();
            clearData();
        }

        private void stripStatusLabel_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Yousef-Emadi");
            }catch(Exception ee)
            {
                MessageBox.Show(
                    "Car Rental Form\nDeveloped By: Yousef Emadi\nSource code: Github.com/Yousef-Emadi",
                    "About", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                    );
            }
        }
    }//Class ends
}//nameSpace ends
