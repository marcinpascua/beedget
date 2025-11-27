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
        private BeedgetEntities db = new BeedgetEntities();
        private Users currentUser = null;

        public Dashboard(Users currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadData();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadData()
        {
            previewPanel.Controls.Clear();
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Budget WHERE UserID = @UserID AND BudgetTypeID = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataAdapter savings_da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    savings_da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        SavingsPreviewControl preview = new SavingsPreviewControl(
                            row["Title"].ToString(),
                            row["Category"].ToString(),
                            row["CurrentAmount"].ToString(),
                            row["TargetAmount"].ToString(),
                            row["DateAdded"].ToString(),
                            row["TargetDate"].ToString(),
                            row["BudgetID"].ToString()
                        );

                        previewPanel.Controls.Add(preview);
                    }
                }
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var add = new Savings(this, currentUser);
            add.ShowDialog();
        }

        public void RefreshSavings()
        {
            LoadData();
        }

        private void previewPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
