using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WorkWear
{

    public partial class ReportForm : Form
    {
        string mYer;
        string count;
        
        public string Count
        {
            set { count = value; }
        }
        public string MYer
        {   
            set { mYer = value; }
        }
        public ReportForm()
        {
            InitializeComponent();

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            label1.Text = count;
            label2.Text = mYer;
            List<ReportD> ReportList = new List<ReportD>();

            DataSet ds = new DataSet();
            string connectionString = @"Data Source=DESKTOP-FOIFO93;Initial Catalog=WorkWearDB;Integrated Security=True";
            string commandString = "select X.* INTO #TemporaryTable" +
             " from(SELECT Issu.ID_Issuance, Issu.ID_Employee, CONCAT(Emp.LastName,+' ' + Emp.FirstName) as FullName ,Emp.ID_Job," +
             " WoWe.ID_WorkWear,WoWe.NameWorkwear, Norm.PeriodOfMonth,Issu.EssuanceDate,WoWe.Classification," +
             " EOMONTH(DATEADD(month, Norm.PeriodOfMonth, Issu.EssuanceDate)) AS EnfOfSocks, Emp.Height,Emp.Size_Cloth, Emp.Size_Shoes" +
             " FROM Issuance Issu" +
             " LEFT JOIN WorkWear WoWe ON Issu.ID_WorkWear = WoWe.ID_WorkWear" +
             " LEFT JOIN Employee Emp ON Issu.ID_Employee = Emp.ID_Employee" +
             " LEFT JOIN Norma Norm ON Emp.ID_Job = Norm.ID_Job" +
             " LEFT JOIN Job J ON Emp.ID_Job = J.ID" +
             " WHERE Issu.ID_WorkWear = Norm.NameWorkwear ) X" +
             " where X.EnfOfSocks between  CONVERT(date, GETDATE()) and EOMONTH(DATEADD(month, " + count + " ,CONVERT(date, GETDATE())))" +
             " SELECT * FROM #TemporaryTable ORDER BY ID_WorkWear" +
             " SELECT DISTINCT  ID_WorkWear FROM #TemporaryTable ORDER BY ID_WorkWear"; //NameWorkwear,7

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(commandString, connection);

                // Заполняем Dataset
                adapter.Fill(ds);

            }
            DataTable dt = ds.Tables[0];
            DataTable dt1 = ds.Tables[1];
            string idclothes = "", idclothes2 = "", sizeClothes = "", nameClo = "", classificColumn = "", unitColumn = "";
            int counter = 0;
            int id = 0;
            foreach (DataRow row in dt1.Rows)
            {
                var cell = row.ItemArray;
                idclothes = cell[0].ToString();
                foreach (DataRow ro in dt.Rows)
                {
                    var vv = ro.ItemArray;
                    if (idclothes == vv[4].ToString())
                    {
                        counter++;
                        sizeClothes += vv[10].ToString() + "/" + vv[11].ToString() + "\n";
                        nameClo = vv[5].ToString();
                        classificColumn = vv[8].ToString();
                        unitColumn = "шт";

                    }

                }
                ReportList.Add(new ReportD(id, nameClo, sizeClothes, classificColumn, unitColumn, counter, mYer));

                sizeClothes = "";
                counter = 0;
            }
            //  ReportDate reportDate = new ReportDate(mYer);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WorkWear.Report.rdlc"; // bind reportviewer with .rdlc
            this.reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource DataSet1 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetForlist", ReportList);//("DataSetStorehousReq", this.tRENDSNORMFURNACE6BindingSource); // set the datasource
                                                                                                                                                     //   Microsoft.Reporting.WinForms.ReportDataSource DataSet2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetDateY", reportDate); // set the datasource
            this.reportViewer1.LocalReport.DataSources.Add(DataSet1);
            //  this.reportViewer1.LocalReport.DataSources.Add(DataSet2);
            this.reportViewer1.RefreshReport();

        }


    }
}
