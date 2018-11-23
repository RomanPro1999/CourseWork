using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizeSystemWindowsForms.Models;
using System.Data.SqlClient;

namespace QuizeSystemWindowsForms.Controllers
{
    class EditUserController
    {
        public bool SaveChanges(UserModel user)
        {
            bool isSuccess=false;
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
                int rows =cmd.ExecuteNonQuery();
                Console.WriteLine(rows);
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
    }
}
