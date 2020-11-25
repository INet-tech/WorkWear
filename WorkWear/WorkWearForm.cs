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
    public partial class WorkWearForm : Form
    {
        public WorkWearForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Внести изменение в BD?", "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                 );
            if (result == DialogResult.Yes)
            {
                this.workWearTableAdapter.Update(this.workWearDBDataSet.WorkWear);
            }
        }


        private void WorkWearForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.WorkWear". При необходимости она может быть перемещена или удалена.
            this.workWearTableAdapter.Fill(this.workWearDBDataSet.WorkWear);
        }
    }
}
