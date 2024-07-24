namespace Week4Exam
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
            comboBox_daysOfWeek = new ComboBox();
            comboBox_year = new ComboBox();
            comboBox_daysOfMonth = new ComboBox();
            comboBox_month = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox_daysOfWeek
            // 
            comboBox_daysOfWeek.FormattingEnabled = true;
            comboBox_daysOfWeek.Location = new Point(637, 71);
            comboBox_daysOfWeek.Name = "comboBox_daysOfWeek";
            comboBox_daysOfWeek.Size = new Size(151, 28);
            comboBox_daysOfWeek.TabIndex = 0;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Location = new Point(48, 71);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(151, 28);
            comboBox_year.TabIndex = 1;
            // 
            // comboBox_daysOfMonth
            // 
            comboBox_daysOfMonth.FormattingEnabled = true;
            comboBox_daysOfMonth.Location = new Point(447, 71);
            comboBox_daysOfMonth.Name = "comboBox_daysOfMonth";
            comboBox_daysOfMonth.Size = new Size(151, 28);
            comboBox_daysOfMonth.TabIndex = 1;
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Location = new Point(256, 71);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(151, 28);
            comboBox_month.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(360, 234);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "אישור";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox_month);
            Controls.Add(comboBox_daysOfMonth);
            Controls.Add(comboBox_year);
            Controls.Add(comboBox_daysOfWeek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_daysOfWeek;
        private ComboBox comboBox_year;
        private ComboBox comboBox_daysOfMonth;
        private ComboBox comboBox_month;
        private Button button1;
    }
}
