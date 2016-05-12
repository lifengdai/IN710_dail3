using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOSql
{
    class TalkToDatebase
    {
        private static SqlConnection bitdevConnection;

        private static void ConnectToBitDev()
        {
            bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_DAIL3;" +
                                                "User ID = dail3;" +
                                                "Password = xxxxxxxx;";
            bitdevConnection.Open();
        }

        public static Tuple<List<string>, List<string>> Allpaper()
        {
            Tuple<List<string>, List<string>> result = Tuple.Create(new List<string>(), new List<string>());
            ConnectToBitDev();
            string selectQuery = "Select * from dbo.tblPaper";

            SqlCommand select = new SqlCommand(selectQuery, bitdevConnection);
            SqlDataReader reader = select.ExecuteReader();           
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    result.Item1.Add(reader.GetValue(0).ToString());
                    result.Item2.Add(reader.GetValue(1).ToString());
                }
            }
            bitdevConnection.Close();
            return result;
        }

        public static Tuple<List<string>, List<string>, List<string>, List<string>> DueToNextTwoWeeks()
        {
            Tuple<List<string>, List<string>, List<string>, List<string>> 
                result = Tuple.Create(new List<string>(), new List<string>(), new List<string>(), new List<string>());

            ConnectToBitDev();

            DateTime currentDate = DateTime.Now;
            string day = (currentDate.Day.ToString().Length < 2) ? "0" + currentDate.Day.ToString() : currentDate.Day.ToString();
            string month = (currentDate.Month.ToString().Length < 2) ? 
                "0" + currentDate.Month.ToString() : currentDate.Month.ToString();
            string year = currentDate.Year.ToString();
            string today = year + month + day;

            string selectQuery = "Select * from dbo.tblAssignment " +
            "where " +
            "convert(datetime, convert(varchar(10), assignmentDue, 102))  > convert(datetime,'" + today + "');";

            SqlCommand select = new SqlCommand(selectQuery, bitdevConnection);
            SqlDataReader reader = select.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Item1.Add(reader.GetValue(0).ToString());
                    result.Item2.Add(reader.GetValue(1).ToString());
                    result.Item3.Add(reader.GetValue(2).ToString());
                    result.Item4.Add(reader.GetValue(3).ToString());
                }
            }
            bitdevConnection.Close();
            return result;
        }

        public static List<Tuple<string, string>> AverageMark()
        {
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            ConnectToBitDev();

            string selectQuery = "Select paperID, AVG(assignmentGrade) from dbo.tblAssignment where assignmentGrade > -1 group by paperID";

            SqlCommand select = new SqlCommand(selectQuery, bitdevConnection);
            SqlDataReader reader = select.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(Tuple.Create(reader.GetValue(0).ToString(), reader.GetValue(1).ToString()));
                }
            }
            bitdevConnection.Close();
            return result;
        }
    }
}
