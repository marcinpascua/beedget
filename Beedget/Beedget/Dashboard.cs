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
    public partial class Dashboard: Form
    {
        private BeedgetEntities db = new BeedgetEntities();

        private Users currentUser = null;
        OptionDialog dialog = null;

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
            string connectionString = "Data Source=LAPTOP-4BA2RILC\\SQLEXPRESS;Initial Catalog=BeedgetDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Budget WHERE UserID =" + currentUser.UserID + " AND BudgetTypeID = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter savings_da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    savings_da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var title = row["Title"].ToString();
                        var category = row["Category"].ToString();
                        var current_Amount = row["CurrentAmount"].ToString();
                        var target_Amount = row["TargetAmount"].ToString();
                        var addedDate = row["DateAdded"].ToString();
                        var targetDate = row["TargetDate"].ToString();


                        SavingsPreviewControl preview = new SavingsPreviewControl(
                             title,
                             category,
                             current_Amount,
                             target_Amount,
                             addedDate,
                             targetDate
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
            dialog = new OptionDialog(currentUser);
            dialog.Show();
        }

      
    }
}
