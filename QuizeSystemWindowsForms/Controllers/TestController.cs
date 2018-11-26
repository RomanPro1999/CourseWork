using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data;
using System.Data.SqlClient;

namespace QuizeSystemWindowsForms.Controllers
{
    class TestController
    {
        public DataTable LoadTestsTable()
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = null;
            try
            {
                dbConnection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from test_view", dbConnection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return dataTable;
        }
        public bool AddTest(TestModel test)
        {
            bool isSuccess = false;
            DbConnection dbConnection = new DbConnection();
            SqlCommand cmd = new SqlCommand("add_test", dbConnection.connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                Console.WriteLine(test.Name);
                Console.WriteLine(test.NumberOfQuestions);
                Console.WriteLine(test.Topic.Id);
                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@name", test.Name);
                cmd.Parameters.AddWithValue("@num_of_questions", test.NumberOfQuestions);
                cmd.Parameters.AddWithValue("@topic_id", test.Topic.Id);
                int rows = cmd.ExecuteNonQuery();
                isSuccess = true;
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return isSuccess;
        }
        public bool EditTest(TestModel test)
        {
            bool isSuccess = false;

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("edit_test", dbConnection.connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", test.Id);
                cmd.Parameters.AddWithValue("@name", test.Name);
                cmd.Parameters.AddWithValue("@num_of_questions", test.NumberOfQuestions);
                int rows = cmd.ExecuteNonQuery();
                isSuccess = true;
                



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return isSuccess;
        }
        public bool DeleteTest(TestModel test)
        {
            DbConnection dbConnection = new DbConnection();
            bool isSuccess = false;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete_test", dbConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", test.Id);
                int rows = cmd.ExecuteNonQuery();
               isSuccess = true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return isSuccess;
        }
        public TestModel LoadTestById(int id)
        {
            DbConnection dbConnection = new DbConnection();
            TestModel test = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select test_id,test_name,number_of_questions,topic_id from test_view where test_id=@id", dbConnection.connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    test = new TestModel();
                    while (reader.Read())
                    {
                        test.Id = reader.GetInt32(0);
                        test.Name = reader.GetString(1);
                        test.NumberOfQuestions =Convert.ToInt32(reader.GetInt32(2));
                        test.Topic.Id = reader.GetInt32(3);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return test;
        }
    }
}
