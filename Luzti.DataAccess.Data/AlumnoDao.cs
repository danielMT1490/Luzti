using Luzti.Common.Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Luzti.DataAccess.Data
{
    public class AlumnoDao : BaseDao<Alumno>
    {
        public override int Add(Alumno entity)
        {
            int id =0;
            try
            {
                using (SqlConnection _conn = GetConnnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO ALUMNO(" +
                        "Nombre , Apellido , Dni)values" +
                        "(@Nombre , @Apellido ,@Dni);SET @ID=SCOPE_IDENTITY;", _conn))
                    {
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                        cmd.Parameters["@Nombre"].Value = entity.Nombre;
                        cmd.Parameters.Add("@Apellido", SqlDbType.VarChar);
                        cmd.Parameters["@Apellido"].Value = entity.Nombre;
                        cmd.Parameters.Add("@Dni", SqlDbType.VarChar);
                        cmd.Parameters["@Dni"].Value = entity.Nombre;

                        var IdParameter = new SqlParameter("@Id", SqlDbType.Int);
                        IdParameter.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(IdParameter);
                        cmd.ExecuteNonQuery();
                        id = Convert.ToInt32(IdParameter.Value);
                    }
                }
                return id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override SqlConnection GetConnnection()
        {
            var _conn = new SqlConnection(SqlConfiguration.GetConnectionString());
            return _conn;
        }
    }
}
