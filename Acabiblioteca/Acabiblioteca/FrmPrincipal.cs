namespace Acabiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            AbrirFormulario(new Frminicio());

        }

        private void AbrirFormulario(Form formulario)
        {

            PNLcontenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PNLcontenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void BTNinicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frminicio());

        }

        private void btnlibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmlibros());

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmusuarios());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmautores());
        }

        private void btneditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FEditoriales());
        }

        private void btnprestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
