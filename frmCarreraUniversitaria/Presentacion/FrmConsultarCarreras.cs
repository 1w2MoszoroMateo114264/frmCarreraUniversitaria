using frmCarreraUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCarreraUniversitaria.Presentacion
{
    public partial class FrmConsultarCarreras : Form
    {
        Entidades.Carrera_Servicios CarreServ;
        public FrmConsultarCarreras()
        {
            CarreServ = new Entidades.Carrera_Servicios();
            InitializeComponent();
        }

        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            txtTitulo.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Acceso_Datos.Parametros> lst = new List<Acceso_Datos.Parametros>();
            lst.Add(new Acceso_Datos.Parametros("@titulo", txtTitulo.Text));

            DataTable tabla = new Carrera_Servicios().ConsultarCarrera(lst);
            dgvCarreras.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvCarreras.Rows.Add(new object[] { ((int)fila["id_Carrera"]).ToString(),
                                                          fila["Titulo"].ToString()});
            }
        }

        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarreras.CurrentCell.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["ColumID"].Value);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
