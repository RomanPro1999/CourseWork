using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data.SqlClient;

namespace QuizeSystemWindowsForms.Controllers
{
    class RegisterUserController
    {
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
            catch(Exception ex)
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
    }
}
