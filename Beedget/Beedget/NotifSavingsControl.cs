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
    public partial class NotifSavingsControl : UserControl
    {
        public NotifSavingsControl(string title, DateTime date)
        {
            InitializeComponent();
            savingsMessage.Text = $"You added \"{title}\" savings budget on {date:g}";
        }

        private void budgetMessage_Click(object sender, EventArgs e)
        {

        }

        private void NotifSavingsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
