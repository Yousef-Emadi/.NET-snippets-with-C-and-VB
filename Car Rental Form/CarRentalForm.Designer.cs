/**
*   Car REntal Form
*   C# .NET Core project
*   Developed by: Yousef Emadi
*   Date: Jun 2021
* */


namespace CarRental
{
    partial class CarRentalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLuxury = new System.Windows.Forms.RadioButton();
            this.radioButtonFullSize = new System.Windows.Forms.RadioButton();
            this.radioButtonMidSize = new System.Windows.Forms.RadioButton();
            this.radioButtonCompact = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hScrollBarFuel = new System.Windows.Forms.HScrollBar();
            this.labelFuel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAcceptInsurance = new System.Windows.Forms.CheckBox();
            this.dateTimePickerPickup = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPickup = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownReturn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRateWeeks = new System.Windows.Forms.Label();
            this.labelCostWeeks = new System.Windows.Forms.Label();
            this.labelRateHours = new System.Windows.Forms.Label();
            this.labelCostHours = new System.Windows.Forms.Label();
            this.labelRateDays = new System.Windows.Forms.Label();
            this.labelCostDays = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelUnitHours = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelUnitDays = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelUnitWeeks = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelUnitFuel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labelUnitInsurance = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.labelCostTotal = new System.Windows.Forms.Label();
            this.labelRateFuel = new System.Windows.Forms.Label();
            this.labelCostFuel = new System.Windows.Forms.Label();
            this.labelRateInsurance = new System.Windows.Forms.Label();
            this.labelCostInsurance = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelToday = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturn)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLuxury);
            this.groupBox1.Controls.Add(this.radioButtonFullSize);
            this.groupBox1.Controls.Add(this.radioButtonMidSize);
            this.groupBox1.Controls.Add(this.radioButtonCompact);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(114, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Category";
            // 
            // radioButtonLuxury
            // 
            this.radioButtonLuxury.AutoSize = true;
            this.radioButtonLuxury.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLuxury.Location = new System.Drawing.Point(58, 348);
            this.radioButtonLuxury.Name = "radioButtonLuxury";
            this.radioButtonLuxury.Size = new System.Drawing.Size(166, 54);
            this.radioButtonLuxury.TabIndex = 3;
            this.radioButtonLuxury.TabStop = true;
            this.radioButtonLuxury.Text = "Luxury";
            this.toolTip1.SetToolTip(this.radioButtonLuxury, "Daily rate $54.84 and 25 gal fuel tank size");
            this.radioButtonLuxury.UseVisualStyleBackColor = true;
            this.radioButtonLuxury.CheckedChanged += new System.EventHandler(this.radioButtonLuxury_CheckedChanged);
            // 
            // radioButtonFullSize
            // 
            this.radioButtonFullSize.AutoSize = true;
            this.radioButtonFullSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFullSize.Location = new System.Drawing.Point(58, 266);
            this.radioButtonFullSize.Name = "radioButtonFullSize";
            this.radioButtonFullSize.Size = new System.Drawing.Size(191, 54);
            this.radioButtonFullSize.TabIndex = 2;
            this.radioButtonFullSize.TabStop = true;
            this.radioButtonFullSize.Text = "Full Size";
            this.toolTip1.SetToolTip(this.radioButtonFullSize, "Daily rate $48.22 and 20 gal fuel tank size");
            this.radioButtonFullSize.UseVisualStyleBackColor = true;
            this.radioButtonFullSize.CheckedChanged += new System.EventHandler(this.radioButtonFullSize_CheckedChanged);
            // 
            // radioButtonMidSize
            // 
            this.radioButtonMidSize.AutoSize = true;
            this.radioButtonMidSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMidSize.Location = new System.Drawing.Point(58, 179);
            this.radioButtonMidSize.Name = "radioButtonMidSize";
            this.radioButtonMidSize.Size = new System.Drawing.Size(198, 54);
            this.radioButtonMidSize.TabIndex = 1;
            this.radioButtonMidSize.TabStop = true;
            this.radioButtonMidSize.Text = "Mid Size";
            this.toolTip1.SetToolTip(this.radioButtonMidSize, "Daily rate $44.91 and 15 gal fuel tank size");
            this.radioButtonMidSize.UseVisualStyleBackColor = true;
            this.radioButtonMidSize.CheckedChanged += new System.EventHandler(this.radioButtonMidSize_CheckedChanged);
            // 
            // radioButtonCompact
            // 
            this.radioButtonCompact.AutoSize = true;
            this.radioButtonCompact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCompact.Location = new System.Drawing.Point(58, 92);
            this.radioButtonCompact.Name = "radioButtonCompact";
            this.radioButtonCompact.Size = new System.Drawing.Size(207, 54);
            this.radioButtonCompact.TabIndex = 0;
            this.radioButtonCompact.TabStop = true;
            this.radioButtonCompact.Text = "Compact";
            this.toolTip1.SetToolTip(this.radioButtonCompact, "Daily rate $30.26 and 10 gal fuel tank size");
            this.radioButtonCompact.UseVisualStyleBackColor = true;
            this.radioButtonCompact.CheckedChanged += new System.EventHandler(this.radioButtonCompact_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hScrollBarFuel);
            this.groupBox2.Controls.Add(this.labelFuel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxAcceptInsurance);
            this.groupBox2.Location = new System.Drawing.Point(114, 609);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Charges";
            // 
            // hScrollBarFuel
            // 
            this.hScrollBarFuel.Location = new System.Drawing.Point(33, 307);
            this.hScrollBarFuel.Maximum = 109;
            this.hScrollBarFuel.Name = "hScrollBarFuel";
            this.hScrollBarFuel.Size = new System.Drawing.Size(335, 56);
            this.hScrollBarFuel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.hScrollBarFuel, "Fuel cost per gallon: 1.66");
            this.hScrollBarFuel.ValueChanged += new System.EventHandler(this.hScrollBarFuel_ValueChanged);
            // 
            // labelFuel
            // 
            this.labelFuel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFuel.Location = new System.Drawing.Point(145, 198);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(122, 51);
            this.labelFuel.TabIndex = 4;
            this.labelFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelFuel, "Fuel cost per gallon: 1.66");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuel:";
            // 
            // checkBoxAcceptInsurance
            // 
            this.checkBoxAcceptInsurance.AutoSize = true;
            this.checkBoxAcceptInsurance.Location = new System.Drawing.Point(33, 73);
            this.checkBoxAcceptInsurance.Name = "checkBoxAcceptInsurance";
            this.checkBoxAcceptInsurance.Size = new System.Drawing.Size(282, 45);
            this.checkBoxAcceptInsurance.TabIndex = 2;
            this.checkBoxAcceptInsurance.Text = "Accept Insurance";
            this.toolTip1.SetToolTip(this.checkBoxAcceptInsurance, "Insurance rate per day: $11.95");
            this.checkBoxAcceptInsurance.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerPickup
            // 
            this.dateTimePickerPickup.Location = new System.Drawing.Point(631, 154);
            this.dateTimePickerPickup.MaxDate = new System.DateTime(2039, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerPickup.MinDate = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            this.dateTimePickerPickup.Name = "dateTimePickerPickup";
            this.dateTimePickerPickup.Size = new System.Drawing.Size(761, 47);
            this.dateTimePickerPickup.TabIndex = 2;
            this.dateTimePickerPickup.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car pickup date and hour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car return date and hour:";
            // 
            // numericUpDownPickup
            // 
            this.numericUpDownPickup.Location = new System.Drawing.Point(1398, 154);
            this.numericUpDownPickup.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownPickup.Name = "numericUpDownPickup";
            this.numericUpDownPickup.Size = new System.Drawing.Size(178, 47);
            this.numericUpDownPickup.TabIndex = 5;
            this.numericUpDownPickup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.numericUpDownPickup, "Select hour");
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(631, 308);
            this.dateTimePickerReturn.MaxDate = new System.DateTime(2039, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerReturn.MinDate = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(761, 47);
            this.dateTimePickerReturn.TabIndex = 6;
            this.dateTimePickerReturn.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // numericUpDownReturn
            // 
            this.numericUpDownReturn.Location = new System.Drawing.Point(1398, 308);
            this.numericUpDownReturn.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownReturn.Name = "numericUpDownReturn";
            this.numericUpDownReturn.Size = new System.Drawing.Size(178, 47);
            this.numericUpDownReturn.TabIndex = 7;
            this.numericUpDownReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.numericUpDownReturn, "Select hour");
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1386, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 87);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1190, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 87);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRateWeeks
            // 
            this.labelRateWeeks.BackColor = System.Drawing.Color.White;
            this.labelRateWeeks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRateWeeks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRateWeeks.Location = new System.Drawing.Point(1190, 544);
            this.labelRateWeeks.Name = "labelRateWeeks";
            this.labelRateWeeks.Size = new System.Drawing.Size(190, 87);
            this.labelRateWeeks.TabIndex = 11;
            this.labelRateWeeks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCostWeeks
            // 
            this.labelCostWeeks.BackColor = System.Drawing.Color.White;
            this.labelCostWeeks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCostWeeks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCostWeeks.Location = new System.Drawing.Point(1386, 544);
            this.labelCostWeeks.Name = "labelCostWeeks";
            this.labelCostWeeks.Size = new System.Drawing.Size(190, 87);
            this.labelCostWeeks.TabIndex = 10;
            this.labelCostWeeks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRateHours
            // 
            this.labelRateHours.BackColor = System.Drawing.Color.White;
            this.labelRateHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRateHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRateHours.Location = new System.Drawing.Point(1190, 734);
            this.labelRateHours.Name = "labelRateHours";
            this.labelRateHours.Size = new System.Drawing.Size(190, 87);
            this.labelRateHours.TabIndex = 15;
            this.labelRateHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCostHours
            // 
            this.labelCostHours.BackColor = System.Drawing.Color.White;
            this.labelCostHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCostHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCostHours.Location = new System.Drawing.Point(1386, 734);
            this.labelCostHours.Name = "labelCostHours";
            this.labelCostHours.Size = new System.Drawing.Size(190, 87);
            this.labelCostHours.TabIndex = 14;
            this.labelCostHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRateDays
            // 
            this.labelRateDays.BackColor = System.Drawing.Color.White;
            this.labelRateDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRateDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRateDays.Location = new System.Drawing.Point(1190, 638);
            this.labelRateDays.Name = "labelRateDays";
            this.labelRateDays.Size = new System.Drawing.Size(190, 87);
            this.labelRateDays.TabIndex = 13;
            this.labelRateDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCostDays
            // 
            this.labelCostDays.BackColor = System.Drawing.Color.White;
            this.labelCostDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCostDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCostDays.Location = new System.Drawing.Point(1386, 638);
            this.labelCostDays.Name = "labelCostDays";
            this.labelCostDays.Size = new System.Drawing.Size(190, 87);
            this.labelCostDays.TabIndex = 12;
            this.labelCostDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(798, 734);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 87);
            this.label12.TabIndex = 23;
            this.label12.Text = "Hours";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitHours
            // 
            this.labelUnitHours.BackColor = System.Drawing.Color.White;
            this.labelUnitHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnitHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnitHours.Location = new System.Drawing.Point(994, 734);
            this.labelUnitHours.Name = "labelUnitHours";
            this.labelUnitHours.Size = new System.Drawing.Size(190, 87);
            this.labelUnitHours.TabIndex = 22;
            this.labelUnitHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(798, 638);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 87);
            this.label14.TabIndex = 21;
            this.label14.Text = "Days";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitDays
            // 
            this.labelUnitDays.BackColor = System.Drawing.Color.White;
            this.labelUnitDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnitDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnitDays.Location = new System.Drawing.Point(994, 638);
            this.labelUnitDays.Name = "labelUnitDays";
            this.labelUnitDays.Size = new System.Drawing.Size(190, 87);
            this.labelUnitDays.TabIndex = 20;
            this.labelUnitDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(798, 544);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 87);
            this.label16.TabIndex = 19;
            this.label16.Text = "Weeks";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitWeeks
            // 
            this.labelUnitWeeks.BackColor = System.Drawing.Color.White;
            this.labelUnitWeeks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnitWeeks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnitWeeks.Location = new System.Drawing.Point(994, 544);
            this.labelUnitWeeks.Name = "labelUnitWeeks";
            this.labelUnitWeeks.Size = new System.Drawing.Size(190, 87);
            this.labelUnitWeeks.TabIndex = 18;
            this.labelUnitWeeks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(994, 448);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(190, 87);
            this.label19.TabIndex = 16;
            this.label19.Text = "Units";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(798, 928);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(190, 87);
            this.label24.TabIndex = 35;
            this.label24.Text = "Fuel";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitFuel
            // 
            this.labelUnitFuel.BackColor = System.Drawing.Color.White;
            this.labelUnitFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnitFuel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnitFuel.Location = new System.Drawing.Point(994, 928);
            this.labelUnitFuel.Name = "labelUnitFuel";
            this.labelUnitFuel.Size = new System.Drawing.Size(190, 87);
            this.labelUnitFuel.TabIndex = 34;
            this.labelUnitFuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(798, 832);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(190, 87);
            this.label26.TabIndex = 33;
            this.label26.Text = "Insurance";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitInsurance
            // 
            this.labelUnitInsurance.BackColor = System.Drawing.Color.White;
            this.labelUnitInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnitInsurance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnitInsurance.Location = new System.Drawing.Point(994, 832);
            this.labelUnitInsurance.Name = "labelUnitInsurance";
            this.labelUnitInsurance.Size = new System.Drawing.Size(190, 87);
            this.labelUnitInsurance.TabIndex = 32;
            this.labelUnitInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(1190, 1022);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(190, 87);
            this.label30.TabIndex = 29;
            this.label30.Text = "Total";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCostTotal
            // 
            this.labelCostTotal.BackColor = System.Drawing.Color.White;
            this.labelCostTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCostTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCostTotal.Location = new System.Drawing.Point(1386, 1022);
            this.labelCostTotal.Name = "labelCostTotal";
            this.labelCostTotal.Size = new System.Drawing.Size(190, 87);
            this.labelCostTotal.TabIndex = 28;
            this.labelCostTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRateFuel
            // 
            this.labelRateFuel.BackColor = System.Drawing.Color.White;
            this.labelRateFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRateFuel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRateFuel.Location = new System.Drawing.Point(1190, 928);
            this.labelRateFuel.Name = "labelRateFuel";
            this.labelRateFuel.Size = new System.Drawing.Size(190, 87);
            this.labelRateFuel.TabIndex = 27;
            this.labelRateFuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCostFuel
            // 
            this.labelCostFuel.BackColor = System.Drawing.Color.White;
            this.labelCostFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCostFuel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCostFuel.Location = new System.Drawing.Point(1386, 928);
            this.labelCostFuel.Name = "labelCostFuel";
            this.labelCostFuel.Size = new System.Drawing.Size(190, 87);
            this.labelCostFuel.TabIndex = 26;
            this.labelCostFuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRateInsurance
            // 
            this.labelRateInsurance.BackColor = System.Drawing.Color.White;
            this.labelRateInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRateInsurance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRateInsurance.Location = new System.Drawing.Point(1190, 832);
            this.labelRateInsurance.Name = "labelRateInsurance";
            this.labelRateInsurance.Size = new System.Drawing.Size(190, 87);
            this.labelRateInsurance.TabIndex = 25;
            this.labelRateInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCostInsurance
            // 
            this.labelCostInsurance.BackColor = System.Drawing.Color.White;
            this.labelCostInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCostInsurance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCostInsurance.Location = new System.Drawing.Point(1386, 832);
            this.labelCostInsurance.Name = "labelCostInsurance";
            this.labelCostInsurance.Size = new System.Drawing.Size(190, 87);
            this.labelCostInsurance.TabIndex = 24;
            this.labelCostInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCalculate.FlatAppearance.BorderSize = 5;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(654, 1202);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(270, 100);
            this.buttonCalculate.TabIndex = 36;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelToday
            // 
            this.labelToday.BackColor = System.Drawing.Color.LightCyan;
            this.labelToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelToday.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelToday.ForeColor = System.Drawing.Color.Navy;
            this.labelToday.Location = new System.Drawing.Point(124, 1098);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(394, 204);
            this.labelToday.TabIndex = 37;
            this.labelToday.Text = "Today";
            this.labelToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClear.FlatAppearance.BorderSize = 5;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(980, 1202);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(270, 100);
            this.buttonClear.TabIndex = 38;
            this.buttonClear.Text = "C&lear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.FlatAppearance.BorderSize = 5;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(1306, 1202);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(270, 100);
            this.buttonExit.TabIndex = 39;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1737, 54);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripStatusLabel
            // 
            this.stripStatusLabel.IsLink = true;
            this.stripStatusLabel.Name = "stripStatusLabel";
            this.stripStatusLabel.Size = new System.Drawing.Size(1722, 41);
            this.stripStatusLabel.Spring = true;
            this.stripStatusLabel.Text = "Developed by: Y.Emadi";
            this.stripStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stripStatusLabel.Click += new System.EventHandler(this.stripStatusLabel_Click);
            // 
            // CarRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1737, 1414);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.labelUnitFuel);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.labelUnitInsurance);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.labelCostTotal);
            this.Controls.Add(this.labelRateFuel);
            this.Controls.Add(this.labelCostFuel);
            this.Controls.Add(this.labelRateInsurance);
            this.Controls.Add(this.labelCostInsurance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelUnitHours);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelUnitDays);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelUnitWeeks);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labelRateHours);
            this.Controls.Add(this.labelCostHours);
            this.Controls.Add(this.labelRateDays);
            this.Controls.Add(this.labelCostDays);
            this.Controls.Add(this.labelRateWeeks);
            this.Controls.Add(this.labelCostWeeks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownReturn);
            this.Controls.Add(this.dateTimePickerReturn);
            this.Controls.Add(this.numericUpDownPickup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerPickup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CarRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental - 2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarRentalForm_FormClosing);
            this.Load += new System.EventHandler(this.CarRentalForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturn)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonMidSize;
        private System.Windows.Forms.RadioButton radioButtonCompact;
        private System.Windows.Forms.RadioButton radioButtonFullSize;
        private System.Windows.Forms.RadioButton radioButtonLuxury;
        private System.Windows.Forms.CheckBox checkBoxAcceptInsurance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.HScrollBar hScrollBarFuel;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPickup;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.NumericUpDown numericUpDownReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRateWeeks;
        private System.Windows.Forms.Label labelCostWeeks;
        private System.Windows.Forms.Label labelRateHours;
        private System.Windows.Forms.Label labelCostHours;
        private System.Windows.Forms.Label labelRateDays;
        private System.Windows.Forms.Label labelCostDays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelUnitHours;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelUnitDays;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelUnitWeeks;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelUnitFuel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelUnitInsurance;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label labelCostTotal;
        private System.Windows.Forms.Label labelRateFuel;
        private System.Windows.Forms.Label labelCostFuel;
        private System.Windows.Forms.Label labelRateInsurance;
        private System.Windows.Forms.Label labelCostInsurance;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLabel;
    }
}

