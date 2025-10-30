namespace Beedget
{
    partial class Savings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Savings));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.upload_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_targetAmount = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_currentAmount = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.addedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.save_btn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(471, 605);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.upload_btn);
            this.panel4.Location = new System.Drawing.Point(160, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 137);
            this.panel4.TabIndex = 0;
            // 
            // upload_btn
            // 
            this.upload_btn.BackColor = System.Drawing.Color.White;
            this.upload_btn.Location = new System.Drawing.Point(39, 91);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(80, 43);
            this.upload_btn.TabIndex = 0;
            this.upload_btn.Text = "upload";
            this.upload_btn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.tb_targetAmount);
            this.panel5.Location = new System.Drawing.Point(27, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 59);
            this.panel5.TabIndex = 1;
            // 
            // tb_targetAmount
            // 
            this.tb_targetAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(212)))), ((int)(((byte)(41)))));
            this.tb_targetAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_targetAmount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.tb_targetAmount.ForeColor = System.Drawing.Color.White;
            this.tb_targetAmount.Location = new System.Drawing.Point(44, 14);
            this.tb_targetAmount.Margin = new System.Windows.Forms.Padding(5);
            this.tb_targetAmount.Name = "tb_targetAmount";
            this.tb_targetAmount.Size = new System.Drawing.Size(316, 36);
            this.tb_targetAmount.TabIndex = 3;
            this.tb_targetAmount.Text = "Target Amount";
            this.tb_targetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_targetAmount.TextChanged += new System.EventHandler(this.tb_targetAmount_TextChanged);
            // 
            // tb_title
            // 
            this.tb_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.tb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.tb_title.ForeColor = System.Drawing.Color.White;
            this.tb_title.Location = new System.Drawing.Point(80, 153);
            this.tb_title.Margin = new System.Windows.Forms.Padding(5);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(316, 45);
            this.tb_title.TabIndex = 4;
            this.tb_title.Text = "Title";
            this.tb_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_title.TextChanged += new System.EventHandler(this.tb_title_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.tb_currentAmount);
            this.panel6.Location = new System.Drawing.Point(27, 430);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 59);
            this.panel6.TabIndex = 4;
            // 
            // tb_currentAmount
            // 
            this.tb_currentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(186)))), ((int)(((byte)(102)))));
            this.tb_currentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_currentAmount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.tb_currentAmount.ForeColor = System.Drawing.Color.White;
            this.tb_currentAmount.Location = new System.Drawing.Point(15, 14);
            this.tb_currentAmount.Margin = new System.Windows.Forms.Padding(5);
            this.tb_currentAmount.Name = "tb_currentAmount";
            this.tb_currentAmount.Size = new System.Drawing.Size(381, 32);
            this.tb_currentAmount.TabIndex = 3;
            this.tb_currentAmount.Text = "Current Amount";
            this.tb_currentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_currentAmount.TextChanged += new System.EventHandler(this.tb_currentAmount_TextChanged);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.FormattingEnabled = true;
            this.category.ItemHeight = 31;
            this.category.Items.AddRange(new object[] {
            "Clothing",
            "Emergency Fund",
            "Education Fund",
            "Travel",
            "Health Fund",
            "Others: Please specify"});
            this.category.Location = new System.Drawing.Point(27, 286);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(413, 39);
            this.category.TabIndex = 0;
            this.category.Text = "Category";
            // 
            // addedDate
            // 
            this.addedDate.CalendarForeColor = System.Drawing.Color.White;
            this.addedDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.addedDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.addedDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.addedDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.addedDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addedDate.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addedDate.Location = new System.Drawing.Point(27, 371);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(194, 38);
            this.addedDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Added Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Target Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 371);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 38);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_btn.BackgroundImage")));
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_btn.Location = new System.Drawing.Point(155, 506);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(162, 56);
            this.save_btn.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.save_btn);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.addedDate);
            this.panel3.Controls.Add(this.category);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.tb_title);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 602);
            this.panel3.TabIndex = 0;
            // 
            // Savings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(474, 577);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Savings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings";
            this.Load += new System.EventHandler(this.Savings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel save_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker addedDate;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tb_currentAmount;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_targetAmount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button upload_btn;
    }
}