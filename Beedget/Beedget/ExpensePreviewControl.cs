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
    public partial class ExpensePreviewControl : UserControl
    {
        string title = null;
        string category = null;
        string current_Amount = null;
        string added_Date = null;
        int budgetID = 0;

        public ExpensePreviewControl( 
            string title,
            string category,
            string current_Amount,
            string added_Date,
            int budgetID)
        {
            InitializeComponent();

            this.title = title;
            this.category = category;
            this.current_Amount = current_Amount;
            this.added_Date = added_Date;
            this.budgetID = budgetID;

            LoadData();
        }

        private void LoadData()
        {
            title_label.Text = title;
            category_label.Text = category;
            currAmount.Text = "Php " + current_Amount;
            addedDate.Text = added_Date;
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
