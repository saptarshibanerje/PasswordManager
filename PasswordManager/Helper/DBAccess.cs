using System.Configuration;

namespace PasswordManager.Helper
{
    public class DBAccess
    {
        public static string DBConnection { get { return string.Format(ConfigurationManager.ConnectionStrings[""].ConnectionString); } }
    }
}