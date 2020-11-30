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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.Fill(dataSetForReport.TRENDS_NORM_FURNACE_6);
            //this.reportViewer1.Filter = "[NORMAL_ID] = " + partySelected;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WorkWear.Report.rdlc"; // bind reportviewer with .rdlc
            this.reportViewer1.LocalReport.DataSources.Clear();
          //  Microsoft.Reporting.WinForms.ReportDataSource DataSetFurn6 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFurn6Trends", this.tRENDSNORMFURNACE6BindingSource); // set the datasource
          //  Microsoft.Reporting.WinForms.ReportDataSource DataSetFurn6Rep = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetFarnuce", Axis); // set the datasource
          //  this.reportViewer1.LocalReport.DataSources.Add(DataSetFurn6Rep);
           // this.reportViewer1.LocalReport.DataSources.Add(DataSetFurn6);
            this.reportViewer1.RefreshReport();
        }
    }
}
