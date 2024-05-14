using DD_TP3_ej1;
using System.Windows.Forms;

namespace TPherencia
{
    public partial class FPersonas : Form
    {
        #region Atributos
        private List<Persona> listPersonas;
        private int cantPersonas;
        #endregion

        public FPersonas()
        {
            InitializeComponent();
            listPersonas = new List<Persona>();
            cantPersonas = 0;
        }

        #region Funcionalidades
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool existePersona(Persona p)
        {
            return true;
        }

        private bool existeEstudiante(Estudiante e)
        {
            return true;
        }

        private bool deseaActualizar(Persona p)
        {
            return MessageBox.Show($"Se encontró:\n\n{p.mostrar()}\n\n¿Desea actualizarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void actualizarListBox()
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {

        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBox();
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region KeyPress
        private void tNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Validación de campos
        private void tNombre_Leave(object sender, EventArgs e)
        {
            if (tNombre.Text.Length <= 0)
                errorProvider.SetError(tNombre, "Nombre invalido");
            else errorProvider.SetError(tNombre, "");
        }

        private void mtDni_Leave(object sender, EventArgs e)
        {
            if (!mtDni.MaskCompleted)
                errorProvider.SetError(mtDni, "Documento invalido");
            else errorProvider.SetError(mtDni, "");
        }

        private void dtFechaNacimiento_Leave(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtFechaNacimiento.Value;
            DateTime fechaHoy = DateTime.Today;

            if (fechaNacimiento >= fechaHoy)
                errorProvider.SetError(dtFechaNacimiento, "Fecha invalida");
            else
                errorProvider.SetError(dtFechaNacimiento, "");
        }

        private void mtLegajo_Leave(object sender, EventArgs e)
        {
            if (!mtLegajo.MaskCompleted)
                errorProvider.SetError(mtLegajo, "Legajo invalido");
            else errorProvider.SetError(mtLegajo, "");
        }

        private void tCarrera_Leave(object sender, EventArgs e)
        {
            if (tCarrera.Text.Length <= 0)
                errorProvider.SetError(tCarrera, "Carrera invalida");
            else errorProvider.SetError(tCarrera, "");
        }
        #endregion            
    }
}