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
            this.workWearDBDataSet = new WorkWear.WorkWearDBDataSet();
            this.normaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normaTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.NormaTableAdapter();
            this.iDNormaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameWorkwearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodOfMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(814, 236);
            this.dataGridView1.TabIndex = 11;
            // 
            // workWearDBDataSet
            // 
            this.workWearDBDataSet.DataSetName = "WorkWearDBDataSet";
            this.workWearDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // normaBindingSource
            // 
            this.normaBindingSource.DataMember = "Norma";
            this.normaBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // normaTableAdapter
            // 
            this.normaTableAdapter.ClearBeforeFill = true;
            // 
            // iDNormaDataGridViewTextBoxColumn
            // 
            this.iDNormaDataGridViewTextBoxColumn.DataPropertyName = "ID_Norma";
            this.iDNormaDataGridViewTextBoxColumn.HeaderText = "ID_Norma";
            this.iDNormaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNormaDataGridViewTextBoxColumn.Name = "iDNormaDataGridViewTextBoxColumn";
            this.iDNormaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNormaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDJobDataGridViewTextBoxColumn
            // 
            this.iDJobDataGridViewTextBoxColumn.DataPropertyName = "ID_Job";
            this.iDJobDataGridViewTextBoxColumn.HeaderText = "ID_Job";
            this.iDJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDJobDataGridViewTextBoxColumn.Name = "iDJobDataGridViewTextBoxColumn";
            this.iDJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameWorkwearDataGridViewTextBoxColumn
            // 
            this.nameWorkwearDataGridViewTextBoxColumn.DataPropertyName = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.HeaderText = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameWorkwearDataGridViewTextBoxColumn.Name = "nameWorkwearDataGridViewTextBoxColumn";
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
            this.ClientSize = new System.Drawing.Size(826, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NormaForms";
            this.Text = "Добавление нормы";
            this.Load += new System.EventHandler(this.NormaForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkWearDBDataSet workWearDBDataSet;
        private System.Windows.Forms.BindingSource normaBindingSource;
        private WorkWearDBDataSetTableAdapters.NormaTableAdapter normaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNormaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameWorkwearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodOfMonthDataGridViewTextBoxColumn;
    }
}