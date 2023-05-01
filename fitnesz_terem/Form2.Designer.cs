using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace fitnesz_terem
{

    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private int ID;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void setID(int id)
        {
            ID = id;
        }
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label4 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(8, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 10);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "8:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 50);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "9:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 90);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "10:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 170);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 5;
            label5.Text = "12:00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 210);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 6;
            label6.Text = "13:00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 250);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 7;
            label7.Text = "14:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 290);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 8;
            label8.Text = "15:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 330);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 9;
            label9.Text = "16:00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(304, 370);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 10;
            label10.Text = "17:00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(304, 410);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 11;
            label11.Text = "18:00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(304, 440);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 12;
            label12.Text = "19:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 130);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "11:00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(304, 470);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 14;
            label13.Text = "20:00";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sotetbgr;
            ClientSize = new Size(700, 661);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "Form2";
            Text = "Orarend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label4;
        private Label label13;
    }
}