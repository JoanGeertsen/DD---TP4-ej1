using DD_TP3_ej1;
using System.Windows.Forms;

namespace TPherencia
{
    public partial class FPersonas : Form
    {
        #region Atributos
        private Persona[] aPersonas;
        private Estudiante[] aEstudiantes;
        private int max;
        private int cantPersonas;
        private int cantEstudiantes;
        #endregion

        public FPersonas()
        {
            InitializeComponent();
            max = 50;
            aPersonas = new Persona[max];
            cantPersonas = 0;
            aEstudiantes = new Estudiante[max];
            cantEstudiantes = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstudiante.Checked)
            {
                pEstudiante.Visible = true;
                mtLegajo.Focus();
            }
            else pEstudiante.Visible = false;
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {   //Voy a guardar un estudiante
            if (!chEstudiante.Checked && errorProvider.GetError(tNombre) == "" && errorProvider.GetError(tApellido) == "" && errorProvider.GetError(mtDni) == ""
                && errorProvider.GetError(dtFechaIngreso) == "")
            {
                MessageBox.Show("Guardando persona"); //Añadir codigo de guardado
            }
            else if(chEstudiante.Checked && errorProvider.GetError(tNombre) == "" && errorProvider.GetError(tApellido) == "" && errorProvider.GetError(mtDni) == ""
                && errorProvider.GetError(dtFechaIngreso) == "" && errorProvider.GetError(mtLegajo) == "" && errorProvider.GetError(tCarrera) == "" && errorProvider.GetError(dtFechaIngreso) == "")
            {
                MessageBox.Show("Guardando estudiante"); //Añadir codigo de guardado
            }
        }


        #region KeyPress
        private void tNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void tApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider.SetError(tNombre, "Debe ingresar un nombre");
            else errorProvider.SetError(tNombre, "");
        }

        private void tApellido_Leave(object sender, EventArgs e)
        {
            if (tApellido.Text.Length <= 0)
                errorProvider.SetError(tApellido, "Debe ingresar un apellido");
            else errorProvider.SetError(tApellido, "");
        }

        private void mtDni_Leave(object sender, EventArgs e)
        {
            if (!mtDni.MaskCompleted)
                errorProvider.SetError(mtDni, "Debe ingresar un documento VALIDO");
            else errorProvider.SetError(mtDni, "");
        }

        private void dtFechaNacimiento_Leave(object sender, EventArgs e)
        {
            //Tomamos como politica que tiene que tener al menos 6 años
            DateTime fechaNacimiento = dtFechaNacimiento.Value;
            DateTime fechaHoy = DateTime.Today;

            int edad = fechaHoy.Year - fechaNacimiento.Year;

            if (fechaHoy < fechaNacimiento.AddYears(edad))
                edad--;

            if (edad < 5)
                errorProvider.SetError(dtFechaNacimiento, "Solo se admiten estudiantes mayores a 5 años");
            else
                errorProvider.SetError(dtFechaNacimiento, "");
        }

        private void mtLegajo_Leave(object sender, EventArgs e)
        {
            if (!mtLegajo.MaskCompleted)
                errorProvider.SetError(mtLegajo, "Debe ingresar un legajo VALIDO");
            else errorProvider.SetError(mtLegajo, "");
        }

        private void tCarrera_Leave(object sender, EventArgs e)
        {
            if (tCarrera.Text.Length <= 0)
                errorProvider.SetError(tCarrera, "Debe ingresar una carrera");
            else errorProvider.SetError(tCarrera, "");
        }

        private void dtFechaIngreso_Leave(object sender, EventArgs e)
        {
            //Por el momento solo chequeamos que no sea una fecha futura
            DateTime fechaDeIngreso = dtFechaIngreso.Value;
            DateTime fechaHoy = DateTime.Today;


            if (fechaDeIngreso > fechaHoy)
                errorProvider.SetError(dtFechaIngreso, "Debe ingresar una fecha VALIDA");
            else
                errorProvider.SetError(dtFechaIngreso, "");
        }       
    }

    #endregion
}