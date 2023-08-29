using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmCarreraUniversitaria.Entidades
{
    public class Asignatura_Servicios
    {
        private Acceso_Datos.Acceso_Datos oAD;
        public Asignatura_Servicios()
        {
            oAD = new Acceso_Datos.Acceso_Datos();
        }
        public DataTable TraerAsignatura()
        {
            return oAD.ConsultarTabla("sp_ConsultarAsignaturas");
        }

    }
}
