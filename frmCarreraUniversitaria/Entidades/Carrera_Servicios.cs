using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCarreraUniversitaria.Entidades
{
    public class Carrera_Servicios
    {
        private Acceso_Datos.Acceso_Datos oAD;
        public Carrera_Servicios()
        {
            oAD = new Acceso_Datos.Acceso_Datos();
        }

        public bool InsertarCarrera(Carrera oCarrera)
        {
            return oAD.ConfirmarCarrera(oCarrera);
        }
    }
}
