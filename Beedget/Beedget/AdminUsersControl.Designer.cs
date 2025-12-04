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
            this.components = new System.ComponentModel.Container();
            this.dashboard_data = new System.Windows.Forms.DataGridView();
            this.beedgetDBDataSet = new Beedget.BeedgetDBDataSet();
            this.beedgetDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beedgetDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beedgetDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboard_data
            // 
            this.dashboard_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dashboard_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dashboard_data.BackgroundColor = System.Drawing.Color.White;
            this.dashboard_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboard_data.Location = new System.Drawing.Point(14, 15);
            this.dashboard_data.Name = "dashboard_data";
            this.dashboard_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dashboard_data.RowTemplate.Height = 24;
            this.dashboard_data.Size = new System.Drawing.Size(809, 424);
            this.dashboard_data.TabIndex = 1;
            this.dashboard_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboard_data_CellContentClick);
            // 
            // beedgetDBDataSet
            // 
            this.beedgetDBDataSet.DataSetName = "BeedgetDBDataSet";
            this.beedgetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beedgetDBDataSetBindingSource
            // 
            this.beedgetDBDataSetBindingSource.DataSource = this.beedgetDBDataSet;
            this.beedgetDBDataSetBindingSource.Position = 0;
            // 
            // AdminUsersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dashboard_data);
            this.Name = "AdminUsersControl";
            this.Size = new System.Drawing.Size(839, 452);
            this.Load += new System.EventHandler(this.AdminUsersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beedgetDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beedgetDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dashboard_data;
        private System.Windows.Forms.BindingSource beedgetDBDataSetBindingSource;
        private BeedgetDBDataSet beedgetDBDataSet;
    }
}
