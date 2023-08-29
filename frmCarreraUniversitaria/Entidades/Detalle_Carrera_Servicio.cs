using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmCarreraUniversitaria.Entidades
{
    public class Detalle_Carrera_Servicio
    {
        private Acceso_Datos.Acceso_Datos oAD;
        public Detalle_Carrera_Servicio()
        {
            oAD = new Acceso_Datos.Acceso_Datos();
        }

        public int ProximaCarrera()
        {
            return oAD.ProximoInsert("Sp_ProximaCarrera");
        }



    }
}
