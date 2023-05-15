using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using capaEntidad;

namespace capaDatos
{
    public  class CD_Usuario
    {
        public List<rol> Listar()
        {
            List<rol> lista = new List<rol>();

            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    string query = "select * from doctor";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new rol()
                            {
                                ID_doctor = Convert.ToInt32(dr["ID_doctor"]),
                                NombreDoc = dr["NombreDoc"].ToString(),
                                ApellidoDoc = dr["ApellidoDoc"].ToString(),
                                clave = dr["clave"].ToString(),


                            }) ;

                        }// fin while
                    } // fin  using (SqlDataReader dr = cmd.ExecuteReader())

                }//fin try
                    catch (Exception ex) {
                        lista = new List<rol>();
                    } // fin catch


            }// fin using (SqlConnection oconexion = new SqlConnection(conexion.cadena))

            return lista;
        }

    }
}
