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
    public partial class AdminDashboardControl : UserControl
    {

        Users currentUser = null;
        public AdminDashboardControl(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadUserCount();
            LoadAdminCount();
        }

        private void dashboard_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadUserCount()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE RoleID = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    userNum.Text = count.ToString();
                }
            }
        }

        private void LoadAdminCount()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE RoleID = 2";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    adminNum.Text = count.ToString();
                }
            }
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {

        }

        private void userNum_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
