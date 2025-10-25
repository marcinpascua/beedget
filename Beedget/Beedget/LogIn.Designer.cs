namespace Beedget
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.username_label = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signup_link = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.PictureBox();
            this.username_bg = new System.Windows.Forms.PictureBox();
            this.subheader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_btn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subheader)).BeginInit();
            this.SuspendLayout();
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
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.White;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(66, 20);
            this.tb_username.Margin = new System.Windows.Forms.Padding(5);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(316, 31);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "username";
            this.tb_username.Click += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(110, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 220);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.password_tb);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.username_bg);
            this.panel1.Controls.Add(this.username_label);
            this.panel1.Location = new System.Drawing.Point(64, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 295);
            this.panel1.TabIndex = 7;
            // 
            // login_btn
            // 
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Location = new System.Drawing.Point(20, 163);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(372, 79);
            this.login_btn.TabIndex = 10;
            this.login_btn.TabStop = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signup_link);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 46);
            this.panel2.TabIndex = 10;
            // 
            // signup_link
            // 
            this.signup_link.AutoSize = true;
            this.signup_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_link.Location = new System.Drawing.Point(270, 5);
            this.signup_link.Name = "signup_link";
            this.signup_link.Size = new System.Drawing.Size(81, 22);
            this.signup_link.TabIndex = 8;
            this.signup_link.Text = "Sign Up";
            this.signup_link.Click += new System.EventHandler(this.signup_link_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Don\'t have an account?";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(66, 104);
            this.tb_password.Margin = new System.Windows.Forms.Padding(5);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(316, 31);
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
            // subheader
            // 
            this.subheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.subheader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subheader.BackgroundImage")));
            this.subheader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subheader.Location = new System.Drawing.Point(110, 282);
            this.subheader.Name = "subheader";
            this.subheader.Size = new System.Drawing.Size(315, 32);
            this.subheader.TabIndex = 8;
            this.subheader.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(546, 814);
            this.Controls.Add(this.subheader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beedget | Log in";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subheader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox username_bg;
        private System.Windows.Forms.PictureBox password_tb;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label signup_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox login_btn;
        private System.Windows.Forms.PictureBox subheader;
    }
}

