using System;
using System.Collections.Generic;
using System.Data;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class UserMySqlDataStore : IDomainDataStore
    {
        private MySqlDataStoreConnection Connection;
        public UserMySqlDataStore(MySqlDataStoreConnection conn)
        {
            Connection = conn;
        }
        public void Create(IDomain o)
        {
            // INSERT INTO users (name, sys_id) VALUES (o.Name, o.GetId());
            throw new System.NotImplementedException();
        }

        public void Delete(string ID)
        {
            // DELETE FROM users WHERE sys_id = 'ID';
            throw new System.NotImplementedException();
        }

        public IDomain Read(string ID)
        {
            var buf = new UserEntity();
            var cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM users WHERE sys_id = '" + ID + "';";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                buf.SetId(reader.GetString(3));
                buf.Name = reader.GetString(2);
            }
            reader.Close();
            Connection.Close();

            return buf;
        }

        public IDomain[] ReadAll()
        {
            var buf = new List<UserEntity>();
            var cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM users;";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var User = new UserEntity();
                User.SetId(reader.GetString(3));
                User.Name = reader.GetString(2);
                buf.Add(User);
            }
            reader.Close();
            Connection.Close();

            return buf.ToArray();
        }

        public void Update(IDomain o)
        {
            // UPDATE users ...
            throw new System.NotImplementedException();
        }
    }
}