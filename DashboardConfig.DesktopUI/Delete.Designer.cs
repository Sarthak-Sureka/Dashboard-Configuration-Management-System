namespace DashboardConfig.DesktopUI
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelbutton2 = new System.Windows.Forms.Button();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dashboardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet = new DashboardConfig.DesktopUI._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet();
            this.dashboardsTableAdapter = new DashboardConfig.DesktopUI._DashboardConfig_DataAccess_DashboardConfigDbContextDataSetTableAdapters.DashboardsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delete Details";
            // 
            // Cancelbutton2
            // 
            this.Cancelbutton2.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbutton2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton2.Location = new System.Drawing.Point(42, 196);
            this.Cancelbutton2.Name = "Cancelbutton2";
            this.Cancelbutton2.Size = new System.Drawing.Size(109, 38);
            this.Cancelbutton2.TabIndex = 8;
            this.Cancelbutton2.Text = "Back";
            this.Cancelbutton2.UseVisualStyleBackColor = false;
            this.Cancelbutton2.Click += new System.EventHandler(this.Cancelbutton2_Click);
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdtextBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdtextBox1.Location = new System.Drawing.Point(162, 104);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.Size = new System.Drawing.Size(331, 32);
            this.IdtextBox1.TabIndex = 7;
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton1.Location = new System.Drawing.Point(384, 196);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(109, 38);
            this.Deletebutton1.TabIndex = 6;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = false;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Id";
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
            this.dataGridView1.Location = new System.Drawing.Point(54, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 223);
            this.dataGridView1.TabIndex = 10;
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
            // dashboardsBindingSource
            // 
            this.dashboardsBindingSource.DataMember = "Dashboards";
            this.dashboardsBindingSource.DataSource = this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet;
            // 
            // _DashboardConfig_DataAccess_DashboardConfigDbContextDataSet
            // 
            this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet.DataSetName = "_DashboardConfig_DataAccess_DashboardConfigDbContextDataSet";
            this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dashboardsTableAdapter
            // 
            this.dashboardsTableAdapter.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelbutton2);
            this.Controls.Add(this.IdtextBox1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DashboardConfig_DataAccess_DashboardConfigDbContextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelbutton2;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Button Deletebutton1;
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