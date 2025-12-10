namespace Beedget
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selection_btn = new System.Windows.Forms.Panel();
            this.checklist_btn = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Panel();
            this.calendarExpenses = new System.Windows.Forms.MonthCalendar();
            this.history_btn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Expense = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 85);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.history_btn);
            this.panel1.Controls.Add(this.selection_btn);
            this.panel1.Controls.Add(this.checklist_btn);
            this.panel1.Location = new System.Drawing.Point(28, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 100);
            this.panel1.TabIndex = 2;
            // 
            // selection_btn
            // 
            this.selection_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selection_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selection_btn.BackgroundImage")));
            this.selection_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selection_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selection_btn.Location = new System.Drawing.Point(213, 16);
            this.selection_btn.Name = "selection_btn";
            this.selection_btn.Size = new System.Drawing.Size(70, 70);
            this.selection_btn.TabIndex = 1;
            this.selection_btn.Click += new System.EventHandler(this.selection_btn_Click);
            // 
            // checklist_btn
            // 
            this.checklist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checklist_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checklist_btn.BackgroundImage")));
            this.checklist_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checklist_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checklist_btn.Location = new System.Drawing.Point(73, 16);
            this.checklist_btn.Name = "checklist_btn";
            this.checklist_btn.Size = new System.Drawing.Size(70, 70);
            this.checklist_btn.TabIndex = 2;
            this.checklist_btn.Click += new System.EventHandler(this.checklist_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Location = new System.Drawing.Point(461, 34);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(45, 47);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.Paint += new System.Windows.Forms.PaintEventHandler(this.logout_btn_Paint);
            // 
            // calendarExpenses
            // 
            this.calendarExpenses.Location = new System.Drawing.Point(9, 9);
            this.calendarExpenses.Name = "calendarExpenses";
            this.calendarExpenses.TabIndex = 9;
            this.calendarExpenses.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarExpenses_DateChanged);
            this.calendarExpenses.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarExpenses_DateSelected);
            // 
            // history_btn
            // 
            this.history_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.history_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("history_btn.BackgroundImage")));
            this.history_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.history_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history_btn.Location = new System.Drawing.Point(353, 16);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(70, 70);
            this.history_btn.TabIndex = 1;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(28, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 196);
            this.panel2.TabIndex = 11;
            this.panel2.Click += new System.EventHandler(this.savings_Click);
            // 
            // Expense
            // 
            this.Expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Expense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Expense.BackgroundImage")));
            this.Expense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Expense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Expense.Location = new System.Drawing.Point(289, 441);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(230, 196);
            this.Expense.TabIndex = 12;
            this.Expense.Click += new System.EventHandler(this.expense_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(274, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 97);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(377, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 97);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.calendarExpenses);
            this.panel5.Location = new System.Drawing.Point(28, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 231);
            this.panel5.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 814);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Expense);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logout_btn;
        private System.Windows.Forms.Panel checklist_btn;
        private System.Windows.Forms.Panel add_btn;
        private System.Windows.Forms.Panel selection_btn;
        private System.Windows.Forms.MonthCalendar calendarExpenses;
        private System.Windows.Forms.Panel history_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Expense;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}