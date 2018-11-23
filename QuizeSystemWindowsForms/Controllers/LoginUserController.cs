using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data.SqlClient;

namespace QuizeSystemWindowsForms.Controllers
{
    class LoginUserController
    {
        public UserModel Login(UserModel user)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from user_view where login=@login and password=@password",dbConnection.connection);
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return null;
        }
    } 
}
