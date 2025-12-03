using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public SavingsPreviewControl(
            string title,
            string category,
            string current_Amount,
            string target_Amount,
            string added_Date,
            string target_Date,
            int budgetID)
        {
            InitializeComponent();

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
        }

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
    }
}
