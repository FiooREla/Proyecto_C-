using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacione
{
    public partial class frmCategoria : Form
    {
        private string idCategoria;
        public bool Editarse = false;
        E_Categoria objEntidad= new E_Categoria();
        N_Categoria objCategoria = new N_Categoria();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Categoria objNegocio = new N_Categoria();
            dataGridView1.DataSource = objNegocio.ListandoCategoria(buscar);
        }
        public void accionesTabla()
        {
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[1].Width = 55;
            dataGridView1.Columns[2].Width = 120;

            dataGridView1.ClearSelection();
        }
        private void CATEGORIA_Click(object sender, EventArgs e)
        {

        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void limpiarCajas()
        {
            Editarse = false;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Editarse = true;
                idCategoria = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Haz click en algùn campo mierda, donde ser pacientes es un placer ... xd");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Editarse == false)
            {
                try
                {
                    objEntidad.Nombrecategoria1 = txtNombre.Text.ToUpper();
                    objEntidad.Descripcioncategoria = txtDescripcion.Text.ToUpper();

                    objCategoria.InsertandoCategoria(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    

                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if(Editarse == true)
            {
                try
                {
                    objEntidad.Idcategoria = Convert.ToInt32(idCategoria);
                    objEntidad.Nombrecategoria1 = txtNombre.Text.ToUpper();
                    objEntidad.Descripcioncategoria = txtDescripcion.Text.ToUpper();

                    objCategoria.EditandoCategoria(objEntidad);

                    MessageBox.Show("Se editó el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    Editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEntidad.Idcategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                objCategoria.EliminarCategoria(objEntidad);

                MessageBox.Show("Se eliminó el registro");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
                
        }
    }
}
