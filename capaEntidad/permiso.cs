using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class permiso
    {
        public int ID_permiso { get; set; }
        public rol oDoctor { get; set; }
        public int NombreMenu { get; set; }
        public int FechaRegistro { get; set; }

    }
}
