using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class tratamiento
    {
        public int ID_tratamiento { get; set; }
        public paciente oPaciente { get; set; }
        public rol TroDoctor { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set;}
        public List<DetalleTratamiento> oDetalleTratamiento { get; set; }
        public string FechaCreacion { get; set; }


    }
}
