
namespace FutureValue
{
    partial class FutureValueForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fvTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gainTextBox = new System.Windows.Forms.TextBox();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1078, 54);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(491, 41);
            this.statusBar.Text = "Welcome to Future Value Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Deposit: ";
            // 
            // initialTextBox
            // 
            this.initialTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initialTextBox.Location = new System.Drawing.Point(536, 149);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(318, 56);
            this.initialTextBox.TabIndex = 2;
            this.initialTextBox.Click += new System.EventHandler(this.initialTextBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Term (years:)";
            // 
            // termTextBox
            // 
            this.termTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.termTextBox.Location = new System.Drawing.Point(536, 310);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(318, 56);
            this.termTextBox.TabIndex = 4;
            this.termTextBox.Click += new System.EventHandler(this.termTextBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(139, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate (%)";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateTextBox.Location = new System.Drawing.Point(536, 456);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(318, 56);
            this.rateTextBox.TabIndex = 6;
            this.rateTextBox.Click += new System.EventHandler(this.rateTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "Future Value:";
            // 
            // fvTextBox
            // 
            this.fvTextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.fvTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fvTextBox.Location = new System.Drawing.Point(536, 651);
            this.fvTextBox.Name = "fvTextBox";
            this.fvTextBox.Size = new System.Drawing.Size(318, 56);
            this.fvTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(139, 788);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 54);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gain of Investment:";
            // 
            // gainTextBox
            // 
            this.gainTextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.gainTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gainTextBox.Location = new System.Drawing.Point(536, 788);
            this.gainTextBox.Name = "gainTextBox";
            this.gainTextBox.Size = new System.Drawing.Size(318, 56);
            this.gainTextBox.TabIndex = 10;
            // 
            // calculateBTN
            // 
            this.calculateBTN.BackColor = System.Drawing.Color.DarkGreen;
            this.calculateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBTN.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.calculateBTN.ForeColor = System.Drawing.Color.White;
            this.calculateBTN.Location = new System.Drawing.Point(139, 977);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(720, 82);
            this.calculateBTN.TabIndex = 11;
            this.calculateBTN.Text = "&Calculate";
            this.toolTip.SetToolTip(this.calculateBTN, "Calculate future value of your initial deposit and your total gain");
            this.calculateBTN.UseVisualStyleBackColor = false;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resetBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBTN.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.resetBTN.ForeColor = System.Drawing.Color.Black;
            this.resetBTN.Location = new System.Drawing.Point(139, 1125);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(316, 82);
            this.resetBTN.TabIndex = 12;
            this.resetBTN.Text = "&Reset";
            this.toolTip.SetToolTip(this.resetBTN, "Clear all form data ");
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBTN.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exitBTN.ForeColor = System.Drawing.Color.Black;
            this.exitBTN.Location = new System.Drawing.Point(538, 1125);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(316, 82);
            this.exitBTN.TabIndex = 13;
            this.exitBTN.Text = "E&xit";
            this.toolTip.SetToolTip(this.exitBTN, "Close the form and exit");
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // FutureValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 1446);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.gainTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fvTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FutureValueForm";
            this.Text = "Future Value Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FutureValueForm_FormClosing);
            this.Load += new System.EventHandler(this.FutureValueForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fvTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gainTextBox;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

