using System.Data.SqlClient;

namespace StudentsDbApp.Services.DBHelper
{
    public static class DBUtil
    {
        public static SqlConnection? GetConnection() 
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration =  configurationBuilder.Build();
            string? connString = configuration.GetConnectionString("DefaultConnection");

            try
            {
                SqlConnection conn = new(connString);
                return conn;

            } catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
