namespace Beedget
{
    partial class Checklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checklist));
            this.label1 = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalMonth = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checklist ✓";
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.previewPanel.Location = new System.Drawing.Point(12, 113);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(496, 448);
            this.previewPanel.TabIndex = 1;
            // 
            // lblTotalMonth
            // 
            this.lblTotalMonth.AutoSize = true;
            this.lblTotalMonth.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalMonth.ForeColor = System.Drawing.Color.Olive;
            this.lblTotalMonth.Location = new System.Drawing.Point(15, 79);
            this.lblTotalMonth.Name = "lblTotalMonth";
            this.lblTotalMonth.Size = new System.Drawing.Size(85, 23);
            this.lblTotalMonth.TabIndex = 15;
            this.lblTotalMonth.Text = "Search  ⌕";
            // 
            // search_tb
            // 
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_tb.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.ForeColor = System.Drawing.Color.Olive;
            this.search_tb.Location = new System.Drawing.Point(106, 77);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(379, 30);
            this.search_tb.TabIndex = 14;
            this.search_tb.Text = " ";
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // Checklist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(520, 573);
            this.Controls.Add(this.lblTotalMonth);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Checklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checklist";
            this.Load += new System.EventHandler(this.Checklist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel previewPanel;
        private System.Windows.Forms.Label lblTotalMonth;
        private System.Windows.Forms.TextBox search_tb;
    }
}