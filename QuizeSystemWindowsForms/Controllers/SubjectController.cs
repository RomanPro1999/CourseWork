using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using QuizeSystemWindowsForms.Models;
using System.IO;

namespace QuizeSystemWindowsForms.Controllers
{
    class SubjectController
    {
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
        public List<SubjectModell> LoadSubjectsList()
        {
            List<SubjectModell> subjects = new List<SubjectModell>();
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
                        SubjectModell subject = new SubjectModell();
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
        private byte [] ConvertImageToBinary(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
        private Image ConvertBinaryToImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public bool AddSubject(SubjectModell subject)
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
        public bool EditSubject(SubjectModell subject)
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
        public bool DeleteSubject(SubjectModell subject)
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
        public SubjectModell LoadSubjectByName(string name)
        {
            DbConnection dbConnection = new DbConnection();
            SubjectModell subject = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from subjects where subject_name=@name", dbConnection.connection);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    subject = new SubjectModell();
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
