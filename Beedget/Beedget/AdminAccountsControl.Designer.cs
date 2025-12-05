namespace Beedget
{
    partial class AdminAccountsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboard_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboard_data
            // 
            this.dashboard_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dashboard_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dashboard_data.BackgroundColor = System.Drawing.Color.White;
            this.dashboard_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboard_data.Location = new System.Drawing.Point(15, 18);
            this.dashboard_data.Name = "dashboard_data";
            this.dashboard_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dashboard_data.RowTemplate.Height = 24;
            this.dashboard_data.Size = new System.Drawing.Size(809, 356);
            this.dashboard_data.TabIndex = 2;
            this.dashboard_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboard_data_CellContentClick);
            // 
            // AdminAccountsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dashboard_data);
            this.Name = "AdminAccountsControl";
            this.Size = new System.Drawing.Size(839, 393);
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dashboard_data;
    }
}
