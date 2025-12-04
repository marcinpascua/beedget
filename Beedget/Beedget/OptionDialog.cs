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
    public partial class OptionDialog : Form
    {
        Dashboard parent;
        private Users currentUser = null;

        public OptionDialog(Dashboard parent, Users currentUser)
        {
            InitializeComponent();
            this.parent = parent;
            this.currentUser = currentUser;
        }

        private void OptionDialog_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        //EXPENSE BUTTON 
        private void expense_btn_Click(object sender, EventArgs e)
        {
            Expense expenseForm = new Expense(parent, currentUser);
            this.Hide();
            expenseForm.Show();
        }
    
        //SAVINGS BUTTON
        private void savings_btn_Click(object sender, EventArgs e)
        {
            Savings savingsForm = new Savings(parent, currentUser);
            this.Hide();
            savingsForm.Show();
        }

      
        private void OptionDialog_Load(object sender, EventArgs e)
        {

        }

      
    }
}
