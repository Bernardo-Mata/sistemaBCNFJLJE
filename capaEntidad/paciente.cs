using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class paciente
    {

        public int ID_paciente { get; set; }
        public string NombrePaciente { get; set; }

        public string ApellidoPaciente { get;  set; }
        public string EmailPaciente { get;  set; }
        public string GeneroPaciente { get; set;}
        public string TelefonoPaciente { get;set; }
        public bool estado { get; set;}
    }
}
