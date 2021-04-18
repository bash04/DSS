using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Acceso_Datos
{
    public abstract class ConexionSql
    {

   
        protected SqlConnection obtenerConexion()
        {
            return new SqlConnection(
      "Server=(local); DataBase=dss_banco; integrated security=true"  );

        }

    }
}
