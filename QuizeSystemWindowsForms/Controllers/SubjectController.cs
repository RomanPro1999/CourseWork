using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using QuizeSystemWindowsForms.Models;
using QuizeSystemWindowsForms;
using System.IO;

namespace QuizeSystemWindowsForms.Controllers
{
    class SubjectController
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
        public DataTable LoadSubjectsTable()
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = null;
            try
            {
                dbConnection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from subjects", dbConnection.connection);
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
        public List<SubjectModel> LoadSubjectsList()
        {
            List<SubjectModel> subjects = new List<SubjectModel>();
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from subjects", dbConnection.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SubjectModel subject = new SubjectModel();
                        subject.Id = reader.GetInt32(0);
                        subject.Name = reader.GetString(1);
                        subject.Image = ConvertBinaryToImage((byte[])reader["subject_image"]);
                        subjects.Add(subject);
                    }
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
            return subjects;
        }
       
        public bool AddSubject(SubjectModel subject)
        {
            bool isSuccess=false;
            DbConnection dbConnection = new DbConnection();
            SqlCommand cmd = new SqlCommand("add_subject", dbConnection.connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           
            try
            {

                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@name", subject.Name);
                cmd.Parameters.AddWithValue("@image", ConvertImageToBinary(subject.Image));
                int rows=cmd.ExecuteNonQuery();
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
        public bool EditSubject(SubjectModel subject)
        {
            bool isSuccess = false;
            
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("edit_subject", dbConnection.connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", subject.Id);
                cmd.Parameters.AddWithValue("@name", subject.Name);
                cmd.Parameters.AddWithValue("@image", ConvertImageToBinary(subject.Image));
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
        public bool DeleteSubject(SubjectModel subject)
        {
            DbConnection dbConnection = new DbConnection();
            bool isSuccess = false;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete_subject", dbConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", subject.Name);
                int rows=cmd.ExecuteNonQuery();
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
        public SubjectModel LoadSubjectById(int id)
        {
            DbConnection dbConnection = new DbConnection();
            SubjectModel subject = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from subjects where subject_id=@id", dbConnection.connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    subject = new SubjectModel();
                    while (reader.Read())
                    {
                        subject.Id = reader.GetInt32(0);
                        subject.Name = reader.GetString(1);
                        subject.Image = ConvertBinaryToImage((byte[])reader["subject_image"]);
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
            return subject;
        }
        public SubjectModel LoadSubjectByName(string name)
        {
            DbConnection dbConnection = new DbConnection();
            SubjectModel subject = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from subjects where subject_name=@name", dbConnection.connection);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    subject = new SubjectModel();
                    while (reader.Read())
                    {
                        subject.Id = reader.GetInt32(0);
                        subject.Name = reader.GetString(1);
                        subject.Image = ConvertBinaryToImage((byte[])reader["subject_image"]);
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
            return subject;
        }



    }
}
