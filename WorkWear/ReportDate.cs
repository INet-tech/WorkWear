using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWear
{
    class ReportDate
    {
        private string m_Yer;


        public ReportDate(string mYer)
        {
          m_Yer = mYer;
        }
        public string MYer
        {
            get { return m_Yer; }
        }

    }
}
