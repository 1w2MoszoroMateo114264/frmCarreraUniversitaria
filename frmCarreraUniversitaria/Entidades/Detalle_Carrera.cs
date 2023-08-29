using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCarreraUniversitaria.Entidades
{
    public class Detalle_Carrera
    {
        private Asignatura asignatura;

        public Asignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        private DateTime anioCursado;

        public DateTime AnioCursado
        {
            get { return anioCursado; }
            set { anioCursado = value; }
        }

        private int cuatrimestre;

        public int Cuatrimestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }

        public Detalle_Carrera(Asignatura asignatura, DateTime anioCursado, int cuatrimestre)
        {
            this.asignatura = asignatura;
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
        }

    }
}
