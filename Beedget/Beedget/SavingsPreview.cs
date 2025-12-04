using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Beedget
{
    public partial class SavingsPreview : Form
    {
        private Users currentUser = null;

        public SavingsPreview(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Budget WHERE UserID = @UserID AND BudgetTypeID = 1 AND isAchieved = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        SavingsPreviewControl preview = new SavingsPreviewControl(
                            row["Title"].ToString(),
                            row["Category"].ToString(),
                            row["CurrentAmount"].ToString(),
                            row["TargetAmount"].ToString(),
                            row["DateAdded"].ToString(),
                            row["TargetDate"].ToString(),
                            Convert.ToInt32(row["BudgetID"])
                        );
                        preview.Dock = DockStyle.Top; 
                        previewPanel.Controls.Add( preview);

                    }
                }
            }
        }

        private void SavingsPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
