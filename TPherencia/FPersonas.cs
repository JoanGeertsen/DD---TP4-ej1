namespace TPherencia
{
    public partial class FPersonas : Form
    {
        public FPersonas()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) pEstudiante.Visible = true;
            else pEstudiante.Visible = false;
        }
    }
}