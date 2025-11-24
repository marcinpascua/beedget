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
    public partial class SavingsPreviewControl : UserControl
    {
        string title = null;
        string category = null;
        string current_Amount = null;
        string target_Amount = null;
        string added_Date = null;
        string target_Date = null
            ;
        public SavingsPreviewControl(string title, string category, string current_Amount, string target_Amount, string added_Date, string target_Date)
        {
            InitializeComponent();
            this.title = title;
            this.category = category;
            this.current_Amount = current_Amount;
            this.target_Amount = target_Amount;
            this.added_Date = added_Date;
            this.target_Date = target_Date;
            LoadData();
        }

        private void LoadData()
        {
            title_label.Text = title;
            category_label.Text = category;
            currAmount.Text = "Php " + current_Amount;
            targetAmount.Text = "Php " +  target_Amount;
            addedDate.Text = added_Date;
            targetDate.Text = target_Date;
        }

        private void title_label_Click(object sender, EventArgs e)
        {
            
        }

        private void currAmount_Click(object sender, EventArgs e)
        {

        }

        private void category_label_Click(object sender, EventArgs e)
        {

        }
    }
}
