namespace Beedget
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_currentAmount = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.addedDate = new System.Windows.Forms.DateTimePicker();
            this.category = new System.Windows.Forms.ComboBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tb_currentAmount);
            this.panel3.Controls.Add(this.save_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.addedDate);
            this.panel3.Controls.Add(this.category);
            this.panel3.Controls.Add(this.tb_title);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 393);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(239, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount";
            // 
            // tb_currentAmount
            // 
            this.tb_currentAmount.BackColor = System.Drawing.Color.White;
            this.tb_currentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_currentAmount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.tb_currentAmount.ForeColor = System.Drawing.Color.Black;
            this.tb_currentAmount.Location = new System.Drawing.Point(26, 132);
            this.tb_currentAmount.Margin = new System.Windows.Forms.Padding(5);
            this.tb_currentAmount.Name = "tb_currentAmount";
            this.tb_currentAmount.Size = new System.Drawing.Size(194, 43);
            this.tb_currentAmount.TabIndex = 3;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_btn.BackgroundImage")));
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.Location = new System.Drawing.Point(154, 300);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(162, 56);
            this.save_btn.TabIndex = 4;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Added Date";
            // 
            // addedDate
            // 
            this.addedDate.CalendarForeColor = System.Drawing.Color.White;
            this.addedDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.addedDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.addedDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.addedDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.addedDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addedDate.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.addedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addedDate.Location = new System.Drawing.Point(26, 229);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(413, 43);
            this.addedDate.TabIndex = 5;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.White;
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.FormattingEnabled = true;
            this.category.ItemHeight = 37;
            this.category.Items.AddRange(new object[] {
            "Clothing",
            "Emergency",
            "Education",
            "Travel",
            "Health",
            "Others"});
            this.category.Location = new System.Drawing.Point(245, 130);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(194, 45);
            this.category.TabIndex = 0;
            // 
            // tb_title
            // 
            this.tb_title.BackColor = System.Drawing.Color.DarkKhaki;
            this.tb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.tb_title.ForeColor = System.Drawing.Color.Black;
            this.tb_title.Location = new System.Drawing.Point(75, 29);
            this.tb_title.Margin = new System.Windows.Forms.Padding(5);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(316, 45);
            this.tb_title.TabIndex = 4;
            this.tb_title.Text = "Title";
            this.tb_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_title.Click += new System.EventHandler(this.tb_title_Click);
            // 
            // Expense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(474, 396);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker addedDate;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox tb_currentAmount;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.FlowLayoutPanel save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}