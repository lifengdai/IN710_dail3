using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSql
{
    class TalkToSql
    {
        private static SqlConnection bitdevConnection;

        public static void ConnectToBitDev()
        {
            bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_DAIL3;" +
                                                "User ID = dail3;" +
                                                "Password = xxxxxxxxx;";
            bitdevConnection.Open();
        }

        public static void DropConstraint()
        {
            string drop =
                                       "ALTER TABLE tblAssignment DROP CONSTRAINT FK_Assignment_PaperID;" +
                                       "ALTER TABLE tblPaper DROP CONSTRAINT FK_Paper_Tutor;" +
                                       "ALTER TABLE tblPaper DROP CONSTRAINT PK_tblPaper;" +
                                       "ALTER TABLE tblTutor DROP CONSTRAINT PK_tblTutor;" +
                                       "ALTER TABLE tblAssignment DROP CONSTRAINT PK_tblAssignment;";
            SqlCommand dropC = new SqlCommand(drop, bitdevConnection);
            dropC.ExecuteNonQuery();

        }

        public static void CreateTables()
        {
            string buildTablesString =

                                       "IF OBJECT_ID('tblTutor') IS NOT NULL DROP TABLE tblTutor;" +
                                       "IF OBJECT_ID('tblPaper') IS NOT NULL DROP TABLE tblPaper;" +
                                       "IF OBJECT_ID('tblAssignment') IS NOT NULL DROP TABLE tblAssignment;" +

                                       "CREATE TABLE tblTutor" +
                                       "(" +
                                       "tutorID int IDENTITY," +
                                       "tutorFirstName char(10) NOT NULL," +
                                       "tutorLastName char(15) NOT NULL," +
                                       "tutorEmail char(30) NOT NULL," +
                                       "CONSTRAINT PK_tblTutor PRIMARY KEY(tutorID)" +
                                       ");" +

                                       "CREATE TABLE tblPaper" +
                                       "(" + 
                                       "paperID char(10) NOT NULL," +
                                       "paperName char(50) NOT NULL," +
                                       "tutorID int NOT NULL," +
                                       "CONSTRAINT PK_tblPaper PRIMARY KEY(paperID)," +
                                       "CONSTRAINT FK_Paper_Tutor FOREIGN KEY(tutorID) REFERENCES tblTutor(tutorID)" +
                                       ");" +

                                       "CREATE TABLE tblAssignment" +
                                       "(" +
                                       "assignmentID int IDENTITY," +
                                       "assignmentGrade int NOT NULL," +
                                       "paperID char(10) NOT NULL," +
                                       "assignmentDue date Not NULL," +                               
                                       "CONSTRAINT PK_tblAssignment PRIMARY KEY(assignmentID)," +
                                       "CONSTRAINT FK_Assignment_PaperID FOREIGN KEY(paperID) REFERENCES tblPaper(paperID)," +
                                       ");";

            SqlCommand create = new SqlCommand(buildTablesString, bitdevConnection);
            
            create.ExecuteNonQuery();
        }

        public static void Insert()
        {
            DateTime currentDate = DateTime.Now;
            string day = (currentDate.Day.ToString().Length < 2) ? "0" + currentDate.Day.ToString() : currentDate.Day.ToString();
            int imonth = currentDate.Month;
            string OneMoremonth = ((imonth + 1).ToString().Length < 2) ? "0" + (imonth + 1).ToString() : (imonth + 1).ToString();
            string OneLessmonth = ((imonth - 1).ToString().Length < 2) ? "0" + (imonth - 1).ToString() : (imonth - 1).ToString();
            string year = currentDate.Year.ToString();

            string Moredate = year + OneMoremonth + day;
            string lessdate = year + OneLessmonth + day;

            string insertString = "INSERT INTO tblTutor VALUES('Jamie', 'Bonher', 'JamieBonher@example.com');" +
                                  "INSERT INTO tblTutor VALUES('Laverne', 'Bartram', 'LaverneBartram@example.com');" +
                                  "INSERT INTO tblTutor VALUES('Francis', 'Gorbold', 'FrancisGorbold@example.com');" +
                                  "INSERT INTO tblTutor VALUES('Gerry', 'Head', 'GerryHead@example.com');" +
                                  "INSERT INTO tblTutor VALUES('Laverne', 'Massey', 'LaverneMassey@example.com');" +

                                  "INSERT INTO tblPaper VALUES('IN70001', 'system managment', 1);" +
                                  "INSERT INTO tblPaper VALUES('IN70002', 'mobile dev', 2);" +
                                  "INSERT INTO tblPaper VALUES('IN70003', 'oosd', 2);" +
                                  "INSERT INTO tblPaper VALUES('IN70004', 'project', 4);" +

                                  "INSERT INTO tblAssignment VALUES(75, 'IN70001', '" + lessdate + "');" +
                                  "INSERT INTO tblAssignment VALUES(-1, 'IN70001', '" + Moredate + "');" +
                                  "INSERT INTO tblAssignment VALUES(68, 'IN70001', '" + lessdate + "');" +

                                  "INSERT INTO tblAssignment VALUES(78, 'IN70002', '" + lessdate + "');" +
                                  "INSERT INTO tblAssignment VALUES(80, 'IN70002', '" + lessdate + "');" +
                                  "INSERT INTO tblAssignment VALUES(-1, 'IN70002', '" + Moredate + "');" +

                                  "INSERT INTO tblAssignment VALUES(76, 'IN70003', '" + lessdate + "');" +
                                  "INSERT INTO tblAssignment VALUES(-1, 'IN70003', '" + Moredate + "');" +
                                  "INSERT INTO tblAssignment VALUES(65, 'IN70003', '" + lessdate + "');" +

                                  "INSERT INTO tblAssignment VALUES(78, 'IN70004', '" + lessdate + "');" +
                                  "INSERT INTO tblAssignment VALUES(77, 'IN70004', '" + lessdate + "');" +
                                  "INSERT INTO tblAssignment VALUES(79, 'IN70004', '" + lessdate + "');";

            SqlCommand insert = new SqlCommand(insertString, bitdevConnection);
            insert.ExecuteNonQuery();
        }

        public static void CloseConnection()
        {
            bitdevConnection.Close();
        }
    }
}
