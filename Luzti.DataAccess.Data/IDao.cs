using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.DataAccess.Data
{
    public interface IDao<T>
    {
        int Add(T entity);
        SqlConnection GetConnnection();
    }
}
