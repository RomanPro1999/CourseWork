using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuizeSystemWindowsForms.Models;

namespace QuizeSystemWindowsForms.Controllers
{
    class UserController
    {
        public DataTable LoadUserDataTable()
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = null;
            try
            {
                dbConnection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select user_id,login,name,surname,email,role,average_mark,passed_tests_num from user_view", dbConnection.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return dataTable;
        }

        public bool DeleteUser(UserModel user)
        {
            DbConnection dbConnection = new DbConnection();
            bool isSuccess = false;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete_user", dbConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_id", user.Id);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return isSuccess;
        }

        public UserModel LoadUserByLogin(string login)
        {
            DbConnection dbConnection = new DbConnection();
            UserModel user = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select user_id,login,password,name,surname,email,role from user_view where login=@login", dbConnection.connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    user= new UserModel();
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Login = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Surname = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.Role = reader.GetString(6);
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return user;
        }
        public bool SaveChanges(UserModel user)
        {
            bool isSuccess = false;
            if (!user.ModelIsValid())
            {
                return isSuccess;
            }
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("edit_user", dbConnection.connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@email", user.Email);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows);
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
        public UserModel Login(UserModel user)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select user_id, login,password,name,surname,email,role from user_view where login=@login and password=@password", dbConnection.connection);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Login = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Surname = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.Role = reader.GetString(6);
                    }
                    return user;
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
            return null;
        }
        public bool RegisterUser(UserModel user)
        {
            bool isSuccess;
            DbConnection dbConnection = new DbConnection();
            SqlCommand cmd = new SqlCommand("register_user", dbConnection.connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (!user.ModelIsValid())
            {
                return false;
            }
            try
            {

                dbConnection.OpenConnection();
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.ExecuteNonQuery();

                isSuccess = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isSuccess = false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return isSuccess;
        }
        public UserModel LoadUserById(int id)
        {
            DbConnection dbConnection = new DbConnection();
            UserModel user = null;
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select user_id,login,password,name,surname,email,role from user_view where user_id=@id", dbConnection.connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    user = new UserModel();
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Login = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Surname = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.Role = reader.GetString(6);
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
            return user;
        }
    }
}
