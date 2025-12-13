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
        Dashboard parent;
        public ExpensePreview(Dashboard parent, Users currentUser)
        {
            InitializeComponent();
            this.parent = parent;
            this.currentUser = currentUser;

            LoadData();
            LoadExpenseSummaries();
        }

        public void LoadData(string searchTerm = "")
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

                    searchTerm = searchTerm.ToLower();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        var filteredRows = dt.AsEnumerable()
                            .Where(row =>
                                row["Title"].ToString().ToLower().Contains(searchTerm) ||
                                row["Category"].ToString().ToLower().Contains(searchTerm)
                            );

                        dt = filteredRows.Any() ? filteredRows.CopyToDataTable() : dt.Clone();
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        ExpensePreviewControl preview = new ExpensePreviewControl(
                            this,
                            parent,
                            null,
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
        public void LoadExpenseSummaries()
        {
            decimal totalToday = 0;
            decimal totalWeek = 0;
            decimal totalMonth = 0;
            decimal totalAnnual = 0;

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

                // ANNUAL
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(CurrentAmount), 0)
                    FROM Budget
                    WHERE BudgetTypeID = 2
                    AND UserID = @UserID
                    AND YEAR(DateAdded) = YEAR(GETDATE())", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    totalAnnual = Convert.ToDecimal(cmd.ExecuteScalar());
                }

            }
            lblTotalToday.Text = $"Today's Expense: ₱{totalToday:N2}";
            lblTotalWeek.Text = $"Total Weekly Expense: ₱{totalWeek:N2}";
            lblTotalMonth.Text = $"Total Monthly Expense: ₱{totalMonth:N2}";
            lblTotalAnnual.Text = $"Total Annual Expense: ₱{totalAnnual:N2}";
        }

        public void RefreshExpenses()
        {
            previewPanel.Controls.Clear();
            LoadData();
            LoadExpenseSummaries();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_tb.Text.Trim().ToLower();
            previewPanel.Controls.Clear();
            LoadData(searchTerm);
        }
        private void ExpensePreview_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}