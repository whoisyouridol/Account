using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.SqlClient;


namespace Account
{
  public  class WorkInAccount
    {
       public WorkInAccount (string log, string pass)
        {
            Log_For_DB = log;
            Pass_For_DB = pass;
        }
        public  string Log_For_DB { get; set; }
        public string Pass_For_DB { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public string City { get; set; }
        public string Sex { get; set; }
        public static void AddDataToDB (WorkInAccount account)
        {
            string con = "data source =.;database = Account ; integrated security=SSPI";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand
                       ($"INSERT INTO Information (Login, Password, City, Age, Sex, Salary)" +
                        $"values(" +
                        $" '{account.Log_For_DB}'," +
                        $" '{account.Pass_For_DB}'," +
                        $" '{account.City}'," +
                        $" '{account.Age}'," +
                        $" '{account.Sex}'," +
                        $" '{account.Salary}')", connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
        }
    }
}
