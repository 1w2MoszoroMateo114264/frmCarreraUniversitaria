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
    public partial class FrmNuevaCarrera : Form
    {
        private Entidades.Asignatura_Servicios AsigServ;
        private Entidades.Detalle_Carrera_Servicio DcServ;
        private Entidades.Carrera Carrera;
        public FrmNuevaCarrera()
        {
            AsigServ = new Entidades.Asignatura_Servicios();
            DcServ = new Entidades.Detalle_Carrera_Servicio();
            Carrera = new Entidades.Carrera();
            InitializeComponent();
            CargarCombo(cboAsignaturas);
            lblCarreraNro.Text = lblCarreraNro.Text + "  " + DcServ.ProximaCarrera().ToString();
        }

        private void CargarCombo(ComboBox combo)
        {
            DataTable tabla = new DataTable();
            tabla = AsigServ.TraerAsignatura();
            cboAsignaturas.DataSource = tabla;
            cboAsignaturas.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignaturas.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCarreraNro_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Primero hay que validar los datos
            if(cboAsignaturas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar una Asignatura.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe cargar un Titulo.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbtPrimerCuatri.Checked == false && rbtSegundoCuatri.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dtpAnioCursado.Value.Year < DateTime.Now.Year)
            {
                MessageBox.Show("Debe seleccionar un año de cursado Valido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["ColumAsignacion"].Value.ToString().Equals(cboAsignaturas.Text))
                {
                    MessageBox.Show("Esta asignatura ya esta cargada.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DataRowView item = (DataRowView)cboAsignaturas.SelectedItem;
            int id_asig = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();
            Entidades.Asignatura Asignatura = new Entidades.Asignatura(id_asig, nombre);

            DateTime cursado = Convert.ToDateTime(dtpAnioCursado.Value);
            int Cuatrimestre = 0;
            if (rbtPrimerCuatri.Checked == true)
            {
                Cuatrimestre = 1;
            }
            if(rbtSegundoCuatri.Checked == true)
            {
                Cuatrimestre = 2;
            }
            Entidades.Detalle_Carrera detalle = new Entidades.Detalle_Carrera(Asignatura, cursado, Cuatrimestre);
            Carrera.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(detalle.Asignatura.Id_Asignatura,
                                detalle.Asignatura.Nombre,
                                detalle.AnioCursado,
                                detalle.Cuatrimestre,
                                "Quitar");

        }
        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                Carrera.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
            }
        }
        private void dtpAnioCursado_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
