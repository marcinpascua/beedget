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
    public partial class Expense : Form
    {
        private BeedgetEntities db = new BeedgetEntities();
        private Users currentUser = null;
        public Expense(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }


        private void save_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";
            string title = tb_title.Text;
            string currentAmount = tb_currentAmount.Text;
            var categoryname = category.Text;

            if (title == "Title" || title == "")
            {
                MessageBox.Show("Please enter a valid title for your savings goal.");
                return;
            }

            if (categoryname == "")
            {
                MessageBox.Show("Please select a category for your savings goal.");
                return;
            }

            if (currentAmount == "")
            {
                MessageBox.Show("Kindly enter a current amount.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Budget(Title, CurrentAmount, Dateadded, isAchieved, BudgetTypeID, UserID, Category ) VALUES(@Title, @CurrentAmount,  @Dateadded, @isAchieved, @BudgetTypeID, @UserID, @Category)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", tb_title.Text);
                    cmd.Parameters.AddWithValue("@CurrentAmount", tb_currentAmount.Text);
                    cmd.Parameters.AddWithValue("@Dateadded", DateTime.Now);
                    cmd.Parameters.AddWithValue("@isAchieved", false);
                    cmd.Parameters.AddWithValue("@BudgetTypeID", 2);
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);
                    cmd.Parameters.AddWithValue("@Category", category.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense saved successfully!");
                }
            }
            this.Close();
        }

        private void tb_title_Click(object sender, EventArgs e)
        {
            if (tb_title.Text == "Title")
            {
                tb_title.Text = "";
            }
        }
    }
}
