// using MySql.Data.MySqlClient;
using System.Data;

namespace BlabberApp.DataStore
{
    public class MySqlDataStoreConnection : IDbConnection
    {
        public MySqlDataStoreConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; set; }

        public int ConnectionTimeout => throw new System.NotImplementedException();

        public string Database => "";

        public ConnectionState State => throw new System.NotImplementedException();

        private MySql.Data.MySqlClient.MySqlConnection connection;

        public IDbTransaction BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
        }

        public IDbCommand CreateCommand()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Open()
        {
            try
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
        }
    }
}