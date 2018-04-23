using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.DataAccess.Data
{
    public abstract class BaseDao<T> : IDao<T>
    {
        public abstract int Add(T entity);


        public abstract SqlConnection GetConnnection();
       
    }
}
