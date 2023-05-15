using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public  class CN_Usuario
    {

        private CD_Usuario objcd_usuario = new CD_Usuario();
        public List<rol> Listar()
        {
            return objcd_usuario.Listar();  


        } // fin listar();
    }// fin CN_Usuario
}
