using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace WorkWear
{
    static class DataSetForReport
    {
        public static DataSet InsertCustomers(string month)
        {
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
             " where X.EnfOfSocks between  CONVERT(date, GETDATE()) and EOMONTH(DATEADD(month, " + month + " ,CONVERT(date, GETDATE())))" +
             " SELECT * FROM #TemporaryTable ORDER BY ID_WorkWear"+
             " SELECT DISTINCT  ID_WorkWear FROM #TemporaryTable ORDER BY ID_WorkWear"; //NameWorkwear,7



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(commandString, connection);

                // Заполняем Dataset
                adapter.Fill(ds);

            }
            DataSet DataSetStorehoussReq = new DataSet();
            DataTable RequestTable = new DataTable("Request");
            // добавляем таблицу в dataset
            DataSetStorehoussReq.Tables.Add(RequestTable);

            DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumn.Unique = true; // столбец будет иметь уникальное значение
            idColumn.AllowDBNull = false; // не может принимать null
            idColumn.AutoIncrement = true; // будет автоинкрементироваться
            idColumn.AutoIncrementSeed = 1; // начальное значение
            idColumn.AutoIncrementStep = 1; // приращении при добавлении новой строки

            DataColumn nameWorkwearColumn = new DataColumn("NameWorkwear", Type.GetType("System.String"));
            DataColumn sizeColumn = new DataColumn("Size", Type.GetType("System.String"));
            DataColumn classificationColumn = new DataColumn("Classification", Type.GetType("System.String"));
            DataColumn unitsColumn = new DataColumn("Units", Type.GetType("System.String"));
            DataColumn quantityColumn = new DataColumn("Quantity", Type.GetType("System.Int32"));


            RequestTable.Columns.Add(idColumn);
            RequestTable.Columns.Add(nameWorkwearColumn);
            RequestTable.Columns.Add(sizeColumn);
            RequestTable.Columns.Add(classificationColumn);
            RequestTable.Columns.Add(unitsColumn);
            RequestTable.Columns.Add(quantityColumn);
            // определяем первичный ключ таблицы books
            RequestTable.PrimaryKey = new DataColumn[] { RequestTable.Columns["Id"] };

          
            DataTable dt = ds.Tables[0];
            DataTable dt1 = ds.Tables[1];
            string idclothes = "", idclothes2 ="" , sizeClothes="", nameClo="", classificColumn ="" ,unitColumn = "";
            int counter = 0;
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
                        sizeClothes += vv[10].ToString() + "/" + vv[11].ToString() +"\n" ;
                        nameClo = vv[5].ToString();
                        classificColumn = vv[8].ToString();
                        unitColumn = "шт";

                    }
                    
                }

                RequestTable.Rows.Add(new object[] { null, nameClo, sizeClothes, classificColumn, unitColumn, counter });
                sizeClothes = "";
                counter = 0;
            }
                                                                           


            var f = dt.Rows[0];
            var d = dt.Columns[3].ToString();
            //var query = from phone in ds.Tables["Phones"].AsEnumerable()
            //            from company in ds.Tables["Companies"].AsEnumerable()
            //            where (int)phone["CompanyId"] == (int)company["Id"]
            //            where (decimal)phone["Price"] > 200
            //            select new { Model = phone["Name"], Price = phone["Price"], Company = company["Name"] };



            //Объект DataSet содержит таблицы, которые представлены типом DataTable.
            //Таблица, в свою очередь, состоит из столбцов и строк.
            //Каждый столбец представляет объект DataColumn, а строка -объект DataRow.
            //Все данные строки хранятся в свойстве ItemArray, который

      

            return DataSetStorehoussReq;
        }
            
         
        
    }
    
  
}
