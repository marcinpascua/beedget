using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Beedget
{
    public partial class SavingsPreviewControl : UserControl
    {
        string title = null;
        string category = null;
        string current_Amount = null;
        string target_Amount = null;
        string added_Date = null;
        string target_Date = null;
        int budgetID = 0;
        Dashboard parent;

        public SavingsPreviewControl(
            Dashboard parent,
            string title,
            string category,
            string current_Amount,
            string target_Amount,
            string added_Date,
            string target_Date,
            int budgetID)
        {
            InitializeComponent();
            this.parent = parent;
            this.title = title;
            this.category = category;
            this.current_Amount = current_Amount;
            this.target_Amount = target_Amount;
            this.added_Date = added_Date;
            this.target_Date = target_Date;
            this.budgetID = budgetID;

            LoadData();
        }

        private void LoadData()
        {
            title_label.Text = title;
            category_label.Text = category;
            currAmount.Text = "Php " + current_Amount;
            targetAmount.Text = "Php " + target_Amount;
            addedDate.Text = added_Date;
            targetDate.Text = target_Date;
            GetRemainingBalance();
            remainingBal.Text = "Php " + GetRemainingBalance().ToString("F2");
        }

        // REMAINING BALANCE
        private decimal GetRemainingBalance()
        {
            decimal current = 0;
            decimal target = 0;

            decimal.TryParse(currAmount.Text.Replace("Php ", "").Trim(), out current);
            decimal.TryParse(targetAmount.Text.Replace("Php ", "").Trim(), out target);

            decimal remainingBalance = target - current;

            return remainingBalance;
        }


        //DELETE SAVINGS BUTTON
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectionString =
                        "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM Budget WHERE budgetID = @budgetID";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.Add("@budgetID", SqlDbType.Int).Value = budgetID;

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                this.Parent.Controls.Remove(this);
                                this.Dispose();

                                if (parent != null)
                                {
                                    parent.RefreshCounts();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Item could not be deleted.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        //EDIT SAVINGS CURRENT AMOUNT BUTTON
        private void edit_btn_Click(object sender, EventArgs e)
        {
            string newAmount = Interaction.InputBox(
            "Enter new current amount:",
            "Edit Savings",
            current_Amount
            );

            if (string.IsNullOrWhiteSpace(newAmount))
            {
                return;
            }

            UpdateCurrAmount(newAmount);

            decimal curr = decimal.Parse(newAmount);
            decimal target = decimal.Parse(target_Amount);
            if (curr >= target)
            {
                checkedSavings();
            }
        }

        //UPDATES THE NEW CURRENT AMOUNT
        private void UpdateCurrAmount(string newAmount)
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Budget SET currentAmount = @amount WHERE budgetID = @budgetID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@amount", newAmount);
                    cmd.Parameters.AddWithValue("@budgetID", budgetID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        current_Amount = newAmount;
                        currAmount.Text = "Php " + newAmount;

                        MessageBox.Show("Amount updated!");
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
            }
        }

        //CHECKED SAVINGS
        private void checkedSavings()
        {
            string connectionString =
            "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Budget SET isAchieved = 1 WHERE budgetID = @budgetID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@budgetID", budgetID);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("🎉Congratulations! You achieved your savings goal!🎉");
            this.Parent.Controls.Remove(this);
            this.Dispose();

        }

        private void targetAmount_Click(object sender, EventArgs e)
        {

        }

        private void current_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}