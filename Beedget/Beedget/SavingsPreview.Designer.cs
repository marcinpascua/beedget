namespace Beedget
{
    partial class SavingsPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsPreview));
            this.previewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.lblTotalMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.previewPanel.Location = new System.Drawing.Point(12, 148);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(496, 411);
            this.previewPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Savings";
            // 
            // search_tb
            // 
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_tb.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.ForeColor = System.Drawing.Color.Olive;
            this.search_tb.Location = new System.Drawing.Point(103, 98);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(379, 30);
            this.search_tb.TabIndex = 12;
            this.search_tb.Text = " ";
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // lblTotalMonth
            // 
            this.lblTotalMonth.AutoSize = true;
            this.lblTotalMonth.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalMonth.ForeColor = System.Drawing.Color.Olive;
            this.lblTotalMonth.Location = new System.Drawing.Point(12, 100);
            this.lblTotalMonth.Name = "lblTotalMonth";
            this.lblTotalMonth.Size = new System.Drawing.Size(85, 23);
            this.lblTotalMonth.TabIndex = 13;
            this.lblTotalMonth.Text = "Search  ⌕";
            // 
            // SavingsPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(520, 573);
            this.Controls.Add(this.lblTotalMonth);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingsPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings";
            this.Load += new System.EventHandler(this.SavingsPreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel previewPanel;
        private SavingsPreviewControl savingsPreviewControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Label lblTotalMonth;
    }
}