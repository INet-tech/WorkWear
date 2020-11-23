using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkWear
{
    public partial class Form1 : Form
    {
        DateTimePicker dateTimePicker1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.workWearDBDataSet.Job);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.workWearDBDataSet.Employee);
        }
       # region DataGridView1

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    dateTimePicker1 = new DateTimePicker();
                    dataGridView1.Controls.Add(dateTimePicker1);
                    dateTimePicker1.Format = DateTimePickerFormat.Short;
                    Rectangle oRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dateTimePicker1.Size = new Size(oRectangle.Width, oRectangle.Height);
                    dateTimePicker1.Location = new Point(oRectangle.X, oRectangle.Y);
                    dateTimePicker1.TextChanged += new EventHandler(DateTimePickerChange);
                    dateTimePicker1.CloseUp += new EventHandler(DateTimePickerClose);
                }
            }
        }

        private void DateTimePickerChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dateTimePicker1.Text.ToString();
        }

        private void DateTimePickerClose(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }
#endregion






        #region Button
        private void buttonUpdateGrid_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Внести изменение в BD?","Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                 );
            if (result == DialogResult.Yes)
            {
                this.employeeTableAdapter.Update(this.workWearDBDataSet.Employee);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var NewWorkWear = new Issurance();
            NewWorkWear.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var NewEmployee= new WorkWearForm();
            NewEmployee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var NewNorma = new Norma();
            NewNorma.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Delete = new Delete();
            Delete.Show();
        }



        #endregion

        private void JobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var  WorkWear = new WorkWearForm();
            WorkWear.Show();
        }
    }
}
