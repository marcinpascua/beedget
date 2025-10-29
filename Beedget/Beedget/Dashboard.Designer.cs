namespace Beedget
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checklist_btn = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Panel();
            this.notif_btn = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.checklist_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.notif_btn);
            this.panel1.Location = new System.Drawing.Point(40, 687);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 100);
            this.panel1.TabIndex = 2;
            // 
            // checklist_btn
            // 
            this.checklist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checklist_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checklist_btn.BackgroundImage")));
            this.checklist_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checklist_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checklist_btn.Location = new System.Drawing.Point(329, 16);
            this.checklist_btn.Name = "checklist_btn";
            this.checklist_btn.Size = new System.Drawing.Size(58, 68);
            this.checklist_btn.TabIndex = 2;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btn.BackgroundImage")));
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Location = new System.Drawing.Point(207, 16);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(58, 68);
            this.add_btn.TabIndex = 1;
            this.add_btn.Paint += new System.Windows.Forms.PaintEventHandler(this.add_btn_Paint);
            // 
            // notif_btn
            // 
            this.notif_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notif_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notif_btn.BackgroundImage")));
            this.notif_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notif_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notif_btn.Location = new System.Drawing.Point(79, 16);
            this.notif_btn.Name = "notif_btn";
            this.notif_btn.Size = new System.Drawing.Size(58, 68);
            this.notif_btn.TabIndex = 0;
            // 
            // home_btn
            // 
            this.home_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_btn.BackgroundImage")));
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.Location = new System.Drawing.Point(71, 31);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(48, 40);
            this.home_btn.TabIndex = 3;
            this.home_btn.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Location = new System.Drawing.Point(450, 31);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(48, 44);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.TabStop = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 814);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel notif_btn;
        private System.Windows.Forms.Panel checklist_btn;
        private System.Windows.Forms.Panel add_btn;
        private System.Windows.Forms.PictureBox home_btn;
        private System.Windows.Forms.PictureBox logout_btn;
    }
}