using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SampleConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=KELLGGNCPU0337;Initial Catalog=SampleExercise;Integrated Security=True");
        public SampleConnection()
        {

        }
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }


        }
        private void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();

            }

        }
        public void ExecuteNonQuery(string query)
        {
            Open();
            SqlDataAdapter sqa = new SqlDataAdapter(query, sqlConnection);
            sqa.SelectCommand.ExecuteNonQuery();
            Close();
        }
    }
}