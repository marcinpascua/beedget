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
        private BeedgetEntities db = new BeedgetEntities();
        private Users currentUser = null;

        public ExpensePreview(Users currentUser)
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
                string query = "SELECT * FROM Budget WHERE UserID = @UserID AND BudgetTypeID = 2";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ExpensePreviewControl preview = new ExpensePreviewControl(
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

        private void ExpensePreview_Load(object sender, EventArgs e)
        {

        }
    }
}
