using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkWear
{
    public partial class Form1 : Form
    {   // строка подключения @"Data Source= .\SQLEXPESS;
        string connectionString = @"Data Source= DESKTOP-HDKIKM5 ;Initial Catalog=WorkWearDB;Integrated Security=True";
        string commandString = "SELECT * FROM Employee";

        DataTable employee = new DataTable("Employee");
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(commandString, connectionString);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.FillSchema(employee, SchemaType.Mapped);
            employee.Columns["ID_Employee"].AutoIncrementSeed = -1;
            employee.Columns["ID_Employee"].AutoIncrementStep = -1;

            adapter.Fill(employee);

            dataGridViewEmployee.DataSource = employee;
        }


        #region Button 
        private void button1_Click(object sender, EventArgs e)
        {
            var NewWorkWear = new Issurance();
            NewWorkWear.Show();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            var NewEmployee = new Form2();
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

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
