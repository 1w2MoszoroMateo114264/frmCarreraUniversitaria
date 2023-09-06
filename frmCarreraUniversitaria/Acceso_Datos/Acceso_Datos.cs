using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using frmCarreraUniversitaria.Entidades;

namespace frmCarreraUniversitaria.Acceso_Datos
{
    public class Acceso_Datos
    {
        private string CadenaConexion = @"Data Source=MATEO-PC;Initial Catalog=CarreraUniversitaria;Integrated Security=True";
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

        public DataTable ConsultarTabla(string sp_nombre, List<Parametros> lstParametros)
        {
            Conectar();
            comando.CommandText= sp_nombre;
            comando.Parameters.Clear();
            foreach (Parametros param in lstParametros)
            {
                comando.Parameters.AddWithValue(param.Clave, param.Valor);
            }
            DataTable tabla = new DataTable();
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


        public bool ConfirmarCarrera(Carrera oCarrera)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "sp_insertarCarrera";
                comando.Parameters.AddWithValue("@titulo", oCarrera.Nombre);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_carrera";
                parametro.SqlDbType= SqlDbType.Int;
                parametro.Direction= ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();

                int idCarrera = (int)parametro.Value;
                int idDetalle = 1;
                SqlCommand cmdComando;

                foreach (Detalle_Carrera dp in oCarrera.Detalles)
                {
                    cmdComando = new SqlCommand("sp_insertarDetalle", conexion, t);
                    cmdComando.CommandType = CommandType.StoredProcedure;
                    cmdComando.Parameters.AddWithValue("@id_carrera", idCarrera);
                    cmdComando.Parameters.AddWithValue("@detalle", idDetalle);
                    cmdComando.Parameters.AddWithValue("@anioCursado", dp.AnioCursado.ToString("yyyy"));
                    cmdComando.Parameters.AddWithValue("@Cuatrimestre", dp.Cuatrimestre);
                    cmdComando.Parameters.AddWithValue("@id_asignatura", dp.Asignatura.Id_Asignatura);
                    cmdComando.ExecuteNonQuery();
                    idDetalle++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return resultado;
        }
    }
}
