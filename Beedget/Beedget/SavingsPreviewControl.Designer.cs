namespace Beedget
{
    partial class SavingsPreviewControl
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
            this.title_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.current_lbl = new System.Windows.Forms.Label();
            this.target_lbl = new System.Windows.Forms.Label();
            this.addedDate = new System.Windows.Forms.Label();
            this.currAmount = new System.Windows.Forms.Label();
            this.targetAmount = new System.Windows.Forms.Label();
            this.targetDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 75);
            this.panel1.TabIndex = 20;
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
            this.category_label.Font = new System.Drawing.Font("Yu Gothic UI Light", 11F, System.Drawing.FontStyle.Italic);
            this.category_label.ForeColor = System.Drawing.Color.Azure;
            this.category_label.Location = new System.Drawing.Point(15, 47);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(86, 25);
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
            // current_lbl
            // 
            this.current_lbl.AutoSize = true;
            this.current_lbl.BackColor = System.Drawing.Color.Transparent;
            this.current_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_lbl.ForeColor = System.Drawing.Color.Black;
            this.current_lbl.Location = new System.Drawing.Point(13, 90);
            this.current_lbl.Name = "current_lbl";
            this.current_lbl.Size = new System.Drawing.Size(90, 31);
            this.current_lbl.TabIndex = 18;
            this.current_lbl.Text = "Current";
            // 
            // target_lbl
            // 
            this.target_lbl.AutoSize = true;
            this.target_lbl.BackColor = System.Drawing.Color.Transparent;
            this.target_lbl.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_lbl.ForeColor = System.Drawing.Color.Black;
            this.target_lbl.Location = new System.Drawing.Point(13, 121);
            this.target_lbl.Name = "target_lbl";
            this.target_lbl.Size = new System.Drawing.Size(78, 31);
            this.target_lbl.TabIndex = 19;
            this.target_lbl.Text = "Target";
            // 
            // addedDate
            // 
            this.addedDate.AutoSize = true;
            this.addedDate.BackColor = System.Drawing.Color.Transparent;
            this.addedDate.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.2F);
            this.addedDate.ForeColor = System.Drawing.Color.Black;
            this.addedDate.Location = new System.Drawing.Point(15, 161);
            this.addedDate.Name = "addedDate";
            this.addedDate.Size = new System.Drawing.Size(164, 23);
            this.addedDate.TabIndex = 16;
            this.addedDate.Text = "Added Date: 11/01/25";
            // 
            // currAmount
            // 
            this.currAmount.AutoSize = true;
            this.currAmount.BackColor = System.Drawing.Color.Transparent;
            this.currAmount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.currAmount.Location = new System.Drawing.Point(321, 90);
            this.currAmount.Name = "currAmount";
            this.currAmount.Size = new System.Drawing.Size(140, 31);
            this.currAmount.TabIndex = 22;
            this.currAmount.Text = "Php 1000.00";
            // 
            // targetAmount
            // 
            this.targetAmount.AutoSize = true;
            this.targetAmount.BackColor = System.Drawing.Color.Transparent;
            this.targetAmount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.targetAmount.Location = new System.Drawing.Point(321, 121);
            this.targetAmount.Name = "targetAmount";
            this.targetAmount.Size = new System.Drawing.Size(144, 31);
            this.targetAmount.TabIndex = 23;
            this.targetAmount.Text = "Php 2000.00";
            // 
            // targetDate
            // 
            this.targetDate.AutoSize = true;
            this.targetDate.BackColor = System.Drawing.Color.Transparent;
            this.targetDate.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.2F);
            this.targetDate.ForeColor = System.Drawing.Color.Black;
            this.targetDate.Location = new System.Drawing.Point(303, 161);
            this.targetDate.Name = "targetDate";
            this.targetDate.Size = new System.Drawing.Size(162, 23);
            this.targetDate.TabIndex = 24;
            this.targetDate.Text = "Target Date: 12/01/25";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.targetDate);
            this.panel2.Controls.Add(this.targetAmount);
            this.panel2.Controls.Add(this.currAmount);
            this.panel2.Controls.Add(this.addedDate);
            this.panel2.Controls.Add(this.target_lbl);
            this.panel2.Controls.Add(this.current_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 196);
            this.panel2.TabIndex = 23;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.edit_btn.Location = new System.Drawing.Point(279, 92);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(36, 29);
            this.edit_btn.TabIndex = 25;
            this.edit_btn.Text = "✎";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // SavingsPreviewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SavingsPreviewControl";
            this.Size = new System.Drawing.Size(472, 204);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label current_lbl;
        private System.Windows.Forms.Label target_lbl;
        private System.Windows.Forms.Label addedDate;
        private System.Windows.Forms.Label currAmount;
        private System.Windows.Forms.Label targetAmount;
        private System.Windows.Forms.Label targetDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button edit_btn;
    }
}
