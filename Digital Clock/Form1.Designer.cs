﻿namespace Digital_Clock
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
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblSeconds = new Label();
            lblMonth = new Label();
            lblDay = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BorderStyle = BorderStyle.FixedSingle;
            lblTime.Font = new Font("DS-Digital", 72F, FontStyle.Italic, GraphicsUnit.Point);
            lblTime.Location = new Point(479, 224);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(251, 97);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            lblTime.Click += lblTime_Click;
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.BorderStyle = BorderStyle.FixedSingle;
            lblSeconds.Font = new Font("DS-Digital", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblSeconds.Location = new Point(736, 287);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(29, 21);
            lblSeconds.TabIndex = 1;
            lblSeconds.Text = "22";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BorderStyle = BorderStyle.FixedSingle;
            lblMonth.Font = new Font("DS-Digital", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lblMonth.Location = new Point(134, 437);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(380, 49);
            lblMonth.TabIndex = 2;
            lblMonth.Text = "December 25 2023";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BorderStyle = BorderStyle.FixedSingle;
            lblDay.Font = new Font("DS-Digital", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lblDay.Location = new Point(763, 437);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(166, 49);
            lblDay.TabIndex = 3;
            lblDay.Text = "Monday";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1278, 662);
            Controls.Add(lblDay);
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
        private Label lblDay;
        private System.Windows.Forms.Timer timer;
    }
}