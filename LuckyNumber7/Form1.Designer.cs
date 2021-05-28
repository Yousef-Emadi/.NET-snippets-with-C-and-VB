
namespace LuckyNumber7
{
    partial class LuckyNumber7
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
            this.exitBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.spinBTN = new System.Windows.Forms.Button();
            this.digit1LBL = new System.Windows.Forms.Label();
            this.digit2LBL = new System.Windows.Forms.Label();
            this.digit3LBL = new System.Windows.Forms.Label();
            this.rateLBL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBTN.Location = new System.Drawing.Point(541, 890);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(224, 80);
            this.exitBTN.TabIndex = 10;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.resetBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetBTN.Location = new System.Drawing.Point(127, 890);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(220, 80);
            this.resetBTN.TabIndex = 9;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // spinBTN
            // 
            this.spinBTN.BackColor = System.Drawing.Color.Maroon;
            this.spinBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spinBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spinBTN.Location = new System.Drawing.Point(142, 146);
            this.spinBTN.Name = "spinBTN";
            this.spinBTN.Size = new System.Drawing.Size(247, 117);
            this.spinBTN.TabIndex = 12;
            this.spinBTN.Text = "Spin";
            this.spinBTN.UseVisualStyleBackColor = false;
            this.spinBTN.Click += new System.EventHandler(this.spinBTN_Click);
            // 
            // digit1LBL
            // 
            this.digit1LBL.AutoSize = true;
            this.digit1LBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit1LBL.Location = new System.Drawing.Point(460, 146);
            this.digit1LBL.Name = "digit1LBL";
            this.digit1LBL.Padding = new System.Windows.Forms.Padding(15);
            this.digit1LBL.Size = new System.Drawing.Size(100, 111);
            this.digit1LBL.TabIndex = 13;
            this.digit1LBL.Text = "0";
            // 
            // digit2LBL
            // 
            this.digit2LBL.AutoSize = true;
            this.digit2LBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit2LBL.Location = new System.Drawing.Point(574, 146);
            this.digit2LBL.Name = "digit2LBL";
            this.digit2LBL.Padding = new System.Windows.Forms.Padding(15);
            this.digit2LBL.Size = new System.Drawing.Size(100, 111);
            this.digit2LBL.TabIndex = 14;
            this.digit2LBL.Text = "0";
            // 
            // digit3LBL
            // 
            this.digit3LBL.AutoSize = true;
            this.digit3LBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit3LBL.Location = new System.Drawing.Point(680, 146);
            this.digit3LBL.Name = "digit3LBL";
            this.digit3LBL.Padding = new System.Windows.Forms.Padding(15);
            this.digit3LBL.Size = new System.Drawing.Size(100, 111);
            this.digit3LBL.TabIndex = 15;
            this.digit3LBL.Text = "0";
            // 
            // rateLBL
            // 
            this.rateLBL.AutoSize = true;
            this.rateLBL.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rateLBL.Location = new System.Drawing.Point(137, 759);
            this.rateLBL.Name = "rateLBL";
            this.rateLBL.Padding = new System.Windows.Forms.Padding(15);
            this.rateLBL.Size = new System.Drawing.Size(537, 84);
            this.rateLBL.TabIndex = 17;
            this.rateLBL.Text = "Your successful spin rate: ";
            this.rateLBL.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LuckyNumber7.Properties.Resources.number7;
            this.pictureBox1.Location = new System.Drawing.Point(221, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // LuckyNumber7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(917, 1039);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rateLBL);
            this.Controls.Add(this.digit3LBL);
            this.Controls.Add(this.digit2LBL);
            this.Controls.Add(this.digit1LBL);
            this.Controls.Add(this.spinBTN);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.resetBTN);
            this.Name = "LuckyNumber7";
            this.Text = "Lucky Number 7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Button spinBTN;
        private System.Windows.Forms.Label digit1LBL;
        private System.Windows.Forms.Label digit2LBL;
        private System.Windows.Forms.Label digit3LBL;
        private System.Windows.Forms.Label rateLBL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

