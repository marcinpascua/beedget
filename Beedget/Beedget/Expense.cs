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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }

        private void tb_currentAmount_TextChanged(object sender, EventArgs e)
        {
            if (tb_currentAmount.Text == "Amount")
            {
                tb_currentAmount.Text = "";
            }
        }

        private void tb_title_TextChanged(object sender, EventArgs e)
        {
            if (tb_title.Text == "Title")
            {
                tb_title.Text = "";
            }
        }
    }
}
