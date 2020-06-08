using PasswordManager.Helper;
using PasswordManager.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace PasswordManager.Modules
{
    public class TrackModules
    {
        public int SaveTrackDetails(Track objtrack)
        {
            int result = -1;
            using (SqlConnection con = new SqlConnection(DBAccess.DBConnection))
            {
                SqlCommand cmd = new SqlCommand("SP_SAVE_TRACK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@website", objtrack.DomainName);
                cmd.Parameters.AddWithValue("@username", objtrack.UserName);
                cmd.Parameters.AddWithValue("@password", objtrack.Password);
                con.Open();
                result =Convert.ToInt32(cmd.ExecuteScalar());
            }
            return result;
        }
    }
}