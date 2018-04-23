using Luzti.Common.Layer;
using Luzti.DataAccess.Data;
using System;
using System.Transactions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.Business.Rules
{
    public class AlumnoBl
    {
        private readonly BaseDao<Alumno> _baseDao;

        public AlumnoBl(AlumnoDao AlumnoDao)
        {
            this._baseDao = AlumnoDao;
        }

        public int Add(Alumno alumno)
        {
            try
            {
                int id;
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    alumno.IdAlumno = _baseDao.Add(alumno);
                    alumno.Direccion.IdAlumno = alumno.IdAlumno;
                    id = alumno.IdAlumno;
                    transactionScope.Complete();
                }
                return id;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
