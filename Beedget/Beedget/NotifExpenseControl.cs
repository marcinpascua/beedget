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
        public NotifExpenseControl(string title, DateTime date, string action = "Added", string details = "")
        {
            InitializeComponent();

            string actionText;

            switch (action)
            {
                case "Added":
                    actionText = "You added";
                    break;
                case "Deleted":
                    actionText = "You deleted";
                    break;
                case "Updated":
                    actionText = "You updated";
                    break;
                default:
                    actionText = "Activity";
                    break;
            }

            if (string.IsNullOrEmpty(details))
                expenseMessage.Text = $"{actionText} \"{title}\" expense on {date:g}";
            else
                expenseMessage.Text = $"{actionText} \"{title}\" expense on {date:g}. {details}";
        }

        private void NotifExpenseControl_Load(object sender, EventArgs e)
        {

        }
    }
}
