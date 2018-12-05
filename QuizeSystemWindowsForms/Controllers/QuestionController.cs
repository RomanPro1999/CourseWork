using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace QuizeSystemWindowsForms.Controllers
{
    class QuestionController
    {
        private static byte[] ConvertImageToBinary(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
        private static Image ConvertBinaryToImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public DataTable LoadQuestionTable(TestModel test)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = null;
            try
            {
                dbConnection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from question_view where test_id=@id", dbConnection.connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", test.Id);
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
        public bool AddSimpleQuestion(QuestionModel question)
        {
            bool isSuccess = false;
            DbConnection dbConnection = new DbConnection();
            SqlCommand cmd = new SqlCommand("add_simple_question", dbConnection.connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@question_text", question.QuestionText);
                cmd.Parameters.AddWithValue("@val", question.Value);
                cmd.Parameters.AddWithValue("@question_type", question.QuestionType);
                cmd.Parameters.AddWithValue("@test_id", question.Test.Id);
                int rows = cmd.ExecuteNonQuery();
                foreach (UserChoice choice in question.Choises)
                {
                    SqlCommand choiceInsert = new SqlCommand("add_choice", dbConnection.connection);
                    choiceInsert.CommandType = CommandType.StoredProcedure;
                    choiceInsert.Parameters.AddWithValue("@choice_text", choice.Text);
                    choiceInsert.ExecuteNonQuery();
                }
                foreach (UserChoice choice in question.Answers)
                {
                    SqlCommand answerInsert = new SqlCommand("add_answer", dbConnection.connection);
                    answerInsert.CommandType = CommandType.StoredProcedure;
                    answerInsert.Parameters.AddWithValue("@answer_text", choice.Text);
                    answerInsert.ExecuteNonQuery();
                }
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
        public bool AddQuestionWithImage(QuestionModel question)
        {
            bool isSuccess = false;
            DbConnection dbConnection = new DbConnection();
            SqlCommand cmd = new SqlCommand("add_question", dbConnection.connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@question_text", question.QuestionText);
                cmd.Parameters.AddWithValue("@val", question.Value);
                cmd.Parameters.AddWithValue("@question_type", question.QuestionType);
                cmd.Parameters.AddWithValue("@question_image", ConvertImageToBinary(question.Image));
                cmd.Parameters.AddWithValue("@test_id", question.Test.Id);
                int rows = cmd.ExecuteNonQuery();
                foreach(UserChoice choice in question.Choises)
                {
                    SqlCommand choiceInsert = new SqlCommand("add_choice", dbConnection.connection);
                    choiceInsert.CommandType = CommandType.StoredProcedure;
                    choiceInsert.Parameters.AddWithValue("@choice_text", choice.Text);
                    choiceInsert.ExecuteNonQuery();
                }
                foreach(UserChoice choice in question.Answers)
                {
                    SqlCommand answerInsert = new SqlCommand("add_answer", dbConnection.connection);
                    answerInsert.CommandType = CommandType.StoredProcedure;
                    answerInsert.Parameters.AddWithValue("@answer_text", choice.Text);
                    answerInsert.ExecuteNonQuery();
                }
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
        public bool EditQuestion(QuestionModel question)
        {
            bool isSuccess = false;

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("edit_question", dbConnection.connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@question_id", question.Id);
                cmd.Parameters.AddWithValue("@question_text", question.QuestionText);
                cmd.Parameters.AddWithValue("@val", question.Value);
                cmd.Parameters.AddWithValue("@question_type", question.QuestionType);
                cmd.Parameters.AddWithValue("@question_image", ConvertImageToBinary(question.Image));
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
        public bool DeleteQuestion(QuestionModel question)
        {
            DbConnection dbConnection = new DbConnection();
            bool isSuccess = false;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete_question", dbConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@question_id", question.Id);
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
        public QuestionModel LoadQuestionById(int id)
        {
            DbConnection dbConnection = new DbConnection();
            QuestionModel question = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from questions where question_id=@id", dbConnection.connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    question = new QuestionModel();
                    while (reader.Read())
                    {
                        question.Id = reader.GetInt32(0);
                        question.QuestionText = reader.GetString(1);
                        question.Value = reader.GetInt32(2);
                        question.QuestionType = reader.GetString(3);
                        question.Image= ConvertBinaryToImage((byte[])reader["question_image"]);
                        question.Test.Id = reader.GetInt32(5);
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
            return question;
        }
        public List<UserChoice> LoadChoicesList(QuestionModel question)
        {
            List<UserChoice> userChoices = new List<UserChoice>();
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select choice_text from choices where question_id = @question_id", dbConnection.connection);
                cmd.Parameters.AddWithValue("@question_id", question.Id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userChoices.Add(new UserChoice(reader.GetString(0)));
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return userChoices;
        }
        public List<UserChoice> LoadAnswersList(QuestionModel question)
        {
            List<UserChoice> userAnswers = new List<UserChoice>();
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select answer_text from answers where question_id = @question_id", dbConnection.connection);
                cmd.Parameters.AddWithValue("@question_id", question.Id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userAnswers.Add(new UserChoice(reader.GetString(0)));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return userAnswers;
        }
    }
}
