using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad; //capa entidad tiene atributos
using System.Data; //tiene clases data table, sql command(comunica con sp)

namespace CapaDatos
{
    public class D_Categoria
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Categoria> listarCategoria(string buscar)
        {
            SqlDataReader LeerFilas;
            //sqldatareader trae registros
            //sqlcommand hace las transacciones
            SqlCommand cmd = new SqlCommand("SP_BUSCARCATEGORIA", conexion);
            //debemos ponerle que tipo de procedimiento es
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            //el procedimiento almacenado tiene un parametro en la db, y ahi que pasarle
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader(); //lee ejecucion de filas

            //hasta aca busca parametros de la fila de registros, entonces damos lista de objetos

            List<E_Categoria> Listar = new List<E_Categoria>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Categoria
                {
                    Idcategoria = LeerFilas.GetInt32(0),
                    Codigocategoria1 = LeerFilas.GetString(1),
                    Nombrecategoria1 = LeerFilas.GetString(2),
                    Descripcioncategoria = LeerFilas.GetString(3)
                }
                    ) ;
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }


        public void insertarCategora(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Categoria.Nombrecategoria1);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Categoria.Descripcioncategoria);

            cmd.ExecuteNonQuery(); //ejecutar consultas con sql comman que se ejecuta co execute non query
            conexion.Close();
        }

        public void editarCategoria(E_Categoria Categoria) //categoria es objeto de comunicacion
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", Categoria.Idcategoria);
            cmd.Parameters.AddWithValue("@NOMBRE", Categoria.Nombrecategoria1);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Categoria.Descripcioncategoria);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("IDCATEGORIA", Categoria.Idcategoria);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
