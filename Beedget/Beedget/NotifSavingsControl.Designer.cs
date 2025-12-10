namespace Beedget
{
    partial class NotifSavingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.savingsMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 53);
            this.panel1.TabIndex = 0;
            // 
            // savingsMessage
            // 
            this.savingsMessage.AutoSize = true;
            this.savingsMessage.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.savingsMessage.Location = new System.Drawing.Point(77, 43);
            this.savingsMessage.Name = "savingsMessage";
            this.savingsMessage.Size = new System.Drawing.Size(62, 19);
            this.savingsMessage.TabIndex = 1;
            this.savingsMessage.Text = "message";
            this.savingsMessage.Click += new System.EventHandler(this.budgetMessage_Click);
            // 
            // NotifSavingsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.savingsMessage);
            this.Controls.Add(this.panel1);
            this.Name = "NotifSavingsControl";
            this.Size = new System.Drawing.Size(463, 104);
            this.Load += new System.EventHandler(this.NotifSavingsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label savingsMessage;
    }
}
