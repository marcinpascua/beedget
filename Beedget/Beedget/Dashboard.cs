﻿using System;
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

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

      

        private void add_button_Click(object sender, EventArgs e)
        {
            OptionDialog dialog = new OptionDialog();
            dialog.Show();
        }

        
    }
}
