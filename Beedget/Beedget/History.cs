using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Beedget
{
    public partial class History : Form
    {
        private Users currentUser;

        public History(Users user)
        {
            InitializeComponent();
            currentUser = user;
            LoadHistory();
        }

        private void LoadHistory()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT Title, DateAdded, BudgetTypeID
                FROM Budget
                WHERE UserID = @UserID
                ORDER BY DateAdded DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    previewPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();
                        DateTime date = Convert.ToDateTime(reader["DateAdded"]);
                        int typeID = Convert.ToInt32(reader["BudgetTypeID"]);

                        UserControl notifControl;

                        if (typeID == 1)
                        {
                            notifControl = new NotifSavingsControl(title, date);
                        }
                        else
                        {
                            notifControl = new NotifExpenseControl(title, date);
                        }

                        notifControl.Dock = DockStyle.Top;
                        previewPanel.Controls.Add(notifControl);
                    }
                }
            }
        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
