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
    public partial class NormaForms : Form
    {
        public NormaForms()
        {
            InitializeComponent();
        }

        private void NormaForms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.WorkWear". При необходимости она может быть перемещена или удалена.
            this.workWearTableAdapter.Fill(this.workWearDBDataSet.WorkWear);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.workWearDBDataSet.Job);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.Norma". При необходимости она может быть перемещена или удалена.
            this.normaTableAdapter.Fill(this.workWearDBDataSet.Norma);

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
                this.normaTableAdapter.Update(this.workWearDBDataSet.Norma);
            }
        }
    }
}
