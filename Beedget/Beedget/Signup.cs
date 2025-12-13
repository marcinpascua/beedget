using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Beedget
{
    public partial class Signup : Form
    {
        private static BeedgetEntities db = new BeedgetEntities();

        public Signup()
        {
            InitializeComponent();
        }

        //SIGN UP BUTTON
        private void signup_btn_Click(object sender, EventArgs e)
        {
            String username = tb_username.Text;
            String password = tb_password.Text;
            String confirmPassword = tb_confirmpass.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter all required fields. Thank You!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Incorrect password. Please try again.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingUser = db.Users.FirstOrDefault(u => u.Username == username);
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new Users
            {
                Username = username,
                Password = password,
                RoleID = 1
            };

            db.Users.Add(newUser);
            db.SaveChanges();
            MessageBox.Show("Account created successfully!", "Signup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LogIn login = new LogIn();
            login.Show();
            this.Hide();

        }

        //USERNAME TEXTBOX
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (tb_username.Text == "username")
            {
                tb_username.Text = "";
            }
        }

        //PASSWORD TEXTBOX
        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_password.Text == "password")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
                tb_password.PasswordChar = '•';
            }
        }

        //CONFIRM PASSWORD TEXTBOX
        private void tb_confirmpass_TextChanged(object sender, EventArgs e)
        {

            if (tb_confirmpass.Text == "confirm password")
            {
                tb_confirmpass.Text = "";
                tb_confirmpass.ForeColor = Color.Black;
                tb_confirmpass.PasswordChar = '•';
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        //GOES BACK TO LOG IN PAGE
        private void back_btn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }
    }
}

