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
        }

        public void LoadExpensesForDate()
        {
            previewPanel.Controls.Clear();

            string connectionString =
                "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

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

        private void CalendarExpensePreview_Load(object sender, EventArgs e)
        {

        }

      
    }
}
