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
    public partial class Dashboard: Form
    {
        private BeedgetEntities db = new BeedgetEntities();

        private Users currentUser = null;
        OptionDialog dialog = null;

        public Dashboard(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            dialog = new OptionDialog(currentUser);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

     
        private void add_button_Click(object sender, EventArgs e)
        {
            
            dialog.Show();
        }
        
    }
}
