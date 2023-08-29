namespace frmCarreraUniversitaria.Presentacion
{
    partial class FrmNuevaCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCarreraNro = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.dtpAnioCursado = new System.Windows.Forms.DateTimePicker();
            this.rbtPrimerCuatri = new System.Windows.Forms.RadioButton();
            this.rbtSegundoCuatri = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreraNro.Location = new System.Drawing.Point(32, 27);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(89, 18);
            this.lblCarreraNro.TabIndex = 0;
            this.lblCarreraNro.Text = "Carrera N°";
            this.lblCarreraNro.Click += new System.EventHandler(this.lblCarreraNro_Click);
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.Location = new System.Drawing.Point(105, 113);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(81, 18);
            this.lblAsignatura.TabIndex = 1;
            this.lblAsignatura.Text = "Asignatura:";
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioCursado.Location = new System.Drawing.Point(67, 152);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(119, 18);
            this.lblAnioCursado.TabIndex = 2;
            this.lblAnioCursado.Text = "Año de Cursado:";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuatrimestre.Location = new System.Drawing.Point(89, 187);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(97, 18);
            this.lblCuatrimestre.TabIndex = 3;
            this.lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(206, 114);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(254, 21);
            this.cboAsignaturas.TabIndex = 4;
            this.cboAsignaturas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnioCursado.Location = new System.Drawing.Point(206, 152);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(160, 20);
            this.dtpAnioCursado.TabIndex = 5;
            this.dtpAnioCursado.ValueChanged += new System.EventHandler(this.dtpAnioCursado_ValueChanged);
            // 
            // rbtPrimerCuatri
            // 
            this.rbtPrimerCuatri.AutoSize = true;
            this.rbtPrimerCuatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPrimerCuatri.Location = new System.Drawing.Point(206, 187);
            this.rbtPrimerCuatri.Name = "rbtPrimerCuatri";
            this.rbtPrimerCuatri.Size = new System.Drawing.Size(121, 19);
            this.rbtPrimerCuatri.TabIndex = 6;
            this.rbtPrimerCuatri.TabStop = true;
            this.rbtPrimerCuatri.Text = "1°er Cuatrimestre";
            this.rbtPrimerCuatri.UseVisualStyleBackColor = true;
            // 
            // rbtSegundoCuatri
            // 
            this.rbtSegundoCuatri.AutoSize = true;
            this.rbtSegundoCuatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSegundoCuatri.Location = new System.Drawing.Point(336, 187);
            this.rbtSegundoCuatri.Name = "rbtSegundoCuatri";
            this.rbtSegundoCuatri.Size = new System.Drawing.Size(124, 19);
            this.rbtSegundoCuatri.TabIndex = 7;
            this.rbtSegundoCuatri.TabStop = true;
            this.rbtSegundoCuatri.Text = "2°do Cuatrimestre";
            this.rbtSegundoCuatri.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(483, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 26);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumId,
            this.ColumAsignacion,
            this.ColumCursado,
            this.ColumCuatrimestre,
            this.ColumAccion});
            this.dgvDetalle.Location = new System.Drawing.Point(35, 229);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(536, 191);
            this.dgvDetalle.TabIndex = 9;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // ColumId
            // 
            this.ColumId.HeaderText = "";
            this.ColumId.Name = "ColumId";
            this.ColumId.ReadOnly = true;
            this.ColumId.Visible = false;
            // 
            // ColumAsignacion
            // 
            this.ColumAsignacion.HeaderText = "Asignacion";
            this.ColumAsignacion.Name = "ColumAsignacion";
            this.ColumAsignacion.ReadOnly = true;
            this.ColumAsignacion.Width = 180;
            // 
            // ColumCursado
            // 
            this.ColumCursado.HeaderText = "Año De Cursado";
            this.ColumCursado.Name = "ColumCursado";
            this.ColumCursado.ReadOnly = true;
            this.ColumCursado.Width = 95;
            // 
            // ColumCuatrimestre
            // 
            this.ColumCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColumCuatrimestre.Name = "ColumCuatrimestre";
            this.ColumCuatrimestre.ReadOnly = true;
            this.ColumCuatrimestre.Width = 118;
            // 
            // ColumAccion
            // 
            this.ColumAccion.HeaderText = "Accion";
            this.ColumAccion.Name = "ColumAccion";
            this.ColumAccion.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(182, 440);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 26);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(362, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 26);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(138, 71);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(206, 72);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(198, 20);
            this.txtTitulo.TabIndex = 13;
            // 
            // FrmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 487);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtSegundoCuatri);
            this.Controls.Add(this.rbtPrimerCuatri);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblCarreraNro);
            this.Name = "FrmNuevaCarrera";
            this.Text = "Nueva Carrera";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.DateTimePicker dtpAnioCursado;
        private System.Windows.Forms.RadioButton rbtPrimerCuatri;
        private System.Windows.Forms.RadioButton rbtSegundoCuatri;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn ColumAccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}