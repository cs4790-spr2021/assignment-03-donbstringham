using MySql.Data.MySqlClient;
using System.Data;

namespace BlabberApp.DataStore
{
    public class MySqlDataStoreCommand : IDbCommand
    {
        public string CommandText { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int CommandTimeout { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public CommandType CommandType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbConnection Connection { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IDataParameterCollection Parameters => throw new System.NotImplementedException();

        public IDbTransaction Transaction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public UpdateRowSource UpdatedRowSource { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        private MySqlCommand command;

        public MySqlDataStoreCommand(MySqlConnection conn)
        {
            command = new MySqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.TableDirect;
        }

        public void Cancel()
        {
            throw new System.NotImplementedException();
        }

        public IDbDataParameter CreateParameter()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public int ExecuteNonQuery()
        {
            throw new System.NotImplementedException();
        }

        public IDataReader ExecuteReader()
        {
            throw new System.NotImplementedException();
        }

        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            throw new System.NotImplementedException();
        }

        public object ExecuteScalar()
        {
            throw new System.NotImplementedException();
        }

        public void Prepare()
        {
                // command.Prepare();
            throw new System.NotImplementedException();
        }
    }
}