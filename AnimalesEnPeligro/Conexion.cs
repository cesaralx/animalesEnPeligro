using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AnimalesEnPeligro
{
    class Conexion
    {
        public static SqlConnection conn = new SqlConnection("Initial Catalog=Proyectos; Data Source=localhost; Integrated Security=SSPI;");
    }
}
