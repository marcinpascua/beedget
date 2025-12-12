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
    public partial class Dashboard : Form
    {
        Users currentUser = null;

        public Dashboard(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadSavingsNum();
            LoadexpenseNum();
            HighlightExpenseDates();
        }

        //LOG OUT BUTTON
        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        //SELECTION OF BUDGET BUTTON
        private void selection_btn_Click(object sender, EventArgs e)
        {
            var add = new OptionDialog(this, currentUser);
            add.Show();
        }

        //SAVINGS PANEL TO VIEW LIST OF SAVINGS
        private void savings_Click(object sender, EventArgs e)
        {
            SavingsPreview preview = new SavingsPreview(this, currentUser);
            preview.ShowDialog();
        }

        //EXPENSE PANEL TO VIEW LIST OF EXPENSES
        private void expense_Click(object sender, EventArgs e)
        {
            ExpensePreview preview = new ExpensePreview(this, currentUser);
            preview.ShowDialog();
        }

        //CHECKLIST OF ACHIEVED SAVINGS
        private void checklist_btn_Click(object sender, EventArgs e)
        {
            Checklist preview = new Checklist(this, currentUser);
            preview.ShowDialog();
        }

        private void calendarExpenses_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;

            CalendarExpensePreview preview = new CalendarExpensePreview(currentUser, selectedDate, this);
            preview.Show();
        }

        //HIGHLIGHTS DATES WITH EXPENSES IN THE CALENDAR
        private void HighlightExpenseDates()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT CONVERT(date, DateAdded) AS DateAdded
                         FROM Budget
                         WHERE UserID = @UserID
                         AND BudgetTypeID = 2";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    calendarExpenses.RemoveAllBoldedDates();

                    while (reader.Read())
                    {
                        DateTime d = reader.GetDateTime(0);
                        calendarExpenses.AddBoldedDate(d);
                    }

                    calendarExpenses.UpdateBoldedDates();
                }
            }
        }

        //SAVINGS NUM
        private void LoadSavingsNum()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Budget WHERE UserID = @UserID AND BudgetTypeID = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    int count = (int)cmd.ExecuteScalar();
                    savingsNum.Text = count.ToString();
                }
            }
        }

        //EXPENSE NUM
        private void LoadexpenseNum()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Budget WHERE UserID = @UserID AND BudgetTypeID = 2";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    int count = (int)cmd.ExecuteScalar();
                    expenseNum.Text = count.ToString();
                }
            }
        }

        public void RefreshCounts()
        {
            LoadSavingsNum();
            LoadexpenseNum();
        }


        private void calendarExpenses_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void logout_btn_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}