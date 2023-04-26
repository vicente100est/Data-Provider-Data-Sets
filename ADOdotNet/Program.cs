using System.Data;
using System.Data.SqlClient;

namespace ADOdotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Data Provider");

            string connectionString = "Data Source=localhost;" +
                "Initial Catalog=Northwind;" +
                "trusted_connection=true;" +
                "Encrypt=False;";

            string query = "SELECT Customers.CustomerID," +
                    "Customers.CompanyName," +
                    "Customers.ContactTitle " +
                "FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0},{1},{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}