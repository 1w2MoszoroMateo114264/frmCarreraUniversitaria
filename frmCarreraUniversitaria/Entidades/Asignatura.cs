using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCarreraUniversitaria.Entidades
{
    public class Asignatura
    {
        private int id_Asignatura;

        public int Id_Asignatura
        {
            get { return id_Asignatura; }
            set { id_Asignatura = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Asignatura(int id_Asignatura,string nombre)
        {
            this.id_Asignatura=id_Asignatura;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
