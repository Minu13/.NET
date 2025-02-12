
using Microsoft.Data.SqlClient;

namespace CURDOperationsProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            // CaseStudy2();
            // CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            // DELETE Operation: Delete a product
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM product WHERE name = @name", con);
            cmd.Parameters.AddWithValue("@name", "New Product"); 
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Product deleted successfully.");
            }
            con.Close();

        }

        private static void CaseStudy3()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("UPDATE product SET price = @price WHERE name = @name", con);
            cmd.Parameters.AddWithValue("@price", 79.99);
            cmd.Parameters.AddWithValue("@name", "New Product"); 
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Product updated successfully.");
            }
            con.Close();

        }

        private static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM product", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Name: {reader["name"]}, Quantity: {reader["quantity"]}, Price: {reader["price"]}");
            }
            con.Close();
        }

        private static void CaseStudy1()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("INSERT INTO product (name, quantity, price) VALUES (@name, @quantity, @price)", con);
            cmd.Parameters.AddWithValue("@name", "Mouse");
            cmd.Parameters.AddWithValue("@quantity", 10);
            cmd.Parameters.AddWithValue("@price", 90.99);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Product inserted successfully.");
            }
            con.Close();
        }
    }
}
