namespace Acabiblioteca
{
    partial class Frmusuarios
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
            dgvLibros = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            pnldatos = new Panel();
            btnGUARDAR = new Button();
            TXTEXIXTENCIAS = new TextBox();
            TXTAÑO = new TextBox();
            TXTCATEGORIAS = new TextBox();
            TXTTITULO = new TextBox();
            LBLEXISTENCIAS = new Label();
            LBLaño = new Label();
            ISNBTXT = new TextBox();
            LBLcategoria = new Label();
            Lbltitulos = new Label();
            LBLIDENTIFICACION = new Label();
            lblbuscar = new Label();
            BTNbuscar = new Button();
            Titulo = new Panel();
            lbltitulo = new Label();
            PNLbusqueda = new Panel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            pnldatos.SuspendLayout();
            Titulo.SuspendLayout();
            PNLbusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(-17, 409);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(1071, 150);
            dgvLibros.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(653, 222);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(489, 222);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(316, 222);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 29);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // pnldatos
            // 
            pnldatos.Controls.Add(btnLimpiar);
            pnldatos.Controls.Add(btnEliminar);
            pnldatos.Controls.Add(btnModificar);
            pnldatos.Controls.Add(btnGUARDAR);
            pnldatos.Controls.Add(TXTEXIXTENCIAS);
            pnldatos.Controls.Add(TXTAÑO);
            pnldatos.Controls.Add(TXTCATEGORIAS);
            pnldatos.Controls.Add(TXTTITULO);
            pnldatos.Controls.Add(LBLEXISTENCIAS);
            pnldatos.Controls.Add(LBLaño);
            pnldatos.Controls.Add(ISNBTXT);
            pnldatos.Controls.Add(LBLcategoria);
            pnldatos.Controls.Add(Lbltitulos);
            pnldatos.Controls.Add(LBLIDENTIFICACION);
            pnldatos.Location = new Point(-17, 145);
            pnldatos.Name = "pnldatos";
            pnldatos.Size = new Size(1071, 258);
            pnldatos.TabIndex = 6;
            // 
            // btnGUARDAR
            // 
            btnGUARDAR.Location = new Point(170, 222);
            btnGUARDAR.Name = "btnGUARDAR";
            btnGUARDAR.Size = new Size(94, 29);
            btnGUARDAR.TabIndex = 18;
            btnGUARDAR.Text = "GUARDAR";
            btnGUARDAR.UseVisualStyleBackColor = true;
            // 
            // TXTEXIXTENCIAS
            // 
            TXTEXIXTENCIAS.Location = new Point(239, 170);
            TXTEXIXTENCIAS.Name = "TXTEXIXTENCIAS";
            TXTEXIXTENCIAS.Size = new Size(295, 27);
            TXTEXIXTENCIAS.TabIndex = 15;
            // 
            // TXTAÑO
            // 
            TXTAÑO.Location = new Point(696, 80);
            TXTAÑO.Name = "TXTAÑO";
            TXTAÑO.Size = new Size(295, 27);
            TXTAÑO.TabIndex = 14;
            // 
            // TXTCATEGORIAS
            // 
            TXTCATEGORIAS.Location = new Point(239, 80);
            TXTCATEGORIAS.Name = "TXTCATEGORIAS";
            TXTCATEGORIAS.Size = new Size(295, 27);
            TXTCATEGORIAS.TabIndex = 13;
            // 
            // TXTTITULO
            // 
            TXTTITULO.Location = new Point(696, 15);
            TXTTITULO.Name = "TXTTITULO";
            TXTTITULO.Size = new Size(295, 27);
            TXTTITULO.TabIndex = 12;
            // 
            // LBLEXISTENCIAS
            // 
            LBLEXISTENCIAS.AutoSize = true;
            LBLEXISTENCIAS.BackColor = SystemColors.HighlightText;
            LBLEXISTENCIAS.Location = new Point(71, 177);
            LBLEXISTENCIAS.Name = "LBLEXISTENCIAS";
            LBLEXISTENCIAS.Size = new Size(91, 20);
            LBLEXISTENCIAS.TabIndex = 11;
            LBLEXISTENCIAS.Text = "EXITENCIAS:";
            // 
            // LBLaño
            // 
            LBLaño.AutoSize = true;
            LBLaño.BackColor = SystemColors.HighlightText;
            LBLaño.Location = new Point(623, 87);
            LBLaño.Name = "LBLaño";
            LBLaño.Size = new Size(44, 20);
            LBLaño.TabIndex = 10;
            LBLaño.Text = "AÑO:";
            // 
            // ISNBTXT
            // 
            ISNBTXT.Location = new Point(239, 15);
            ISNBTXT.Name = "ISNBTXT";
            ISNBTXT.Size = new Size(295, 27);
            ISNBTXT.TabIndex = 3;
            // 
            // LBLcategoria
            // 
            LBLcategoria.AutoSize = true;
            LBLcategoria.BackColor = SystemColors.HighlightText;
            LBLcategoria.Location = new Point(79, 87);
            LBLcategoria.Name = "LBLcategoria";
            LBLcategoria.Size = new Size(98, 20);
            LBLcategoria.TabIndex = 9;
            LBLcategoria.Text = "CATEGORIAS:";
            // 
            // Lbltitulos
            // 
            Lbltitulos.AutoSize = true;
            Lbltitulos.BackColor = SystemColors.HighlightText;
            Lbltitulos.Location = new Point(620, 22);
            Lbltitulos.Name = "Lbltitulos";
            Lbltitulos.Size = new Size(47, 20);
            Lbltitulos.TabIndex = 6;
            Lbltitulos.Text = "Titulo";
            // 
            // LBLIDENTIFICACION
            // 
            LBLIDENTIFICACION.AutoSize = true;
            LBLIDENTIFICACION.BackColor = SystemColors.HighlightText;
            LBLIDENTIFICACION.Location = new Point(118, 22);
            LBLIDENTIFICACION.Name = "LBLIDENTIFICACION";
            LBLIDENTIFICACION.Size = new Size(44, 20);
            LBLIDENTIFICACION.TabIndex = 5;
            LBLIDENTIFICACION.Text = "ISBN:";
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.BackColor = SystemColors.HighlightText;
            lblbuscar.Location = new Point(118, 19);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(41, 20);
            lblbuscar.TabIndex = 2;
            lblbuscar.Text = "ISBN";
            // 
            // BTNbuscar
            // 
            BTNbuscar.Location = new Point(573, 10);
            BTNbuscar.Name = "BTNbuscar";
            BTNbuscar.Size = new Size(94, 29);
            BTNbuscar.TabIndex = 4;
            BTNbuscar.Text = "BUSCAR";
            BTNbuscar.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            Titulo.BackColor = SystemColors.ActiveCaption;
            Titulo.Controls.Add(lbltitulo);
            Titulo.Location = new Point(1, 2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1035, 69);
            Titulo.TabIndex = 4;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ButtonFace;
            lbltitulo.Location = new Point(263, 20);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(197, 26);
            lbltitulo.TabIndex = 1;
            lbltitulo.Text = "Gestion de libros";
            // 
            // PNLbusqueda
            // 
            PNLbusqueda.BackColor = SystemColors.ActiveBorder;
            PNLbusqueda.Controls.Add(textBox1);
            PNLbusqueda.Controls.Add(BTNbuscar);
            PNLbusqueda.Controls.Add(lblbuscar);
            PNLbusqueda.Location = new Point(1, 69);
            PNLbusqueda.Name = "PNLbusqueda";
            PNLbusqueda.Size = new Size(1035, 63);
            PNLbusqueda.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 5;
            // 
            // Frmusuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 588);
            Controls.Add(dgvLibros);
            Controls.Add(pnldatos);
            Controls.Add(Titulo);
            Controls.Add(PNLbusqueda);
            Name = "Frmusuarios";
            Text = "Frmusuarios";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            pnldatos.ResumeLayout(false);
            pnldatos.PerformLayout();
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            PNLbusqueda.ResumeLayout(false);
            PNLbusqueda.PerformLayout();
            ResumeLayout(false);
        }

        private void txtIdentificacion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private ComboBox cmbEDITORIAL;
        private ComboBox cmbAUTOR;
        private TextBox TXTEXIXTENCIAS;

        private TextBox Apellidotxt;
        private Label txtTelefono;
        private Label LBLEXISTENCIAS;
        private Label LBLcategoria;
        private Label LBLEDITORIAL;
        private Label lblautor;
        private DataGridView dgvLibros;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Panel pnldatos;
        private Button btnGUARDAR;
        private TextBox TXTAÑO;
        private TextBox TXTCATEGORIAS;
        private TextBox TXTTITULO;
        private Label LBLaño;
        private TextBox ISNBTXT;
        private Label Lbltitulos;
        private Label LBLIDENTIFICACION;
        private Label lblbuscar;
        private Button BTNbuscar;
        private Panel Titulo;
        private Label lbltitulo;
        private Panel PNLbusqueda;
        private TextBox textBox1;
    }
}