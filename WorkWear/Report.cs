using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWear
{
    public class Report
    {
        private int id_Column;
        private string name_Workwear_Column;
        private string size_Column;
        private string classification_Column;
        private string units_Column;
        private int quantity_Column;

        public Report(int idnumber, string nameWorkwearColumn, string sizeColumn, string classificationColumn, string unitsColumn, int quantityColumn)
        {
            id_Column = idnumber;
            name_Workwear_Column = nameWorkwearColumn;
            size_Column = sizeColumn;
            classification_Column = classificationColumn;
            units_Column = unitsColumn;
            quantity_Column = quantityColumn;

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

    }
}
