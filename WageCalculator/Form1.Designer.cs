
namespace WageCalculator
{
    partial class Form1
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
            this.hoursLBL = new System.Windows.Forms.Label();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.rateLBL = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grossLBL = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursLBL
            // 
            this.hoursLBL.AutoSize = true;
            this.hoursLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hoursLBL.Location = new System.Drawing.Point(142, 140);
            this.hoursLBL.Name = "hoursLBL";
            this.hoursLBL.Size = new System.Drawing.Size(352, 54);
            this.hoursLBL.TabIndex = 0;
            this.hoursLBL.Text = "Number of Hours";
            // 
            // hoursBox
            // 
            this.hoursBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursBox.Location = new System.Drawing.Point(551, 137);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(126, 61);
            this.hoursBox.TabIndex = 1;
            this.hoursBox.Text = "0";
            this.hoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rateLBL
            // 
            this.rateLBL.AutoSize = true;
            this.rateLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rateLBL.Location = new System.Drawing.Point(142, 288);
            this.rateLBL.Name = "rateLBL";
            this.rateLBL.Size = new System.Drawing.Size(289, 54);
            this.rateLBL.TabIndex = 2;
            this.rateLBL.Text = "Rate per Hour";
            // 
            // rateBox
            // 
            this.rateBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateBox.Location = new System.Drawing.Point(551, 288);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(126, 61);
            this.rateBox.TabIndex = 3;
            this.rateBox.Text = "0";
            this.rateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gross wage";
            // 
            // grossLBL
            // 
            this.grossLBL.AutoSize = true;
            this.grossLBL.Enabled = false;
            this.grossLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grossLBL.ForeColor = System.Drawing.Color.Teal;
            this.grossLBL.Location = new System.Drawing.Point(528, 438);
            this.grossLBL.Name = "grossLBL";
            this.grossLBL.Size = new System.Drawing.Size(149, 54);
            this.grossLBL.TabIndex = 5;
            this.grossLBL.Text = "000.00";
            this.grossLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grossLBL.Visible = false;
            // 
            // calculateBTN
            // 
            this.calculateBTN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.calculateBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculateBTN.Location = new System.Drawing.Point(142, 588);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(539, 80);
            this.calculateBTN.TabIndex = 6;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = false;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.resetBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetBTN.Location = new System.Drawing.Point(142, 734);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(220, 80);
            this.resetBTN.TabIndex = 7;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBTN.Location = new System.Drawing.Point(457, 734);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(224, 80);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 975);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.grossLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.rateLBL);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.hoursLBL);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLBL;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label rateLBL;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grossLBL;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

