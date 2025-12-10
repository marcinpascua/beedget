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
    public partial class NotifExpenseControl : UserControl
    {
        public NotifExpenseControl(string title, DateTime date)
        {
            InitializeComponent();
            expenseMessage.Text = $"You added \"{title}\" expense on {date:g}";

        }

        private void NotifExpenseControl_Load(object sender, EventArgs e)
        {

        }
    }
}
