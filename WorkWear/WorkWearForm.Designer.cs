namespace WorkWear
{
    partial class WorkWearForm
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
            this.iDWorkWearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameWorkwearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workWearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workWearDBDataSet = new WorkWear.WorkWearDBDataSet();
            this.workWearTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.WorkWearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDWorkWearDataGridViewTextBoxColumn,
            this.nameWorkwearDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workWearBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 347);
            this.dataGridView1.TabIndex = 25;
            // 
            // iDWorkWearDataGridViewTextBoxColumn
            // 
            this.iDWorkWearDataGridViewTextBoxColumn.DataPropertyName = "ID_WorkWear";
            this.iDWorkWearDataGridViewTextBoxColumn.HeaderText = "ID_WorkWear";
            this.iDWorkWearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDWorkWearDataGridViewTextBoxColumn.Name = "iDWorkWearDataGridViewTextBoxColumn";
            this.iDWorkWearDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDWorkWearDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameWorkwearDataGridViewTextBoxColumn
            // 
            this.nameWorkwearDataGridViewTextBoxColumn.DataPropertyName = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.HeaderText = "NameWorkwear";
            this.nameWorkwearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameWorkwearDataGridViewTextBoxColumn.Name = "nameWorkwearDataGridViewTextBoxColumn";
            this.nameWorkwearDataGridViewTextBoxColumn.Width = 125;
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            this.classificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Measure";
            this.measureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.Width = 125;
            // 
            // workWearBindingSource
            // 
            this.workWearBindingSource.DataMember = "WorkWear";
            this.workWearBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // workWearDBDataSet
            // 
            this.workWearDBDataSet.DataSetName = "WorkWearDBDataSet";
            this.workWearDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workWearTableAdapter
            // 
            this.workWearTableAdapter.ClearBeforeFill = true;
            // 
            // WorkWearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 395);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkWearForm";
            this.Text = "Добавление нового работника";
            this.Load += new System.EventHandler(this.WorkWearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WorkWearDBDataSet workWearDBDataSet;
        private System.Windows.Forms.BindingSource workWearBindingSource;
        private WorkWearDBDataSetTableAdapters.WorkWearTableAdapter workWearTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkWearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameWorkwearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
    }
}