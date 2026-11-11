using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Acabiblioteca
{
    public partial class Frmlibros : Form
    {
        public Frmlibros()
        {
            InitializeComponent();
            CargarListas();
            CargarLibros();
        }

        private void LimpiarCampos()
        {
            ISNBTXT.Clear();
            TXTTITULO.Clear();
            TXTCATEGORIAS.Clear();
            TXTAÑO.Clear();
            TXTEXIXTENCIAS.Clear();

            cmbAUTOR.SelectedIndex = -1;
            cmbEDITORIAL.SelectedIndex = -1;

            ISNBTXT.Focus();
        }


        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];

            ISNBTXT.Text = fila.Cells["ISBN"].Value?.ToString();
            TXTTITULO.Text = fila.Cells["Titulo"].Value?.ToString();
            TXTCATEGORIAS.Text = fila.Cells["Categoria"].Value?.ToString();
            TXTAÑO.Text = fila.Cells["Anio"].Value?.ToString();
            TXTEXIXTENCIAS.Text = fila.Cells["Existencias"].Value?.ToString();

            // Seleccionar autor y editorial correspondientes
            // Se asignan por nombre porque la tabla muestra esos campos.
            cmbAUTOR.Text = fila.Cells["Autor"].Value?.ToString();
            cmbEDITORIAL.Text = fila.Cells["Editorial"].Value?.ToString();
        }



        private void CargarListas()
        {
            using (SqlConnection conexion = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
            {
                conexion.Open();

                SqlDataAdapter daAutores = new SqlDataAdapter(
                    "SELECT IdAutor, Nombre FROM Autores", conexion);

                DataTable autores = new DataTable();
                daAutores.Fill(autores);

                cmbAUTOR.DataSource = autores;
                cmbAUTOR.DisplayMember = "Nombre";
                cmbAUTOR.ValueMember = "IdAutor";

                SqlDataAdapter daEditoriales = new SqlDataAdapter(
                    "SELECT IdEditorial, Nombre FROM Editoriales", conexion);

                DataTable editoriales = new DataTable();
                daEditoriales.Fill(editoriales);

                cmbEDITORIAL.DataSource = editoriales;
                cmbEDITORIAL.DisplayMember = "Nombre";
                cmbEDITORIAL.ValueMember = "IdEditorial";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CargarLibros()
        {
            try
            {
                string consulta = @"
            SELECT
                L.ISBN,
                L.Titulo,
                A.Nombre AS Autor,
                E.Nombre AS Editorial,
                L.Categoria,
                L.Anio,
                L.Existencias
            FROM Libros L
            INNER JOIN Autores A ON L.IdAutor = A.IdAutor
            INNER JOIN Editoriales E ON L.IdEditorial = E.IdEditorial";

                using (SqlConnection conexion = new SqlConnection(
                    @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvLibros.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message);
            }
        }




        private void ISNBTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ISNBTXT.Text) ||
                    string.IsNullOrWhiteSpace(TXTTITULO.Text) ||
                    string.IsNullOrWhiteSpace(TXTCATEGORIAS.Text) ||
                    string.IsNullOrWhiteSpace(TXTAÑO.Text) ||
                    string.IsNullOrWhiteSpace(TXTEXIXTENCIAS.Text) ||
                    cmbAUTOR.SelectedValue == null ||
                    cmbEDITORIAL.SelectedValue == null)
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                if (!int.TryParse(TXTAÑO.Text, out int anio) ||
                    !int.TryParse(TXTEXIXTENCIAS.Text, out int existencias) ||
                    existencias < 0)
                {
                    MessageBox.Show("Verifique el año y las existencias.");
                    return;
                }

                using (SqlConnection conexion = new SqlConnection(
                    @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Libros
        (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias)
        VALUES
        (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Anio, @Existencias)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ISBN", ISNBTXT.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TXTTITULO.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", cmbAUTOR.SelectedValue);
                        comando.Parameters.AddWithValue("@IdEditorial", cmbEDITORIAL.SelectedValue);
                        comando.Parameters.AddWithValue("@Categoria", TXTCATEGORIAS.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Libro registrado correctamente.");

                CargarLibros();

                ISNBTXT.Clear();
                TXTTITULO.Clear();
                TXTCATEGORIAS.Clear();
                TXTAÑO.Clear();
                TXTEXIXTENCIAS.Clear();
                cmbAUTOR.SelectedIndex = -1;
                cmbEDITORIAL.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar el libro: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ISNBTXT.Text) ||
                    string.IsNullOrWhiteSpace(TXTTITULO.Text) ||
                    string.IsNullOrWhiteSpace(TXTCATEGORIAS.Text) ||
                    string.IsNullOrWhiteSpace(TXTAÑO.Text) ||
                    string.IsNullOrWhiteSpace(TXTEXIXTENCIAS.Text) ||
                    cmbAUTOR.SelectedValue == null ||
                    cmbEDITORIAL.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un libro y complete todos los campos.");
                    return;
                }

                if (!int.TryParse(TXTAÑO.Text, out int anio) ||
                    !int.TryParse(TXTEXIXTENCIAS.Text, out int existencias) ||
                    existencias < 0)
                {
                    MessageBox.Show("Verifique el año y las existencias.");
                    return;
                }

                using (SqlConnection conexion = new SqlConnection(
                    @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();

                    string consulta = @"
                UPDATE Libros
                SET Titulo = @Titulo,
                    IdAutor = @IdAutor,
                    IdEditorial = @IdEditorial,
                    Categoria = @Categoria,
                    Anio = @Anio,
                    Existencias = @Existencias
                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ISBN", ISNBTXT.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TXTTITULO.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", cmbAUTOR.SelectedValue);
                        comando.Parameters.AddWithValue("@IdEditorial", cmbEDITORIAL.SelectedValue);
                        comando.Parameters.AddWithValue("@Categoria", TXTCATEGORIAS.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                            MessageBox.Show("Libro actualizado correctamente.");
                        else
                            MessageBox.Show("No se encontró el libro para modificar.");
                    }
                }

                CargarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el libro: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ISNBTXT.Text))
                {
                    MessageBox.Show("Seleccione un libro de la tabla para eliminarlo.");
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este libro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion != DialogResult.Yes)
                    return;

                using (SqlConnection conexion = new SqlConnection(
                    @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();

                    // Verificar si el libro tiene préstamos asociados
                    string consultaPrestamos =
                        "SELECT COUNT(*) FROM dbo.Prestamos WHERE ISBN = @ISBN";

                    using (SqlCommand comandoVerificar =
                        new SqlCommand(consultaPrestamos, conexion))
                    {
                        comandoVerificar.Parameters.AddWithValue(
                            "@ISBN", ISNBTXT.Text.Trim());

                        int prestamos = (int)comandoVerificar.ExecuteScalar();

                        if (prestamos > 0)
                        {
                            MessageBox.Show(
                                "No se puede eliminar este libro porque tiene préstamos registrados.");
                            return;
                        }
                    }

                    // Eliminar el libro
                    string consultaEliminar =
                        "DELETE FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comandoEliminar =
                        new SqlCommand(consultaEliminar, conexion))
                    {
                        comandoEliminar.Parameters.AddWithValue(
                            "@ISBN", ISNBTXT.Text.Trim());

                        int filas = comandoEliminar.ExecuteNonQuery();

                        if (filas > 0)
                            MessageBox.Show("Libro eliminado correctamente.");
                        else
                            MessageBox.Show("No se encontró el libro.");
                    }
                }

                CargarLibros();

                ISNBTXT.Clear();
                TXTTITULO.Clear();
                TXTCATEGORIAS.Clear();
                TXTAÑO.Clear();
                TXTEXIXTENCIAS.Clear();
                cmbAUTOR.SelectedIndex = -1;
                cmbEDITORIAL.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No fue posible eliminar el libro: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BTNbuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Ingrese el ISBN que desea buscar.");
                    textBox1.Focus();
                    return;
                }

                string consulta = @"
        SELECT ISBN, Titulo, IdAutor, IdEditorial,
               Categoria, Anio, Existencias
        FROM dbo.Libros
        WHERE ISBN = @ISBN";

                using (SqlConnection conexion = new SqlConnection(
                    @"Server=(localdb)\MSSQLLocalDB;Database=AcaBiblioteca;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ISBN", textBox1.Text.Trim());

                        conexion.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                ISNBTXT.Text = lector["ISBN"].ToString();
                                TXTTITULO.Text = lector["Titulo"].ToString();
                                cmbAUTOR.SelectedValue = lector["IdAutor"];
                                cmbEDITORIAL.SelectedValue = lector["IdEditorial"];
                                TXTCATEGORIAS.Text = lector["Categoria"].ToString();
                                TXTAÑO.Text = lector["Anio"].ToString();
                                TXTEXIXTENCIAS.Text = lector["Existencias"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún libro con ese ISBN.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el libro: " + ex.Message);
            }

        }
    }
}

