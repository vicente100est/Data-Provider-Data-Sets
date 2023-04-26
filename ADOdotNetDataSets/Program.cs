namespace ADOdotNetDataSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ta = new DataSet1TableAdapters.CustomersTableAdapter();
            var dt = ta.GetData();

            foreach (DataSet1.CustomersRow row in dt.Rows)
            {
                Console.WriteLine("{0},{1},{2}",
                    row.CustomerID, row.CompanyName, row.ContactTitle);
            }
            dt.Dispose();
            ta.Dispose();
        }
    }
}