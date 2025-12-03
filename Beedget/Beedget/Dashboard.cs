using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beedget
{
    public partial class Dashboard : Form
    {
        private BeedgetEntities db = new BeedgetEntities();
        Users currentUser = null;

        public Dashboard(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }
    
        private void selection_btn_Click(object sender, EventArgs e)
        {
            var add = new OptionDialog(this, currentUser);
            add.Show();
        }

        private void savings_Click(object sender, EventArgs e)
        {
            SavingsPreview preview = new SavingsPreview(currentUser);
            preview.ShowDialog();
        }

        private void expense_Click(object sender, EventArgs e)
        {
            ExpensePreview preview = new ExpensePreview(currentUser);
            preview.ShowDialog();
        }

        private void checklist_btn_Click(object sender, EventArgs e)
        {
            Checklist preview = new Checklist();
            preview.ShowDialog();
        }
    }
}
