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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workWearDBDataSet.Norma". При необходимости она может быть перемещена или удалена.
            this.normaTableAdapter.Fill(this.workWearDBDataSet.Norma);

        }
    }
}
