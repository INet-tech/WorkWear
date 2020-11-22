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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NewWorkWear = new Issurance();
            NewWorkWear.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var NewEmployee= new Form2();
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
    }
}
