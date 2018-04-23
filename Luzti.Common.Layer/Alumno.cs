using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.Common.Layer
{
    public class Alumno
    {
        public Direccion Direccion { get; }

        public Alumno(Direccion direccion)
        {
            this.Direccion = direccion;
        }

        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string  Dni { get; set; }


    }
}
