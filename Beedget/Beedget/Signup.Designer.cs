namespace Beedget
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Label();
            this.tb_confirmpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.PictureBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.PictureBox();
            this.username_bg = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signup_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.tb_confirmpass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.password_tb);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.username_bg);
            this.panel1.Controls.Add(this.username_label);
            this.panel1.Location = new System.Drawing.Point(61, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 377);
            this.panel1.TabIndex = 8;
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold);
            this.back_btn.Location = new System.Drawing.Point(23, 326);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 37);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "< back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // tb_confirmpass
            // 
            this.tb_confirmpass.BackColor = System.Drawing.Color.White;
            this.tb_confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirmpass.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.tb_confirmpass.ForeColor = System.Drawing.Color.Black;
            this.tb_confirmpass.Location = new System.Drawing.Point(66, 181);
            this.tb_confirmpass.Margin = new System.Windows.Forms.Padding(5);
            this.tb_confirmpass.Name = "tb_confirmpass";
            this.tb_confirmpass.Size = new System.Drawing.Size(316, 36);
            this.tb_confirmpass.TabIndex = 13;
            this.tb_confirmpass.Text = "confirm password";
            this.tb_confirmpass.Click += new System.EventHandler(this.tb_confirmpass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(20, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 74);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(66, 102);
            this.tb_password.Margin = new System.Windows.Forms.Padding(5);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(316, 36);
            this.tb_password.TabIndex = 11;
            this.tb_password.Text = "password";
            this.tb_password.Click += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // password_tb
            // 
            this.password_tb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password_tb.BackgroundImage")));
            this.password_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.password_tb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_tb.Location = new System.Drawing.Point(20, 83);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(372, 74);
            this.password_tb.TabIndex = 10;
            this.password_tb.TabStop = false;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.White;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Yu Gothic UI", 16F);
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(66, 22);
            this.tb_username.Margin = new System.Windows.Forms.Padding(5);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(316, 36);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "username";
            this.tb_username.Click += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup_btn.BackgroundImage")));
            this.signup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.Location = new System.Drawing.Point(20, 243);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(372, 80);
            this.signup_btn.TabIndex = 8;
            this.signup_btn.TabStop = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // username_bg
            // 
            this.username_bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username_bg.BackgroundImage")));
            this.username_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.username_bg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username_bg.Location = new System.Drawing.Point(20, 3);
            this.username_bg.Name = "username_bg";
            this.username_bg.Size = new System.Drawing.Size(372, 74);
            this.username_bg.TabIndex = 9;
            this.username_bg.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(3, 11);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(0, 28);
            this.username_label.TabIndex = 1;
            // 
            // Signup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 814);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signup_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_bg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox password_tb;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox signup_btn;
        private System.Windows.Forms.PictureBox username_bg;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_confirmpass;
        private System.Windows.Forms.Label back_btn;
    }
}