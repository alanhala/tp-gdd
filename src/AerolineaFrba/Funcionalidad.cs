using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Funcionalidad
    {
        public static int obtenerID(string descripcion)
        {
            return Commons.getInstance().getIDFrom("IDFuncionalidad", descripcion);
        }

/*         public string obtenerCantFuncionalidades(int idRol)
             {
                   System.Data.SqlClient.SqlDataReader reader;
                   string query = "SELECT JUST_DO_IT.cantFuncionalidadQuePosee (" + idRol + ") AS cant";
                   reader = Server.getInstance().query(query);
                   reader.Read();
                   int cant = reader["cant"]
                   reader.Close();
                   return cant;
               }
         */
    }

}
