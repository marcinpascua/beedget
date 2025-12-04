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
    public partial class AdminUsersControl : UserControl
    {
        Users currentUser = null;
        int UserID;

        public AdminUsersControl(Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.UserID = user.UserID;
            LoadData();
        }

        private void dashboard_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminUsersControl_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                }
            }
        }
    }
}
