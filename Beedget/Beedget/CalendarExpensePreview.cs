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
    public partial class CalendarExpensePreview : Form
    {
        private Users currentUser;
        private DateTime selectedDate;
        Dashboard parent;

        public CalendarExpensePreview()
        {
            InitializeComponent();
        }

        public CalendarExpensePreview(Users currentUser, DateTime selectedDate, Dashboard parent)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.selectedDate = selectedDate;
            this.parent = parent;

            LoadExpensesForDate();
            LoadTotalDailyExpense();

        }

        public void LoadExpensesForDate(string searchTerm = "")
        {
            previewPanel.Controls.Clear();

            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Budget 
                             WHERE UserID = @UserID 
                             AND BudgetTypeID = 2 
                             AND CONVERT(date, DateAdded) = @SelectedDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);

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
                            null,               
                            parent,             
                            this,              
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

        // TOTAL DAILY EXPENSE (for selected date)
        public void LoadTotalDailyExpense()
        {
            decimal totalDaily = 0;

            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(CurrentAmount), 0)
                    FROM Budget
                    WHERE BudgetTypeID = 2
                    AND UserID = @UserID
                    AND CONVERT(date, DateAdded) = @SelectedDate", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);

                    totalDaily = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            lblTotalToday.Text = $"Total Expenses on {selectedDate:MMMM dd, yyyy}: ₱{totalDaily:N2}";
        }


        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_tb.Text.Trim().ToLower();
            previewPanel.Controls.Clear();
            LoadExpensesForDate(searchTerm);
        }

        private void CalendarExpensePreview_Load(object sender, EventArgs e)
        {

        }
    }
}
