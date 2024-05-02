using DD_TP3_ej1;

namespace TPherencia
{
    public partial class FPersonas : Form
    {
        #region Atributos
        private Persona[] aPersonas;
        private Estudiante[] aEstudiantes;
        private int max;
        #endregion

        public FPersonas()
        {
            InitializeComponent();
            max = 50;
            aPersonas = new Persona[max];
            aEstudiantes = new Estudiante[max];
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstudiante.Checked) pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //if (chEstudiante.Checked && validarCamposEstudiante())
                //Agrego el estudiante
            //else if (!chEstudiante.Checked && validarCamposPersona())
                //Agrego la persona
        }
    }
}