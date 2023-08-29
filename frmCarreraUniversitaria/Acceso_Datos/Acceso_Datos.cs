using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmCarreraUniversitaria.Acceso_Datos
{
    public class Acceso_Datos
    {
        private string CadenaConexion = @"Data Source=MATEO-PC;Initial Catalog=Carrera;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;

        public Acceso_Datos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }
        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarTabla(string sp_nombre)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = sp_nombre;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public int ProximoInsert(string sp_nombre)
        {
            Conectar();
            comando.CommandText = sp_nombre;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            Desconectar();
            return Convert.ToInt32(parametro.Value);
        }



    }
}
