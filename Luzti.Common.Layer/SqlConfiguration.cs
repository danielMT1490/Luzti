using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.Common.Layer
{
    public class SqlConfiguration
    {
        public static string GetConnectionString()
        {
            var valueAppConfig = ConfigurationManager.AppSettings["Database"];
            var encriptconnection = Environment.GetEnvironmentVariable(valueAppConfig, EnvironmentVariableTarget.User);
            byte[] desencriptar = Convert.FromBase64String(encriptconnection);
            return Encoding.Unicode.GetString(desencriptar)
        }

    }
}
