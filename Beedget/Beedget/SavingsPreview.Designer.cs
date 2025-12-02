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
            this.savingsPreviewControl1 = new Beedget.SavingsPreviewControl();
            this.previewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Controls.Add(this.savingsPreviewControl1);
            this.previewPanel.Location = new System.Drawing.Point(6, 12);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(508, 497);
            this.previewPanel.TabIndex = 2;
            // 
            // savingsPreviewControl1
            // 
            this.savingsPreviewControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savingsPreviewControl1.Location = new System.Drawing.Point(3, 3);
            this.savingsPreviewControl1.Name = "savingsPreviewControl1";
            this.savingsPreviewControl1.Size = new System.Drawing.Size(472, 204);
            this.savingsPreviewControl1.TabIndex = 0;
            // 
            // SavingsPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(520, 521);
            this.Controls.Add(this.previewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavingsPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings";
            this.Load += new System.EventHandler(this.SavingsPreview_Load);
            this.previewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel previewPanel;
        private SavingsPreviewControl savingsPreviewControl1;
    }
}