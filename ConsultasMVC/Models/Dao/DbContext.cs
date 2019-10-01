using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMVC.Models.Dao
{
    public class DbContext
    {
        protected SqlConnection Conexion = new SqlConnection(
            "Server=DESKTOP-4FVONF2;DataBase=Practica_Patrones;Integrated Security=true");

    }
}
