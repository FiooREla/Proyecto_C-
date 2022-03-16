using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;

namespace ClassLibrary2
{
    public class D_Marca
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
    
        //public List<E_Marca> listarMarcas(string buscar)
        //{

        //}
    }
}
