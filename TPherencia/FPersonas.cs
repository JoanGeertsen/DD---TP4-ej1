using DD_TP3_ej1;
using DD_TP4_ej1;
using System;
using System.Net;
using System.Windows.Forms;

namespace TPherencia
{
    public partial class FPersonas : Form
    {
        #region Atributos
        private List<Persona> listPersonas;
        #endregion

        public FPersonas()
        {
            InitializeComponent();
            listPersonas = new List<Persona>();
        }

        #region Funcionalidades

        private void rbPersona_CheckedChanged(object sender, EventArgs e)
        {
            pEstudiante.Visible = false; pEmpleado.Visible = false;
        }

        private void rbEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            pEstudiante.Visible = true; pEmpleado.Visible = false;
        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            pEstudiante.Visible = false; pEmpleado.Visible = true;
        }
        private bool deseaActualizar(Persona p)
        {
            return MessageBox.Show($"Se encontró:\n\n{p.ToString()}\n\n¿Desea actualizarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void actualizarListBox()
        {
            lbPersonas.Items.Clear();
            int selectedIndex = cbFiltros.SelectedIndex;

            listPersonas.Sort();

            foreach (Persona p in listPersonas)
            {
                if ((selectedIndex == 1 && p is Estudiante) ||
                    (selectedIndex == 2 && p is Empleado) ||
                    (selectedIndex != 1 && selectedIndex != 2 && p is Persona))
                {
                    lbPersonas.Items.Add(p.ToString());
                }
            }

            lCantidad.Text = $"Cantidad: {lbPersonas.Items.Count}";
        }

        private void chequearCarrera()
        {
            if (!cbCarrera.Items.Contains(cbCarrera.Text))
                cbCarrera.Items.Add(cbCarrera.Text);
        }

        private void limpiarCampos()
        {
            tNombre.Clear(); mtDni.Clear(); dtFechaNacimiento.Text="01/01/2000";
            mtLegajo.Clear(); cbCarrera.Text = "";
            mtLegajoEmpleado.Clear(); tCargo.Clear();
        }

        private bool existePersona(Persona persona, out int pos)
        {
            pos = -1; int i = 0;
            bool existe = false;
            while(i < listPersonas.Count && !existe)
            {
                if (listPersonas[i].Dni == persona.Dni)
                {
                    pos = i;
                    existe = true;
                }
                i++;
            }            
            return existe;
        }

        private void ActualizarOInsertarPersona(Persona persona)
        {
            int i;
            if (!existePersona(persona, out i))
            {
                listPersonas.Add(persona);
                MessageBox.Show(persona.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (deseaActualizar(listPersonas[i]))
            {
                listPersonas[i] = persona;
                MessageBox.Show(persona.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                 
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = null;

            if (!mtDni.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar un DNI VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtDni.Focus(); errorProvider.Clear(); errorProvider.SetError(mtDni, "DNI invalido");                
            }          

            else if (rbPersona.Checked)            
                persona = new Persona(mtDni.Text, tNombre.Text, dtFechaNacimiento.Text);
            
            else if (rbEstudiante.Checked)
            {
                if (!mtLegajo.MaskCompleted)
                {
                    MessageBox.Show("Debe ingresar un legajo VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtLegajo.Focus(); errorProvider.Clear(); errorProvider.SetError(mtLegajo, "Legajo inválido");                    
                }
                else persona = new Estudiante(mtDni.Text, tNombre.Text, dtFechaNacimiento.Text, mtLegajo.Text, cbCarrera.Text);
            }
            else if (rbEmpleado.Checked)
            {
                if (!mtLegajoEmpleado.MaskCompleted)
                {
                    MessageBox.Show("Debe ingresar un legajo VALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtLegajoEmpleado.Focus(); errorProvider.Clear(); errorProvider.SetError(mtLegajoEmpleado, "Legajo inválido");                    
                }
                else persona = new Empleado(mtDni.Text, tNombre.Text, dtFechaNacimiento.Text, mtLegajoEmpleado.Text, tCargo.Text);
            }

            ActualizarOInsertarPersona(persona);
            actualizarListBox(); limpiarCampos();
        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListBox();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            int i = 0; errorProvider.Clear(); 
            if (!mtDni.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.Clear(); errorProvider.SetError(mtDni, "DNI invalido"); mtDni.Focus();
            }
            else if (existePersona(new Persona(mtDni.Text), out i))
            { 
                Persona pe = listPersonas[i];
                tNombre.Text = pe.Nombre; dtFechaNacimiento.Text = pe.FechaNacimiento; rbPersona.Checked = true;
                if (pe.GetType() == typeof(Estudiante))
                {
                    Estudiante es = (Estudiante) pe; rbEstudiante.Checked = true;
                    mtLegajo.Text = es.Legajo; cbCarrera.Text = es.Carrera;
                }
                else if (pe.GetType() == typeof(Empleado))
                {
                    Empleado em = (Empleado) pe; rbEmpleado.Checked = true;
                    mtLegajoEmpleado.Text = em.Legajo; tCargo.Text = em.Cargo;
                }
            }

            else
                MessageBox.Show($"No se encontraron resultados", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void cbCarrera_KeyPress(object sender, KeyPressEventArgs e)
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
            if (tNombre.Text.Trim() == "")
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
        private void cbCarrera_Leave(object sender, EventArgs e)
        {
            if (cbCarrera.Text.Trim() == "")
                errorProvider.SetError(mtLegajo, "Carrera invalida");
            else errorProvider.SetError(cbCarrera, "");
        }
        private void mtLegajoEmpleado_Leave(object sender, EventArgs e)
        {
            if (mtLegajoEmpleado.Text.Trim() == "")
                errorProvider.SetError(mtLegajoEmpleado, "Legajo invalido");
            else errorProvider.SetError(mtLegajoEmpleado, "");
        }
        #endregion


        private void tCargo_Leave(object sender, EventArgs e)
        {
            if (tCargo.Text.Trim() == "")
                errorProvider.SetError(tCargo, "Cargo invalido");
            else errorProvider.SetError(tCargo, "");
        }
    }
}