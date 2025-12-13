namespace Beedget
{
    partial class CalendarExpensePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarExpensePreview));
            this.previewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalToday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Location = new System.Drawing.Point(12, 155);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(496, 406);
            this.previewPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daily Expense";
            // 
            // lblTotalToday
            // 
            this.lblTotalToday.AutoSize = true;
            this.lblTotalToday.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalToday.ForeColor = System.Drawing.Color.Olive;
            this.lblTotalToday.Location = new System.Drawing.Point(15, 84);
            this.lblTotalToday.Name = "lblTotalToday";
            this.lblTotalToday.Size = new System.Drawing.Size(179, 23);
            this.lblTotalToday.TabIndex = 7;
            this.lblTotalToday.Text = "Today\'s Total Expense:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search  ⌕";
            // 
            // search_tb
            // 
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_tb.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.ForeColor = System.Drawing.Color.Olive;
            this.search_tb.Location = new System.Drawing.Point(111, 119);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(375, 30);
            this.search_tb.TabIndex = 15;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // CalendarExpensePreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(520, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.lblTotalToday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarExpensePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarExpensePreview";
            this.Load += new System.EventHandler(this.CalendarExpensePreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel previewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_tb;
    }
}