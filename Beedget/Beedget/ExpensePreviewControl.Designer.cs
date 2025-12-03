namespace Beedget
{
    partial class ExpensePreviewControl
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
            this.title_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addedDate = new System.Windows.Forms.Label();
            this.current_lbl = new System.Windows.Forms.Label();
            this.currAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(11, 7);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(87, 46);
            this.title_label.TabIndex = 15;
            this.title_label.Text = "Title";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.BackColor = System.Drawing.Color.Transparent;
            this.category_label.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.category_label.ForeColor = System.Drawing.Color.Azure;
            this.category_label.Location = new System.Drawing.Point(15, 47);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(88, 28);
            this.category_label.TabIndex = 14;
            this.category_label.Text = "Category";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.White;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(364, 20);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(85, 33);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 75);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.addedDate);
            this.panel2.Controls.Add(this.current_lbl);
            this.panel2.Controls.Add(this.currAmount);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 192);
            this.panel2.TabIndex = 22;
            // 
            // addedDate
            // 
            this.addedDate.AutoSize = true;
            this.addedDate.BackColor = System.Drawing.Color.Transparent;
            this.addedDate.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.addedDate.ForeColor = System.Drawing.Color.Black;
            this.addedDate.Location = new System.Drawing.Point(14, 149);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(227, 32);
            this.addedDate.TabIndex = 25;
            this.addedDate.Text = "Added Date: 11/01/25";
            // 
            // current_lbl
            // 
            this.current_lbl.AutoSize = true;
            this.current_lbl.BackColor = System.Drawing.Color.Transparent;
            this.current_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.current_lbl.ForeColor = System.Drawing.Color.Black;
            this.current_lbl.Location = new System.Drawing.Point(13, 94);
            this.current_lbl.Name = "current_lbl";
            this.current_lbl.Size = new System.Drawing.Size(125, 41);
            this.current_lbl.TabIndex = 24;
            this.current_lbl.Text = "Amount";
            // 
            // currAmount
            // 
            this.currAmount.AutoSize = true;
            this.currAmount.BackColor = System.Drawing.Color.Transparent;
            this.currAmount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.currAmount.ForeColor = System.Drawing.Color.Black;
            this.currAmount.Location = new System.Drawing.Point(280, 94);
            this.currAmount.Name = "currAmount";
            this.currAmount.Size = new System.Drawing.Size(183, 41);
            this.currAmount.TabIndex = 23;
            this.currAmount.Text = "Php 1000.00";
            // 
            // ExpensePreviewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Name = "ExpensePreviewControl";
            this.Size = new System.Drawing.Size(472, 198);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currAmount;
        private System.Windows.Forms.Label current_lbl;
        private System.Windows.Forms.Label addedDate;
    }
}
