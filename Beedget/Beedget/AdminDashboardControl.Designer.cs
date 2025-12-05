namespace Beedget
{
    partial class AdminDashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardControl));
            this.userNumPreview = new System.Windows.Forms.Panel();
            this.userNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminNumPreview = new System.Windows.Forms.Panel();
            this.adminNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userNumPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adminNumPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userNumPreview
            // 
            this.userNumPreview.AutoSize = true;
            this.userNumPreview.BackColor = System.Drawing.Color.White;
            this.userNumPreview.Controls.Add(this.userNum);
            this.userNumPreview.Controls.Add(this.label1);
            this.userNumPreview.Controls.Add(this.pictureBox1);
            this.userNumPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.userNumPreview.Location = new System.Drawing.Point(12, 51);
            this.userNumPreview.Name = "userNumPreview";
            this.userNumPreview.Size = new System.Drawing.Size(350, 327);
            this.userNumPreview.TabIndex = 0;
            // 
            // userNum
            // 
            this.userNum.AutoSize = true;
            this.userNum.Font = new System.Drawing.Font("Yu Gothic UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNum.ForeColor = System.Drawing.Color.Olive;
            this.userNum.Location = new System.Drawing.Point(109, 123);
            this.userNum.Name = "userNum";
            this.userNum.Size = new System.Drawing.Size(131, 159);
            this.userNum.TabIndex = 2;
            this.userNum.Text = "7";
            this.userNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNum.TextChanged += new System.EventHandler(this.userNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. of users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(232, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminNumPreview
            // 
            this.adminNumPreview.AutoSize = true;
            this.adminNumPreview.BackColor = System.Drawing.Color.White;
            this.adminNumPreview.Controls.Add(this.adminNum);
            this.adminNumPreview.Controls.Add(this.label3);
            this.adminNumPreview.Controls.Add(this.pictureBox2);
            this.adminNumPreview.Location = new System.Drawing.Point(437, 51);
            this.adminNumPreview.Name = "adminNumPreview";
            this.adminNumPreview.Size = new System.Drawing.Size(350, 327);
            this.adminNumPreview.TabIndex = 3;
            // 
            // adminNum
            // 
            this.adminNum.AutoSize = true;
            this.adminNum.Font = new System.Drawing.Font("Yu Gothic UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNum.ForeColor = System.Drawing.Color.Olive;
            this.adminNum.Location = new System.Drawing.Point(109, 123);
            this.adminNum.Name = "adminNum";
            this.adminNum.Size = new System.Drawing.Size(134, 159);
            this.adminNum.TabIndex = 2;
            this.adminNum.Text = "2";
            this.adminNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "No. of admins";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(232, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 92);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // AdminDashboardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.adminNumPreview);
            this.Controls.Add(this.userNumPreview);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(800, 430);
            this.Load += new System.EventHandler(this.AdminDashboardControl_Load);
            this.userNumPreview.ResumeLayout(false);
            this.userNumPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.adminNumPreview.ResumeLayout(false);
            this.adminNumPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel userNumPreview;
        private System.Windows.Forms.Label userNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel adminNumPreview;
        private System.Windows.Forms.Label adminNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
