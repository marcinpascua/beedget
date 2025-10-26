using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void signup_link_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String username = tb_username.Text;
            String password = tb_password.Text;

            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            
            if (tb_username.Text == "username") { 
                tb_username.Text = "";
            }


        }

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
