namespace WorkWear
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workWearDBDataSet = new WorkWear.WorkWearDBDataSet();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeShoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateGrid = new System.Windows.Forms.Button();
            this.fKEmployeeJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.EmployeeTableAdapter();
            this.jobTableAdapter = new WorkWear.WorkWearDBDataSetTableAdapters.JobTableAdapter();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeeJobBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.OpenFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявкаToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "файл";
            // 
            // заявкаToolStripMenuItem
            // 
            this.заявкаToolStripMenuItem.Name = "заявкаToolStripMenuItem";
            this.заявкаToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.заявкаToolStripMenuItem.Text = "Заявка";
            // 
            // OpenFormToolStripMenuItem
            // 
            this.OpenFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JobToolStripMenuItem,
            this.NormaToolStripMenuItem,
            this.WorkWearToolStripMenuItem});
            this.OpenFormToolStripMenuItem.Name = "OpenFormToolStripMenuItem";
            this.OpenFormToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.OpenFormToolStripMenuItem.Text = "Настройки";
            // 
            // JobToolStripMenuItem
            // 
            this.JobToolStripMenuItem.Name = "JobToolStripMenuItem";
            this.JobToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.JobToolStripMenuItem.Text = "Специальность";
            this.JobToolStripMenuItem.Click += new System.EventHandler(this.JobToolStripMenuItem_Click);
            // 
            // NormaToolStripMenuItem
            // 
            this.NormaToolStripMenuItem.Name = "NormaToolStripMenuItem";
            this.NormaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.NormaToolStripMenuItem.Text = "Норма ";
            this.NormaToolStripMenuItem.Click += new System.EventHandler(this.NormaToolStripMenuItem_Click);
            // 
            // WorkWearToolStripMenuItem
            // 
            this.WorkWearToolStripMenuItem.Name = "WorkWearToolStripMenuItem";
            this.WorkWearToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.WorkWearToolStripMenuItem.Text = "Спец Одежда";
            this.WorkWearToolStripMenuItem.Click += new System.EventHandler(this.WorkWearToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmployeeDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.iDJobDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.sizeClothDataGridViewTextBoxColumn,
            this.sizeShoesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 260);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDEmployeeDataGridViewTextBoxColumn
            // 
            this.iDEmployeeDataGridViewTextBoxColumn.DataPropertyName = "ID_Employee";
            this.iDEmployeeDataGridViewTextBoxColumn.HeaderText = "ID_Employee";
            this.iDEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEmployeeDataGridViewTextBoxColumn.Name = "iDEmployeeDataGridViewTextBoxColumn";
            this.iDEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEmployeeDataGridViewTextBoxColumn.Visible = false;
            this.iDEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID_Number";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "ID_Number";
            this.iDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.Width = 125;
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
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            this.employmentDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employmentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizeClothDataGridViewTextBoxColumn
            // 
            this.sizeClothDataGridViewTextBoxColumn.DataPropertyName = "Size_Cloth";
            this.sizeClothDataGridViewTextBoxColumn.HeaderText = "Size_Cloth";
            this.sizeClothDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeClothDataGridViewTextBoxColumn.Name = "sizeClothDataGridViewTextBoxColumn";
            this.sizeClothDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizeShoesDataGridViewTextBoxColumn
            // 
            this.sizeShoesDataGridViewTextBoxColumn.DataPropertyName = "Size_Shoes";
            this.sizeShoesDataGridViewTextBoxColumn.HeaderText = "Size_Shoes";
            this.sizeShoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeShoesDataGridViewTextBoxColumn.Name = "sizeShoesDataGridViewTextBoxColumn";
            this.sizeShoesDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.workWearDBDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(924, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(254, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спецодежда";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выдать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 19);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(847, 303);
            this.dataGridView2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1191, 283);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сотрудники";
            // 
            // buttonUpdateGrid
            // 
            this.buttonUpdateGrid.Location = new System.Drawing.Point(567, 5);
            this.buttonUpdateGrid.Name = "buttonUpdateGrid";
            this.buttonUpdateGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateGrid.TabIndex = 10;
            this.buttonUpdateGrid.Text = "Обновить";
            this.buttonUpdateGrid.UseVisualStyleBackColor = true;
            this.buttonUpdateGrid.Click += new System.EventHandler(this.buttonUpdateGrid_Click);
            // 
            // fKEmployeeJobBindingSource
            // 
            this.fKEmployeeJobBindingSource.DataMember = "FK_Employee_Job";
            this.fKEmployeeJobBindingSource.DataSource = this.jobBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(461, 5);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateReport.TabIndex = 10;
            this.buttonCreateReport.Text = "Заявка";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 326);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 283);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.buttonUpdateGrid);
            this.panel3.Controls.Add(this.buttonCreateReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1191, 34);
            this.panel3.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(855, 326);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Спецодежда";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1191, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Учет спецодежды ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWearDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeeJobBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заявкаToolStripMenuItem;
        private WorkWearDBDataSet workWearDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private WorkWearDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button buttonUpdateGrid;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private WorkWearDBDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource fKEmployeeJobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeClothDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeShoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem OpenFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkWearToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

