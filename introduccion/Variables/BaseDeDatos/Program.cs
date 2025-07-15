namespace BaseDeDatos;

using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            DB db = new DB(@"DESKTOP-N9E58US\SQLEXPRESS", "CSharpDB", "", "");
            db.Connect();

            db.Close();

        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex);
        }
    }
}