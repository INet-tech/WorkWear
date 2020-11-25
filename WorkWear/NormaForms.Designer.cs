namespace WorkWear
{
    partial class NormaForms
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
            this.normaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workWearDBDataSet = new WorkWear.WorkWearDBDataSet();
            this.normaTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.NormaTableAdapter();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.JobTableAdapter();
            this.workWearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workWearTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.WorkWearTableAdapter();
            this.iDNormaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameWorkwearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.periodOfMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNormaDataGridViewTextBoxColumn,
            this.iDJobDataGridViewTextBoxColumn,
            this.nameWorkwearDataGridViewTextBoxColumn,
            this.periodOfMonthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.normaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 335);
            this.dataGridView1.TabIndex = 11;
            // 
            // normaBindingSource
            // 
            this.normaBindingSource.DataMember = "Norma";
            this.normaBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // workWearDBDataSet
            // 
            this.workWearDBDataSet.DataSetName = "WorkWearDBDataSet";
            this.workWearDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // normaTableAdapter
            // 
            this.normaTableAdapter.ClearBeforeFill = true;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // workWearBindingSource
            // 
            this.workWearBindingSource.DataMember = "WorkWear";
            this.workWearBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // workWearTableAdapter
            // 
            this.workWearTableAdapter.ClearBeforeFill = true;
            // 
            // iDNormaDataGridViewTextBoxColumn
            // 
            this.iDNormaDataGridViewTextBoxColumn.DataPropertyName = "ID_Norma";
            this.iDNormaDataGridViewTextBoxColumn.HeaderText = "ID_Norma";
            this.iDNormaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNormaDataGridViewTextBoxColumn.Name = "iDNormaDataGridViewTextBoxColumn";
            this.iDNormaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNormaDataGridViewTextBoxColumn.Visible = false;
            this.iDNormaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDJobDataGridViewTextBoxColumn
            // 
            this.iDJobDataGridViewTextBoxColumn.DataPropertyName = "ID_Job";
            this.iDJobDataGridViewTextBoxColumn.DataSource = this.jobBindingSource;
            this.iDJobDataGridViewTextBoxColumn.DisplayMember = "Job";
            this.iDJobDataGridViewTextBoxColumn.HeaderText = "ID_Job";
            this.iDJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDJobDataGridViewTextBoxColumn.Name = "iDJobDataGridViewTextBoxColumn";
            this.iDJobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDJobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDJobDataGridViewTextBoxColumn.ValueMember = "ID";
            this.iDJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameWorkwearDataGridViewTextBoxColumn
            // 
            this.nameWorkwearDataGridViewTextBoxColumn.DataPropertyName = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.DataSource = this.workWearBindingSource;
            this.nameWorkwearDataGridViewTextBoxColumn.DisplayMember = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.HeaderText = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameWorkwearDataGridViewTextBoxColumn.Name = "nameWorkwearDataGridViewTextBoxColumn";
            this.nameWorkwearDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameWorkwearDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nameWorkwearDataGridViewTextBoxColumn.ValueMember = "ID_WorkWear";
            this.nameWorkwearDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodOfMonthDataGridViewTextBoxColumn
            // 
            this.periodOfMonthDataGridViewTextBoxColumn.DataPropertyName = "PeriodOfMonth";
            this.periodOfMonthDataGridViewTextBoxColumn.HeaderText = "PeriodOfMonth";
            this.periodOfMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodOfMonthDataGridViewTextBoxColumn.Name = "periodOfMonthDataGridViewTextBoxColumn";
            this.periodOfMonthDataGridViewTextBoxColumn.Width = 125;
            // 
            // NormaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NormaForms";
            this.Text = "Добавление нормы";
            this.Load += new System.EventHandler(this.NormaForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkWearDBDataSet workWearDBDataSet;
        private System.Windows.Forms.BindingSource normaBindingSource;
        private WorkWearDBDataSetTableAdapters.NormaTableAdapter normaTableAdapter;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private WorkWearDBDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource workWearBindingSource;
        private WorkWearDBDataSetTableAdapters.WorkWearTableAdapter workWearTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNormaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nameWorkwearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodOfMonthDataGridViewTextBoxColumn;
    }
}