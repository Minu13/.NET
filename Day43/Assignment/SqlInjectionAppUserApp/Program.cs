using Microsoft.Data.SqlClient;

namespace SqlInjectionAppUserApp
{

public class Program
    {
        static void Main(string[] args)
        {

            // InitializeDatabase();


            //InjectVulnerableSqlQuery();

            PreventSqlInjection();

        }

        private static void InitializeDatabase()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                
                var createTableCmd = new SqlCommand(
                    "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AppUser' AND xtype='U')" +
                    " CREATE TABLE AppUser (" +
                    " userID INT PRIMARY KEY," +
                    " password VARCHAR(255)" +
                    ")", con);
                createTableCmd.ExecuteNonQuery();

               
                var insertDataCmd1 = new SqlCommand("IF NOT EXISTS (SELECT * FROM AppUser WHERE userID = 1) INSERT INTO AppUser (userID, password) VALUES (1, 'password123')", con);
                var insertDataCmd2 = new SqlCommand("IF NOT EXISTS (SELECT * FROM AppUser WHERE userID = 2) INSERT INTO AppUser (userID, password) VALUES (2, 'secret456')", con);
                insertDataCmd1.ExecuteNonQuery();
                insertDataCmd2.ExecuteNonQuery();

                con.Close();
            }
        }

        private static void PreventSqlInjection()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);

            Console.WriteLine("Enter a user ID:");
            var userIdInput = Console.ReadLine();

            if (!int.TryParse(userIdInput, out int userId))
            {
                Console.WriteLine("Invalid user ID. Please enter a numeric value.");
                return;
            }

            Console.WriteLine("Enter a password:");
            var password = Console.ReadLine();

            var cmd = new SqlCommand("SELECT * FROM AppUser WHERE userID = @userID AND password = @password", con);
            cmd.Parameters.AddWithValue("@userID", userId); 
            cmd.Parameters.AddWithValue("@password", password); 

            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed!");
            }
            con.Close();
        }

        private static void InjectVulnerableSqlQuery()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);

            Console.WriteLine("Enter a user ID:");
            var userId = Console.ReadLine();

            Console.WriteLine("Enter a password:");
            var password = Console.ReadLine();

            var cmd = new SqlCommand("SELECT * FROM AppUser WHERE userID = " + userId + " AND password = '" + password + "'", con); 
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed!");
            }
            con.Close();
        }
    }

}
    

