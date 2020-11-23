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
    public partial class JobForm : Form
    {
        public JobForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.workWearDBDataSet.Job);

        }
    }
}
