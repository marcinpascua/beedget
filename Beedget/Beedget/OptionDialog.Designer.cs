namespace Beedget
{
    partial class OptionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.expense_btn = new System.Windows.Forms.Panel();
            this.savings_btn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.expense_btn);
            this.panel1.Controls.Add(this.savings_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 225);
            this.panel1.TabIndex = 0;
            // 
            // expense_btn
            // 
            this.expense_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("expense_btn.BackgroundImage")));
            this.expense_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.expense_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expense_btn.Location = new System.Drawing.Point(260, 143);
            this.expense_btn.Name = "expense_btn";
            this.expense_btn.Size = new System.Drawing.Size(190, 79);
            this.expense_btn.TabIndex = 2;
            this.expense_btn.Click += new System.EventHandler(this.expense_btn_Click);
            // 
            // savings_btn
            // 
            this.savings_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savings_btn.BackgroundImage")));
            this.savings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.savings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savings_btn.Location = new System.Drawing.Point(12, 143);
            this.savings_btn.Name = "savings_btn";
            this.savings_btn.Size = new System.Drawing.Size(190, 79);
            this.savings_btn.TabIndex = 1;
            this.savings_btn.Click += new System.EventHandler(this.savings_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 109);
            this.panel2.TabIndex = 0;
            // 
            // OptionDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(476, 255);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.OptionDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel expense_btn;
        private System.Windows.Forms.Panel savings_btn;
        private System.Windows.Forms.Panel panel2;
    }
}