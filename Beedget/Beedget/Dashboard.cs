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
        //private BeedgetEntities db = new BeedgetEntities();
        Users currentUser = null;

        public Dashboard(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        //LOG OUT BUTTON
        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }
    
        //SELECTION OF BUDGET BUTTON
        private void selection_btn_Click(object sender, EventArgs e)
        {
            var add = new OptionDialog(this, currentUser);
            add.Show();
        }

        //SAVINGS PANEL TO VIEW LIST OF SAVINGS
        private void savings_Click(object sender, EventArgs e)
        {
            SavingsPreview preview = new SavingsPreview(currentUser);
            preview.ShowDialog();
        }

        //EXPENSE PANEL TO VIEW LIST OF EXPENSES
        private void expense_Click(object sender, EventArgs e)
        {
            ExpensePreview preview = new ExpensePreview(currentUser);
            preview.ShowDialog();
        }

        //CHECKLIST OF ACHIEVED SAVINGS
        private void checklist_btn_Click(object sender, EventArgs e)
        {
            Checklist preview = new Checklist(currentUser);
            preview.ShowDialog();
        }
    }
}
