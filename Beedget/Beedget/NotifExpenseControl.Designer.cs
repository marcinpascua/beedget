namespace Beedget
{
    partial class NotifExpenseControl
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
            this.expenseMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // expenseMessage
            // 
            this.expenseMessage.AutoSize = true;
            this.expenseMessage.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
            this.expenseMessage.Location = new System.Drawing.Point(77, 43);
            this.expenseMessage.Name = "expenseMessage";
            this.expenseMessage.Size = new System.Drawing.Size(62, 19);
            this.expenseMessage.TabIndex = 3;
            this.expenseMessage.Text = "message";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 53);
            this.panel1.TabIndex = 2;
            // 
            // NotifExpenseControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.expenseMessage);
            this.Controls.Add(this.panel1);
            this.Name = "NotifExpenseControl";
            this.Size = new System.Drawing.Size(463, 104);
            this.Load += new System.EventHandler(this.NotifExpenseControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseMessage;
        private System.Windows.Forms.Panel panel1;
    }
}
