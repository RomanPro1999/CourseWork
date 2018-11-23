using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data.SqlClient;
using System.Data;

namespace QuizeSystemWindowsForms.Controllers
{
    class TopicController
    {
        public DataTable LoadTopicDataTableForSpecificSubject(SubjectModell subject)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = null;
            try
            {
                dbConnection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select topic_name, describtion from topic where subject_id=@subject_id", dbConnection.connection);
                adapter.SelectCommand.Parameters.AddWithValue("@subject_id", subject.Id);
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

        public bool AddTopic(TopicModel topic)
        {
            bool isSuccess = false;
            DbConnection dbConnection = new DbConnection();
            SqlCommand cmd = new SqlCommand("add_topic", dbConnection.connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@topic_name", topic.Name);
                cmd.Parameters.AddWithValue("@subject_id", topic.Subject.Id);
                cmd.Parameters.AddWithValue("@describtion", topic.Describtion);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }

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

        public bool EditTopic(TopicModel topic)
        {
            bool isSuccess = false;

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("edit_topic", dbConnection.connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@topic_id", topic.Id);
                cmd.Parameters.AddWithValue("@topic_name", topic.Name);
                cmd.Parameters.AddWithValue("@describtion", topic.Describtion);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(topic.Id);
                Console.WriteLine(topic.Name);
                Console.WriteLine(topic.Describtion);
                Console.WriteLine(rows);
                if (rows > 0)
                {
                    isSuccess = true;
                }



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

        public bool DeleteTopic(TopicModel topic)
        {
            DbConnection dbConnection = new DbConnection();
            bool isSuccess = false;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete_topic", dbConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", topic.Id);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
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
        public TopicModel SelectTopicByNameAndDescribtion(string name,string descr)
        {
            DbConnection dbConnection = new DbConnection();
            TopicModel topic = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select topic_id,topic_name,describtion  from topic where topic_name=@name and describtion=@describtion", dbConnection.connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@describtion", descr);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    topic = new TopicModel();
                    while (reader.Read())
                    {
                        topic.Id = reader.GetInt32(0);
                        topic.Name = reader.GetString(1);
                        topic.Describtion = reader.GetString(2);
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
            return topic;
        }
    }
}
