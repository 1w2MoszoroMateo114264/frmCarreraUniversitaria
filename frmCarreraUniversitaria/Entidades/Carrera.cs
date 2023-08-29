using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCarreraUniversitaria.Entidades
{
    public class Carrera
    {
        private int id_Carrera;

        public int Id_Carrera
        {
            get { return id_Carrera; }
            set { id_Carrera = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<Detalle_Carrera> detalles;

        public List<Detalle_Carrera> Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
        public Carrera()
        {
            Detalles = new List<Detalle_Carrera>();
        }

        public void AgregarDetalle(Detalle_Carrera detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int posicion)
        {
            Detalles.RemoveAt(posicion);
        }


    }
}
