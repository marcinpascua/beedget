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
            this.panel2 = new System.Windows.Forms.Panel();
            this.savings = new System.Windows.Forms.Button();
            this.expense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.selection_btn);
            this.panel1.Controls.Add(this.checklist_btn);
            this.panel1.Controls.Add(this.logout_btn);
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
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Location = new System.Drawing.Point(352, 16);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(70, 70);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 79);
            this.panel2.TabIndex = 5;
            // 
            // savings
            // 
            this.savings.BackColor = System.Drawing.Color.LemonChiffon;
            this.savings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savings.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savings.Location = new System.Drawing.Point(28, 215);
            this.savings.Name = "savings";
            this.savings.Size = new System.Drawing.Size(491, 160);
            this.savings.TabIndex = 7;
            this.savings.Text = "Savings";
            this.savings.UseVisualStyleBackColor = false;
            this.savings.Click += new System.EventHandler(this.savings_Click);
            // 
            // expense
            // 
            this.expense.BackColor = System.Drawing.Color.DarkKhaki;
            this.expense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expense.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense.Location = new System.Drawing.Point(28, 400);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(491, 160);
            this.expense.TabIndex = 8;
            this.expense.Text = "Expense";
            this.expense.UseVisualStyleBackColor = false;
            this.expense.Click += new System.EventHandler(this.expense_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 814);
            this.Controls.Add(this.expense);
            this.Controls.Add(this.savings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logout_btn;
        private System.Windows.Forms.Panel checklist_btn;
        private System.Windows.Forms.Panel add_btn;
        private System.Windows.Forms.Panel selection_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button savings;
        private System.Windows.Forms.Button expense;
    }
}