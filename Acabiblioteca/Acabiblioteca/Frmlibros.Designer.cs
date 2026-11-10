namespace Acabiblioteca
{
    partial class Frmlibros
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
            Titulo = new Panel();
            lbltitulo = new Label();
            PNLbusqueda = new Panel();
            textBox1 = new TextBox();
            BTNbuscar = new Button();
            lblbuscar = new Label();
            ISNBTXT = new TextBox();
            pnldatos = new Panel();
            cmbEDITORIAL = new ComboBox();
            cmbAUTOR = new ComboBox();
            TXTEXIXTENCIAS = new TextBox();
            TXTAÑO = new TextBox();
            TXTCATEGORIAS = new TextBox();
            TXTTITULO = new TextBox();
            LBLEXISTENCIAS = new Label();
            LBLaño = new Label();
            LBLcategoria = new Label();
            LBLEDITORIAL = new Label();
            lblautor = new Label();
            Lbltitulos = new Label();
            txtisbn = new Label();
            Titulo.SuspendLayout();
            PNLbusqueda.SuspendLayout();
            pnldatos.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.BackColor = SystemColors.ActiveCaption;
            Titulo.Controls.Add(lbltitulo);
            Titulo.Dock = DockStyle.Top;
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1071, 60);
            Titulo.TabIndex = 0;
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
            PNLbusqueda.Dock = DockStyle.Top;
            PNLbusqueda.Location = new Point(0, 60);
            PNLbusqueda.Name = "PNLbusqueda";
            PNLbusqueda.Size = new Size(1071, 55);
            PNLbusqueda.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 5;
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
            // ISNBTXT
            // 
            ISNBTXT.Location = new Point(239, 15);
            ISNBTXT.Name = "ISNBTXT";
            ISNBTXT.Size = new Size(295, 27);
            ISNBTXT.TabIndex = 3;
            ISNBTXT.Text = "i";
            // 
            // pnldatos
            // 
            pnldatos.Controls.Add(cmbEDITORIAL);
            pnldatos.Controls.Add(cmbAUTOR);
            pnldatos.Controls.Add(TXTEXIXTENCIAS);
            pnldatos.Controls.Add(TXTAÑO);
            pnldatos.Controls.Add(TXTCATEGORIAS);
            pnldatos.Controls.Add(TXTTITULO);
            pnldatos.Controls.Add(LBLEXISTENCIAS);
            pnldatos.Controls.Add(LBLaño);
            pnldatos.Controls.Add(ISNBTXT);
            pnldatos.Controls.Add(LBLcategoria);
            pnldatos.Controls.Add(LBLEDITORIAL);
            pnldatos.Controls.Add(lblautor);
            pnldatos.Controls.Add(Lbltitulos);
            pnldatos.Controls.Add(txtisbn);
            pnldatos.Dock = DockStyle.Top;
            pnldatos.Location = new Point(0, 115);
            pnldatos.Name = "pnldatos";
            pnldatos.Size = new Size(1071, 330);
            pnldatos.TabIndex = 2;
            // 
            // cmbEDITORIAL
            // 
            cmbEDITORIAL.FormattingEnabled = true;
            cmbEDITORIAL.Location = new Point(239, 155);
            cmbEDITORIAL.Name = "cmbEDITORIAL";
            cmbEDITORIAL.Size = new Size(295, 28);
            cmbEDITORIAL.TabIndex = 17;
            // 
            // cmbAUTOR
            // 
            cmbAUTOR.FormattingEnabled = true;
            cmbAUTOR.Location = new Point(239, 107);
            cmbAUTOR.Name = "cmbAUTOR";
            cmbAUTOR.Size = new Size(295, 28);
            cmbAUTOR.TabIndex = 16;
            // 
            // TXTEXIXTENCIAS
            // 
            TXTEXIXTENCIAS.Location = new Point(239, 290);
            TXTEXIXTENCIAS.Name = "TXTEXIXTENCIAS";
            TXTEXIXTENCIAS.Size = new Size(295, 27);
            TXTEXIXTENCIAS.TabIndex = 15;
            // 
            // TXTAÑO
            // 
            TXTAÑO.Location = new Point(239, 243);
            TXTAÑO.Name = "TXTAÑO";
            TXTAÑO.Size = new Size(295, 27);
            TXTAÑO.TabIndex = 14;
            // 
            // TXTCATEGORIAS
            // 
            TXTCATEGORIAS.Location = new Point(239, 197);
            TXTCATEGORIAS.Name = "TXTCATEGORIAS";
            TXTCATEGORIAS.Size = new Size(295, 27);
            TXTCATEGORIAS.TabIndex = 13;
            // 
            // TXTTITULO
            // 
            TXTTITULO.Location = new Point(239, 61);
            TXTTITULO.Name = "TXTTITULO";
            TXTTITULO.Size = new Size(295, 27);
            TXTTITULO.TabIndex = 12;
            // 
            // LBLEXISTENCIAS
            // 
            LBLEXISTENCIAS.AutoSize = true;
            LBLEXISTENCIAS.BackColor = SystemColors.HighlightText;
            LBLEXISTENCIAS.Location = new Point(68, 297);
            LBLEXISTENCIAS.Name = "LBLEXISTENCIAS";
            LBLEXISTENCIAS.Size = new Size(91, 20);
            LBLEXISTENCIAS.TabIndex = 11;
            LBLEXISTENCIAS.Text = "EXITENCIAS:";
            // 
            // LBLaño
            // 
            LBLaño.AutoSize = true;
            LBLaño.BackColor = SystemColors.HighlightText;
            LBLaño.Location = new Point(112, 250);
            LBLaño.Name = "LBLaño";
            LBLaño.Size = new Size(44, 20);
            LBLaño.TabIndex = 10;
            LBLaño.Text = "AÑO:";
            // 
            // LBLcategoria
            // 
            LBLcategoria.AutoSize = true;
            LBLcategoria.BackColor = SystemColors.HighlightText;
            LBLcategoria.Location = new Point(61, 204);
            LBLcategoria.Name = "LBLcategoria";
            LBLcategoria.Size = new Size(98, 20);
            LBLcategoria.TabIndex = 9;
            LBLcategoria.Text = "CATEGORIAS:";
            // 
            // LBLEDITORIAL
            // 
            LBLEDITORIAL.AutoSize = true;
            LBLEDITORIAL.BackColor = SystemColors.HighlightText;
            LBLEDITORIAL.Location = new Point(79, 163);
            LBLEDITORIAL.Name = "LBLEDITORIAL";
            LBLEDITORIAL.Size = new Size(80, 20);
            LBLEDITORIAL.TabIndex = 8;
            LBLEDITORIAL.Text = "EDITORIAL";
            // 
            // lblautor
            // 
            lblautor.AutoSize = true;
            lblautor.BackColor = SystemColors.HighlightText;
            lblautor.Location = new Point(100, 115);
            lblautor.Name = "lblautor";
            lblautor.Size = new Size(56, 20);
            lblautor.TabIndex = 7;
            lblautor.Text = "AUTOR";
            // 
            // Lbltitulos
            // 
            Lbltitulos.AutoSize = true;
            Lbltitulos.BackColor = SystemColors.HighlightText;
            Lbltitulos.Location = new Point(112, 68);
            Lbltitulos.Name = "Lbltitulos";
            Lbltitulos.Size = new Size(47, 20);
            Lbltitulos.TabIndex = 6;
            Lbltitulos.Text = "Titulo";
            // 
            // txtisbn
            // 
            txtisbn.AutoSize = true;
            txtisbn.BackColor = SystemColors.HighlightText;
            txtisbn.Location = new Point(118, 22);
            txtisbn.Name = "txtisbn";
            txtisbn.Size = new Size(44, 20);
            txtisbn.TabIndex = 5;
            txtisbn.Text = "ISBN:";
            // 
            // Frmlibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 520);
            Controls.Add(pnldatos);
            Controls.Add(PNLbusqueda);
            Controls.Add(Titulo);
            Name = "Frmlibros";
            Text = "Frmlibros";
            Titulo.ResumeLayout(false);
            Titulo.PerformLayout();
            PNLbusqueda.ResumeLayout(false);
            PNLbusqueda.PerformLayout();
            pnldatos.ResumeLayout(false);
            pnldatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Titulo;
        private Label lbltitulo;
        private Panel PNLbusqueda;
        private Button BTNbuscar;
        private TextBox ISNBTXT;
        private Label lblbuscar;
        private Panel pnldatos;
        private Label txtisbn;
        private Label Lbltitulos;
        private Label LBLEXISTENCIAS;
        private Label LBLaño;
        private Label LBLcategoria;
        private Label LBLEDITORIAL;
        private Label lblautor;
        private TextBox textBox1;
        private ComboBox cmbAUTOR;
        private TextBox TXTEXIXTENCIAS;
        private TextBox TXTAÑO;
        private TextBox TXTCATEGORIAS;
        private TextBox TXTTITULO;
        private ComboBox cmbEDITORIAL;
    }
}