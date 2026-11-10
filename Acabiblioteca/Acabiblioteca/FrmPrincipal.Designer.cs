namespace Acabiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PNLMenu = new Panel();
            btnsalida = new FontAwesome.Sharp.IconButton();
            btnreportes = new FontAwesome.Sharp.IconButton();
            btnprestamos = new FontAwesome.Sharp.IconButton();
            btneditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnusuarios = new FontAwesome.Sharp.IconButton();
            btnlibros = new FontAwesome.Sharp.IconButton();
            BTNinicio = new FontAwesome.Sharp.IconButton();
            PNLlogo = new Panel();
            logo = new PictureBox();
            LBLsubtitulo = new Label();
            LBLtitulo = new Label();
            PNLsuperior = new Panel();
            PNLEstado = new Panel();
            PNLcontenido = new Panel();
            PNLMenu.SuspendLayout();
            PNLlogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // PNLMenu
            // 
            PNLMenu.BackColor = Color.CornflowerBlue;
            PNLMenu.Controls.Add(btnsalida);
            PNLMenu.Controls.Add(btnreportes);
            PNLMenu.Controls.Add(btnprestamos);
            PNLMenu.Controls.Add(btneditoriales);
            PNLMenu.Controls.Add(btnAutores);
            PNLMenu.Controls.Add(btnusuarios);
            PNLMenu.Controls.Add(btnlibros);
            PNLMenu.Controls.Add(BTNinicio);
            PNLMenu.Controls.Add(PNLlogo);
            PNLMenu.Dock = DockStyle.Left;
            PNLMenu.Location = new Point(0, 0);
            PNLMenu.Margin = new Padding(3, 4, 3, 4);
            PNLMenu.Name = "PNLMenu";
            PNLMenu.Size = new Size(427, 881);
            PNLMenu.TabIndex = 0;
            // 
            // btnsalida
            // 
            btnsalida.AutoSize = true;
            btnsalida.Dock = DockStyle.Top;
            btnsalida.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalida.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnsalida.IconColor = Color.Black;
            btnsalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalida.IconSize = 20;
            btnsalida.Location = new Point(0, 527);
            btnsalida.Margin = new Padding(0, 13, 0, 13);
            btnsalida.Name = "btnsalida";
            btnsalida.Size = new Size(427, 60);
            btnsalida.TabIndex = 8;
            btnsalida.Text = "Salir";
            btnsalida.TextAlign = ContentAlignment.MiddleRight;
            btnsalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsalida.UseVisualStyleBackColor = true;
            btnsalida.Click += btnsalida_Click;
            // 
            // btnreportes
            // 
            btnreportes.AutoSize = true;
            btnreportes.Dock = DockStyle.Top;
            btnreportes.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreportes.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnreportes.IconColor = Color.Black;
            btnreportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnreportes.IconSize = 20;
            btnreportes.Location = new Point(0, 467);
            btnreportes.Margin = new Padding(0, 13, 0, 13);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(427, 60);
            btnreportes.TabIndex = 7;
            btnreportes.Text = "Reportes";
            btnreportes.TextAlign = ContentAlignment.MiddleRight;
            btnreportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreportes.UseVisualStyleBackColor = true;
            btnreportes.Click += btnreportes_Click;
            // 
            // btnprestamos
            // 
            btnprestamos.AutoSize = true;
            btnprestamos.Dock = DockStyle.Top;
            btnprestamos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprestamos.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btnprestamos.IconColor = Color.Black;
            btnprestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnprestamos.IconSize = 20;
            btnprestamos.Location = new Point(0, 407);
            btnprestamos.Margin = new Padding(0, 13, 0, 13);
            btnprestamos.Name = "btnprestamos";
            btnprestamos.Size = new Size(427, 60);
            btnprestamos.TabIndex = 6;
            btnprestamos.Text = "Prestamos";
            btnprestamos.TextAlign = ContentAlignment.MiddleRight;
            btnprestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnprestamos.UseVisualStyleBackColor = true;
            btnprestamos.Click += btnprestamos_Click;
            // 
            // btneditoriales
            // 
            btneditoriales.AutoSize = true;
            btneditoriales.Dock = DockStyle.Top;
            btneditoriales.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditoriales.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btneditoriales.IconColor = Color.Black;
            btneditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditoriales.IconSize = 20;
            btneditoriales.Location = new Point(0, 347);
            btneditoriales.Margin = new Padding(0, 13, 0, 13);
            btneditoriales.Name = "btneditoriales";
            btneditoriales.Size = new Size(427, 60);
            btneditoriales.TabIndex = 5;
            btneditoriales.Text = "Editoriales";
            btneditoriales.TextAlign = ContentAlignment.MiddleRight;
            btneditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditoriales.UseVisualStyleBackColor = true;
            btneditoriales.Click += btneditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 20;
            btnAutores.Location = new Point(0, 287);
            btnAutores.Margin = new Padding(0, 13, 0, 13);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(427, 60);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleRight;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnusuarios
            // 
            btnusuarios.AutoSize = true;
            btnusuarios.Dock = DockStyle.Top;
            btnusuarios.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnusuarios.IconChar = FontAwesome.Sharp.IconChar.PersonBooth;
            btnusuarios.IconColor = Color.Black;
            btnusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnusuarios.IconSize = 20;
            btnusuarios.Location = new Point(0, 227);
            btnusuarios.Margin = new Padding(0, 13, 0, 13);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(427, 60);
            btnusuarios.TabIndex = 3;
            btnusuarios.Text = "Usuarios";
            btnusuarios.TextAlign = ContentAlignment.MiddleRight;
            btnusuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnusuarios.UseVisualStyleBackColor = true;
            btnusuarios.Click += btnusuarios_Click;
            // 
            // btnlibros
            // 
            btnlibros.AutoSize = true;
            btnlibros.Dock = DockStyle.Top;
            btnlibros.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnlibros.IconColor = Color.Black;
            btnlibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlibros.IconSize = 20;
            btnlibros.Location = new Point(0, 167);
            btnlibros.Margin = new Padding(0, 13, 0, 13);
            btnlibros.Name = "btnlibros";
            btnlibros.Size = new Size(427, 60);
            btnlibros.TabIndex = 2;
            btnlibros.Text = "libros";
            btnlibros.TextAlign = ContentAlignment.MiddleRight;
            btnlibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlibros.UseVisualStyleBackColor = true;
            btnlibros.Click += btnlibros_Click;
            // 
            // BTNinicio
            // 
            BTNinicio.AutoSize = true;
            BTNinicio.Dock = DockStyle.Top;
            BTNinicio.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNinicio.IconChar = FontAwesome.Sharp.IconChar.House;
            BTNinicio.IconColor = Color.Black;
            BTNinicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNinicio.IconSize = 20;
            BTNinicio.Location = new Point(0, 107);
            BTNinicio.Margin = new Padding(0, 13, 0, 13);
            BTNinicio.Name = "BTNinicio";
            BTNinicio.Size = new Size(427, 60);
            BTNinicio.TabIndex = 1;
            BTNinicio.Text = "Inicio";
            BTNinicio.TextAlign = ContentAlignment.MiddleRight;
            BTNinicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNinicio.UseVisualStyleBackColor = true;
            BTNinicio.Click += BTNinicio_Click;
            // 
            // PNLlogo
            // 
            PNLlogo.BackColor = Color.LightSkyBlue;
            PNLlogo.Controls.Add(logo);
            PNLlogo.Controls.Add(LBLsubtitulo);
            PNLlogo.Controls.Add(LBLtitulo);
            PNLlogo.Dock = DockStyle.Top;
            PNLlogo.Location = new Point(0, 0);
            PNLlogo.Margin = new Padding(3, 4, 3, 4);
            PNLlogo.Name = "PNLlogo";
            PNLlogo.Size = new Size(427, 107);
            PNLlogo.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.SteelBlue;
            logo.ErrorImage = null;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(0, 0);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(194, 107);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // LBLsubtitulo
            // 
            LBLsubtitulo.AutoSize = true;
            LBLsubtitulo.BackColor = Color.Transparent;
            LBLsubtitulo.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLsubtitulo.ForeColor = SystemColors.Control;
            LBLsubtitulo.Location = new Point(213, 63);
            LBLsubtitulo.Margin = new Padding(3, 4, 3, 4);
            LBLsubtitulo.Name = "LBLsubtitulo";
            LBLsubtitulo.Size = new Size(226, 23);
            LBLsubtitulo.TabIndex = 1;
            LBLsubtitulo.Text = "Sistema De Gestion";
            // 
            // LBLtitulo
            // 
            LBLtitulo.AutoSize = true;
            LBLtitulo.BackColor = Color.Transparent;
            LBLtitulo.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLtitulo.ForeColor = SystemColors.Control;
            LBLtitulo.Location = new Point(235, 12);
            LBLtitulo.Margin = new Padding(0, 13, 0, 13);
            LBLtitulo.Name = "LBLtitulo";
            LBLtitulo.Size = new Size(174, 31);
            LBLtitulo.TabIndex = 0;
            LBLtitulo.Text = "biblioteca";
            // 
            // PNLsuperior
            // 
            PNLsuperior.BackColor = SystemColors.WindowFrame;
            PNLsuperior.Dock = DockStyle.Top;
            PNLsuperior.Location = new Point(427, 0);
            PNLsuperior.Margin = new Padding(3, 4, 3, 4);
            PNLsuperior.Name = "PNLsuperior";
            PNLsuperior.Size = new Size(1132, 107);
            PNLsuperior.TabIndex = 1;
            // 
            // PNLEstado
            // 
            PNLEstado.BackColor = SystemColors.ControlDarkDark;
            PNLEstado.Dock = DockStyle.Bottom;
            PNLEstado.Location = new Point(427, 821);
            PNLEstado.Margin = new Padding(3, 4, 3, 4);
            PNLEstado.Name = "PNLEstado";
            PNLEstado.Size = new Size(1132, 60);
            PNLEstado.TabIndex = 2;
            // 
            // PNLcontenido
            // 
            PNLcontenido.Dock = DockStyle.Fill;
            PNLcontenido.Location = new Point(427, 107);
            PNLcontenido.Margin = new Padding(3, 4, 3, 4);
            PNLcontenido.Name = "PNLcontenido";
            PNLcontenido.Size = new Size(1132, 714);
            PNLcontenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 881);
            Controls.Add(PNLcontenido);
            Controls.Add(PNLEstado);
            Controls.Add(PNLsuperior);
            Controls.Add(PNLMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ssitema de gestion de bibilioteca";
            WindowState = FormWindowState.Maximized;
            PNLMenu.ResumeLayout(false);
            PNLMenu.PerformLayout();
            PNLlogo.ResumeLayout(false);
            PNLlogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLMenu;
        private Panel PNLsuperior;
        private Panel PNLEstado;
        private Panel PNLcontenido;
        private Panel PNLlogo;
        private Label LBLtitulo;
        private Label LBLsubtitulo;
        private PictureBox logo;
        private FontAwesome.Sharp.IconButton BTNinicio;
        private FontAwesome.Sharp.IconButton btnusuarios;
        private FontAwesome.Sharp.IconButton btnlibros;
        private FontAwesome.Sharp.IconButton btnprestamos;
        private FontAwesome.Sharp.IconButton btneditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnsalida;
        private FontAwesome.Sharp.IconButton btnreportes;
    }
}
