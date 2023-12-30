namespace Digital_Clock
{
    partial class DigitalClock
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
            lblTime = new Label();
            lblSeconds = new Label();
            lblMonth = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(147, 145);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(283, 128);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeconds.Location = new Point(422, 224);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(35, 30);
            lblSeconds.TabIndex = 1;
            lblSeconds.Text = "22";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonth.Location = new Point(188, 437);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(226, 65);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "Dec 2023";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(735, 456);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1278, 662);
            Controls.Add(label4);
            Controls.Add(lblMonth);
            Controls.Add(lblSeconds);
            Controls.Add(lblTime);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DigitalClock";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSeconds;
        private Label lblMonth;
        private Label label4;
    }
}