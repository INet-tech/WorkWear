namespace WorkWear
{
    partial class JobForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workWearDBDataSet = new WorkWear.WorkWearDBDataSet();
            this.jobTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.JobTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Да";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDJobDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // workWearDBDataSet
            // 
            this.workWearDBDataSet.DataSetName = "WorkWearDBDataSet";
            this.workWearDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDJobDataGridViewTextBoxColumn
            // 
            this.iDJobDataGridViewTextBoxColumn.DataPropertyName = "ID_Job";
            this.iDJobDataGridViewTextBoxColumn.HeaderText = "ID_Job";
            this.iDJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDJobDataGridViewTextBoxColumn.Name = "iDJobDataGridViewTextBoxColumn";
            this.iDJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.Width = 125;
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "JobForm";
            this.Text = "Удаление";
            this.Load += new System.EventHandler(this.JobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkWearDBDataSet workWearDBDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private WorkWearDBDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
    }
}