using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class UserMySqlDataStore : IDomainDataStore, IMySQL
    {
        public void Create(IDomain o)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string ID)
        {
            throw new System.NotImplementedException();
        }

        public IDomain Read(string ID)
        {
            throw new System.NotImplementedException();
        }

        public IDomain[] ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(IDomain o)
        {
            throw new System.NotImplementedException();
        }
    }
}