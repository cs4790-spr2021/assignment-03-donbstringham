using System.Data;
using System.Xml.Linq;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public interface IMySQL: IDomainDataStore
    {
         IDomain[] ReadAll();
    }
}