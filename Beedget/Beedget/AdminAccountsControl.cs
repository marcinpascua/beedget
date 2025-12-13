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
    public partial class AdminAccountsControl : UserControl
    {
        string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

        Users currentUser = null;
        int UserID;

        public AdminAccountsControl(Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.UserID = user.UserID;
            LoadData();
        }

        private void dashboard_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Users.userID, Users.username, Users.password, Roles.RoleID, Roles.Rolename FROM Users INNER JOIN Roles ON Users.RoleID = Roles.RoleID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dashboard_data.DataSource = dt;

                    dashboard_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        //CREATE
        private void create_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string password = password_tb.Text;

            if (username == "")
            {
                MessageBox.Show("Please input username.");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please input password.");
                return;
            }

            if (roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string role = roleComboBox.SelectedItem.ToString();
            int roleID;

            if (role == "User")
            {
                roleID = 1;
            }
            else { 
                roleID = 2;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users(username, password, roleID) VALUES(@username, @password, @roleID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@roleID", roleID);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show(role + " account added successfully!");

            LoadData();
            username_tb.Clear();
            password_tb.Clear();
            roleComboBox.SelectedIndex = -1;
        }

       //UPDATE
        private void update_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string password = password_tb.Text;
            int userID;
            bool success = int.TryParse(userID_tb.Text, out userID);

            if (!success)
            {
                MessageBox.Show("Please enter a valid user ID to update.");
                return;
            }

            if (username == "" && password == "" && roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please input value to update");
                return;
            }

            int roleID = 0; 
            if (roleComboBox.SelectedItem != null)
            {
                roleID = (roleComboBox.SelectedItem.ToString() == "User") ? 1 : 2;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET ";

                if (username != "")
                    query += "username = @username, ";

                if (password != "")
                    query += "password = @password, ";

                if (roleComboBox.SelectedItem != null)
                    query += "roleID = @roleID, ";

                query = query.Trim().TrimEnd(',');

                query += " WHERE userID = @userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (username != "")
                        cmd.Parameters.AddWithValue("@username", username);

                    if (password != "")
                        cmd.Parameters.AddWithValue("@password", password);

                    if (roleComboBox.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@roleID", roleID);

                    cmd.Parameters.AddWithValue("@userID", userID);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("User ID: " + userID + " updated successfully!");

            LoadData();
            username_tb.Clear();
            password_tb.Clear();
            userID_tb.Clear();
        }

        //DELETE
        private void delete_btn_Click(object sender, EventArgs e)
        {
            int userID;
            bool success = int.TryParse(userID_tb.Text, out userID);

            if (!success)
            {
                MessageBox.Show("Please enter a valid user ID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE Users WHERE userID = @userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("User ID: " + userID + " deleted successfully!");

            LoadData();
            userID_tb.Clear();
        }

        private void AdminAccountsControl_Load(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
