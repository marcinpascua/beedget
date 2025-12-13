using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beedget
{
    public partial class LogIn : Form
    {
        private BeedgetEntities db = new BeedgetEntities();

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        public static void LoadData()
        {

        }

        //SIGN UP BUTTON
        private void signup_link_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

        //LOG IN BUTTON
        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all required fields. Thank you!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // USER SIDE (1)
                if (user.RoleID == 1)
                {
                    Dashboard dashboardForm = new Dashboard(user);
                    dashboardForm.Show();
                    this.Hide();
                }
                // ADMIN SIDE (2)
                else if (user.RoleID == 2)
                {
                    AdminForm adminForm = new AdminForm(user);
                    adminForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

       
    }
}