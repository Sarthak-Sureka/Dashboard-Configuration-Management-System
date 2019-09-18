namespace DashboardConfig.DesktopUI
{
    partial class View
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet = new DashboardConfig.DesktopUI._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet();
            this.dashboardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardsTableAdapter = new DashboardConfig.DesktopUI._DashboardConfig_DataAccess_DashboardConfigDbContextDataSetTableAdapters.DashboardsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Donor Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.componentDataGridViewTextBoxColumn,
            this.datapointDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dashboardsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // _DashboardConfig_DataAccess_DashboardConfigDbContextDataSet
            // 
            this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet.DataSetName = "_DashboardConfig_DataAccess_DashboardConfigDbContextDataSet";
            this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dashboardsBindingSource
            // 
            this.dashboardsBindingSource.DataMember = "Dashboards";
            this.dashboardsBindingSource.DataSource = this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet;
            // 
            // dashboardsTableAdapter
            // 
            this.dashboardsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // componentDataGridViewTextBoxColumn
            // 
            this.componentDataGridViewTextBoxColumn.DataPropertyName = "Component";
            this.componentDataGridViewTextBoxColumn.HeaderText = "Component";
            this.componentDataGridViewTextBoxColumn.Name = "componentDataGridViewTextBoxColumn";
            // 
            // datapointDataGridViewTextBoxColumn
            // 
            this.datapointDataGridViewTextBoxColumn.DataPropertyName = "Datapoint";
            this.datapointDataGridViewTextBoxColumn.HeaderText = "Datapoint";
            this.datapointDataGridViewTextBoxColumn.Name = "datapointDataGridViewTextBoxColumn";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _DashboardConfig_DataAccess_DashboardConfigDbContextDataSet _DashboardConfig_DataAccess_DashboardConfigDbContextDataSet;
        private System.Windows.Forms.BindingSource dashboardsBindingSource;
        private _DashboardConfig_DataAccess_DashboardConfigDbContextDataSetTableAdapters.DashboardsTableAdapter dashboardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapointDataGridViewTextBoxColumn;
    }
}