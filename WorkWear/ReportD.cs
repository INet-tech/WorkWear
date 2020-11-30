using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWear
{
    public class ReportD
    {
        private int id_Column;
        private string name_Workwear_Column;
        private string size_Column;
        private string classification_Column;
        private string units_Column;
        private int quantity_Column;
        private string m_Yer;


        public ReportD(int idnumber, string nameWorkwearColumn, string sizeColumn, string classificationColumn, string unitsColumn, int quantityColumn ,string mYer)
        {
            id_Column = idnumber;
            name_Workwear_Column = nameWorkwearColumn;
            size_Column = sizeColumn;
            classification_Column = classificationColumn;
            units_Column = unitsColumn;
            quantity_Column = quantityColumn;
            m_Yer = mYer;
        }
      
        public int IdColumn
        {
            get { return id_Column; }
        }
        public string NameWorkwearColumn
        {
            get { return name_Workwear_Column; }
        }
        public string SizeColumn
        {
            get { return size_Column; }
        }
        public string ClassificationColumn
        {
            get { return classification_Column; }
        }
        public string UnitsColumn
        {
            get { return units_Column; }
        }
        public int QuantityColumn
        {
            get { return quantity_Column; }
        }
        public string MYer
        {
            get { return m_Yer; }
        }
    }
}
