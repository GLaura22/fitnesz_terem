namespace fitnesz_terem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Users_with_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_Text_Box = new System.Windows.Forms.TextBox();
            this.Items_with_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Users_with_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_with_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_with_data
            // 
            this.Users_with_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_with_data.Location = new System.Drawing.Point(13, 69);
            this.Users_with_data.Name = "Users_with_data";
            this.Users_with_data.RowTemplate.Height = 25;
            this.Users_with_data.Size = new System.Drawing.Size(293, 145);
            this.Users_with_data.TabIndex = 1;
            this.Users_with_data.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_with_data_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználók (Cellába adatmódosítás élesben történik)";
            // 
            // filter_Text_Box
            // 
            this.filter_Text_Box.Location = new System.Drawing.Point(12, 40);
            this.filter_Text_Box.Name = "filter_Text_Box";
            this.filter_Text_Box.Size = new System.Drawing.Size(294, 23);
            this.filter_Text_Box.TabIndex = 3;
            this.filter_Text_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Items_with_data
            // 
            this.Items_with_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_with_data.Location = new System.Drawing.Point(494, 69);
            this.Items_with_data.Name = "Items_with_data";
            this.Items_with_data.RowTemplate.Height = 25;
            this.Items_with_data.Size = new System.Drawing.Size(294, 145);
            this.Items_with_data.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Items_with_data);
            this.Controls.Add(this.filter_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users_with_data);
            this.Name = "AdminForm";
            this.Text = "AdmiNForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_with_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_with_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView Users_with_data;
        private Label label1;
        private TextBox filter_Text_Box;
        private DataGridView Items_with_data;
    }
}