namespace Beedget
{
    partial class ExpensePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensePreview));
            this.previewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.expensePreviewControl1 = new Beedget.ExpensePreviewControl();
            this.previewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Controls.Add(this.expensePreviewControl1);
            this.previewPanel.Location = new System.Drawing.Point(12, 12);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(493, 497);
            this.previewPanel.TabIndex = 0;
            // 
            // expensePreviewControl1
            // 
            this.expensePreviewControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.expensePreviewControl1.Location = new System.Drawing.Point(3, 3);
            this.expensePreviewControl1.Name = "expensePreviewControl1";
            this.expensePreviewControl1.Size = new System.Drawing.Size(472, 198);
            this.expensePreviewControl1.TabIndex = 0;
            // 
            // ExpensePreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(520, 521);
            this.Controls.Add(this.previewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpensePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.ExpensePreview_Load);
            this.previewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel previewPanel;
        private ExpensePreviewControl expensePreviewControl1;
    }
}