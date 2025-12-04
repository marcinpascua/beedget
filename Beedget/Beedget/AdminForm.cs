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
    public partial class AdminForm : Form
    {
        Users currentUser = null;

        public AdminForm(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn login = new LogIn();
            login.Show();
        }
    }
}
