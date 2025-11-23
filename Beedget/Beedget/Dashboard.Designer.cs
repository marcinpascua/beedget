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
            this.add_button = new System.Windows.Forms.Panel();
            this.checklist_btn = new System.Windows.Forms.Panel();
            this.notif_btn = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.checklist_btn);
            this.panel1.Controls.Add(this.notif_btn);
            this.panel1.Location = new System.Drawing.Point(28, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 100);
            this.panel1.TabIndex = 2;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button.BackgroundImage")));
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.Location = new System.Drawing.Point(213, 16);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(70, 70);
            this.add_button.TabIndex = 1;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // checklist_btn
            // 
            this.checklist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checklist_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checklist_btn.BackgroundImage")));
            this.checklist_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checklist_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checklist_btn.Location = new System.Drawing.Point(344, 16);
            this.checklist_btn.Name = "checklist_btn";
            this.checklist_btn.Size = new System.Drawing.Size(70, 70);
            this.checklist_btn.TabIndex = 2;
            // 
            // notif_btn
            // 
            this.notif_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notif_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notif_btn.BackgroundImage")));
            this.notif_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notif_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notif_btn.Location = new System.Drawing.Point(77, 16);
            this.notif_btn.Name = "notif_btn";
            this.notif_btn.Size = new System.Drawing.Size(70, 70);
            this.notif_btn.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Location = new System.Drawing.Point(460, 23);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(48, 44);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.TabStop = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 79);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 594);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 814);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logout_btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel notif_btn;
        private System.Windows.Forms.Panel checklist_btn;
        private System.Windows.Forms.Panel add_btn;
        private System.Windows.Forms.PictureBox logout_btn;
        private System.Windows.Forms.Panel add_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}