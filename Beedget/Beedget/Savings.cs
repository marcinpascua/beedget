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
    public partial class Savings : Form
    {
        Dashboard parent;
        Users currentUser = null;

        public Savings(Dashboard parent, Users currentUser)
        {
            InitializeComponent();
            this.parent = parent;
            this.currentUser = currentUser;
        }

        private void Savings_Load(object sender, EventArgs e)
        {
           
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";
            string title = tb_title.Text;
            string targetAmount = tb_targetAmount.Text;
            string currentAmount = tb_currentAmount.Text;
            var categoryname = category.Text;
            var targetDate = dateTimePicker1.Value;

            if (title == "Title" || title == "") { 
                MessageBox.Show("Please enter a valid title for your savings goal.");
                return;
            }

            if (targetAmount == "")
            {
                MessageBox.Show("Kindly enter a target amount.");
                return;
            }

            if(categoryname == "")
            {
                MessageBox.Show("Please select a category for your savings goal.");
                return;
            }

            if (currentAmount == "")
            {
                MessageBox.Show("Kindly enter a current amount.");
                return;
            }

            decimal currentAmt = Convert.ToDecimal(tb_currentAmount.Text);
            decimal targetAmt = Convert.ToDecimal(tb_targetAmount.Text);

            if (currentAmt >= targetAmt)
            {
                MessageBox.Show("Current amount meets or exceeds the target! This budget is already achieved.");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Budget(Title, TargetAmount, CurrentAmount, Dateadded, TargetDate, isAchieved, UserID, BudgetTypeID, Category ) VALUES(@Title, @TargetAmount, @CurrentAmount, @Dateadded, @TargetDate, @isAchieved, @UserID,  @BudgetTypeID,  @Category)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", tb_title.Text);
                    cmd.Parameters.AddWithValue("@CurrentAmount", tb_currentAmount.Text);
                    cmd.Parameters.AddWithValue("@TargetAmount", tb_targetAmount.Text);
                    cmd.Parameters.AddWithValue("@Dateadded", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TargetDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@isAchieved", false);
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    cmd.Parameters.AddWithValue("@BudgetTypeID", 1);
                    cmd.Parameters.AddWithValue("@Category", category.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Savings goal saved successfully!");
                    if (parent != null)
                    {
                        parent.RefreshCounts();
                    }



                }
            }
            this.Close();
        }

        //EDITS TITLE OF SAVINGS
        private void tb_title_Click(object sender, EventArgs e)
        {
            if (tb_title.Text == "Title")
            {
                tb_title.Text = "";
            }
        }

        private void save_btn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
