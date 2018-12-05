using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace QuizeSystemWindowsForms.Controllers
{
    class TestController
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
        public DataTable LoadTestsTable(SubjectModel subject)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = null;
            try
            {
                dbConnection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from test_view where subject_id=@id", dbConnection.connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", subject.Id);
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
                Console.WriteLine(test.Id);
                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@name", test.Name);
                cmd.Parameters.AddWithValue("@num_of_questions", test.NumberOfQuestions);
                cmd.Parameters.AddWithValue("@subject_id", test.Subject.Id);
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
                SqlCommand loadQuestions = new SqlCommand("select question_id from questions where test_id=@id",dbConnection.connection);
                loadQuestions.Parameters.AddWithValue("@id", test.Id);
                SqlDataReader dataReader = loadQuestions.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        SqlCommand deleteQuestions = new SqlCommand("delete_question", dbConnection.connection);
                        deleteQuestions.CommandType = CommandType.StoredProcedure;
                        deleteQuestions.Parameters.AddWithValue("@question_id", dataReader.GetInt32(0));
                    }
                }
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
                SqlCommand cmd = new SqlCommand("select test_id,test_name,number_of_questions,subject_id from test_view where test_id=@id", dbConnection.connection);
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
                        test.Subject.Id = reader.GetInt32(3);
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
        public List<QuestionModel> LoadQuestions(TestModel test)
        {
            List<QuestionModel> questions = new List<QuestionModel>();
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand getNumberOfQuestionsStoredInDatabase = new SqlCommand("select count(question_id) from questions where test_id=@test_id", dbConnection.connection);
                getNumberOfQuestionsStoredInDatabase.Parameters.AddWithValue("@test_id", test.Id);
                int numberOfQuestionsStoredInDB = (int)getNumberOfQuestionsStoredInDatabase.ExecuteScalar();
                SqlCommand getQuestoins = new SqlCommand("select top (@number) question_id, " +
                    "question_text,question_type,val from question_view where test_id=@test_id order by newid() ", dbConnection.connection);
                int copyQuestions = 0;
                getQuestoins.Parameters.AddWithValue("@test_id", test.Id);
                if ( numberOfQuestionsStoredInDB>= test.NumberOfQuestions)
                {
                    getQuestoins.Parameters.AddWithValue("@number", test.NumberOfQuestions);
                }
                else
                {
                    getQuestoins.Parameters.AddWithValue("@number", numberOfQuestionsStoredInDB);
                    copyQuestions = test.NumberOfQuestions - numberOfQuestionsStoredInDB;
                }
                SqlDataReader reader = getQuestoins.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        QuestionModel question = new QuestionModel();
                        question.Id = reader.GetInt32(0);
                        question.QuestionText = reader.GetString(1);
                        question.QuestionType = reader.GetString(2);
                        question.Value = reader.GetInt32(3);
                        question.Test = test;
                        question.ToString();
                        questions.Add(question);
                    }
                }
                reader.Close();
                QuestionController questionController = new QuestionController();
                
                foreach(QuestionModel question in questions)
                {
                    question.Answers = questionController.LoadAnswersList(question);
                    question.Choises = questionController.LoadChoicesList(question);
                    if (question.QuestionType == "Image")
                    {
                        SqlCommand getImage = new SqlCommand("select question_image from questions where question_id=@question_id", dbConnection.connection);
                        getImage.Parameters.AddWithValue("@question_id", question.Id);
                        SqlDataReader readImage = getImage.ExecuteReader();
                        while (readImage.Read())
                        {
                            question.Image = ConvertBinaryToImage((byte[])readImage["question_image"]);
                        }
                        readImage.Close();
                    }
                }
                for(int i = 0; i < copyQuestions; i++)
                {
                    questions.Add(questions[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                dbConnection.CloseConnection();

            }
            
            return questions;
        }
        public bool WriteTestResults(TestModel test,UserModel user,int score)
        {
            DbConnection dbConnection = new DbConnection();
            bool isSuccess = false;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("insert into results(user_id,test_id,mark) values (@user_id,@test_id,@mark)", dbConnection.connection);
                cmd.Parameters.AddWithValue("@user_id", user.Id);
                cmd.Parameters.AddWithValue("@test_id", test.Id);
                cmd.Parameters.AddWithValue("@mark", score);
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
    }
}
