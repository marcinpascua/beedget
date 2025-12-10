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
    public partial class ExpensePreview : Form
    {
        private Users currentUser = null;

        public ExpensePreview(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            LoadData();
            LoadExpenseSummaries();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Budget WHERE UserID = @UserID AND BudgetTypeID = 2";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ExpensePreviewControl preview = new ExpensePreviewControl(
                            row["Title"].ToString(),
                            row["Category"].ToString(),
                            row["CurrentAmount"].ToString(),
                            row["DateAdded"].ToString(),
                            Convert.ToInt32(row["BudgetID"])
                        );

                        preview.Dock = DockStyle.Top;
                        previewPanel.Controls.Add(preview);
                    }
                }
            }
        }

        //EXPENSE SUMMARY
        private void LoadExpenseSummaries()
        {
            decimal totalToday = 0;
            decimal totalWeek = 0;
            decimal totalMonth = 0;

            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //DAILY
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(CurrentAmount),0)
              FROM Budget
              WHERE BudgetTypeID = 2 
              AND UserID = @UserID
              AND CAST(DateAdded AS DATE) = CAST(GETDATE() AS DATE)", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    totalToday = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                //WEEK
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(CurrentAmount),0)
              FROM Budget
              WHERE BudgetTypeID = 2
              AND UserID = @UserID
              AND DATEPART(WEEK, DateAdded) = DATEPART(WEEK, GETDATE())
              AND DATEPART(YEAR, DateAdded) = DATEPART(YEAR, GETDATE())", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    totalWeek = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                //MONTH
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(CurrentAmount),0)
              FROM Budget
              WHERE BudgetTypeID = 2
              AND UserID = @UserID
              AND MONTH(DateAdded) = MONTH(GETDATE())
              AND YEAR(DateAdded) = YEAR(GETDATE())", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    totalMonth = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            lblTotalToday.Text = $"Today's Expense: ₱{totalToday:N2}";
            lblTotalWeek.Text = $"Total Weekly Expense: ₱{totalWeek:N2}";
            lblTotalMonth.Text = $"Total Monthly Expense: ₱{totalMonth:N2}";
        }



        private void ExpensePreview_Load(object sender, EventArgs e)
        {

        }
    }
}
