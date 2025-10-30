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
        private BeedgetEntities db = new BeedgetEntities();

        public OptionDialog()
        {
            InitializeComponent();
           
        }

        private void OptionDialog_Shown(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            this.Hide();
            dashboardForm.Show();
        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            Expense expenseForm = new Expense();
            this.Hide();
            expenseForm.Show();
        }
    
        private void savings_btn_Click(object sender, EventArgs e)
        {
            Savings savingsForm = new Savings();
            this.Hide();
            savingsForm.Show();
        }

        private void savings_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expense_btn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
