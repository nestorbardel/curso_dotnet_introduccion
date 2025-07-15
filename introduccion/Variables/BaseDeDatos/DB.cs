namespace BaseDeDatos;

using System.Data.SqlClient;

public class DB
{
    private string _connectionstring;
    protected SqlConnection _connection;

    public DB(string server, string db, string user, string password)
    {
        _connectionstring = $"Data Source={server}; Initial Catalog={db};" +
                            $"User={user};Password={password}";
    }

    public void Connect()
    {
        _connection = new SqlConnection(this._connectionstring);
        _connection.Open();
    }

    public void Close()
    {
        if (this._connection != null && this._connection.State == System.Data.ConnectionState.Open)
        {
            this._connection.Close();
        }
    }
}