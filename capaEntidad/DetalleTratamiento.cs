using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class DetalleTratamiento
    {
        public int ID_DetalleTratamiento { get; set; }
        public tratamiento oTratamiento { get; set; }
        public paciente DToPaciente { get; set; }

        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public string FechaCreacion { get; set; }

    }
}
