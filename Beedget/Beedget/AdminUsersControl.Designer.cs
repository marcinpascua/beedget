namespace Beedget
{
    partial class AdminUsersControl
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
            this.dashboard_data.BackgroundColor = System.Drawing.Color.White;
            this.dashboard_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboard_data.Location = new System.Drawing.Point(14, 15);
            this.dashboard_data.Name = "dashboard_data";
            this.dashboard_data.RowHeadersWidth = 51;
            this.dashboard_data.RowTemplate.Height = 24;
            this.dashboard_data.Size = new System.Drawing.Size(923, 493);
            this.dashboard_data.TabIndex = 1;
            this.dashboard_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboard_data_CellContentClick);
            // 
            // AdminUsersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dashboard_data);
            this.Name = "AdminUsersControl";
            this.Size = new System.Drawing.Size(950, 523);
            this.Load += new System.EventHandler(this.AdminUsersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dashboard_data;
    }
}
