namespace TPherencia
{
    partial class FPersonas
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
            components = new System.ComponentModel.Container();
            pPersona = new Panel();
            rbEmpleado = new RadioButton();
            rbEstudiante = new RadioButton();
            rbPersona = new RadioButton();
            dtFechaNacimiento = new DateTimePicker();
            mtDni = new MaskedTextBox();
            tNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pLista = new Panel();
            lCantidad = new Label();
            lbPersonas = new ListBox();
            cbFiltros = new ComboBox();
            pEstudiante = new Panel();
            tCarrera = new TextBox();
            label7 = new Label();
            mtLegajo = new MaskedTextBox();
            label6 = new Label();
            bMostrar = new Button();
            bGuardar = new Button();
            bCerrar = new Button();
            errorProvider = new ErrorProvider(components);
            pPersona.SuspendLayout();
            pLista.SuspendLayout();
            pEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pPersona
            // 
            pPersona.BackColor = Color.PaleTurquoise;
            pPersona.Controls.Add(rbEmpleado);
            pPersona.Controls.Add(rbEstudiante);
            pPersona.Controls.Add(rbPersona);
            pPersona.Controls.Add(dtFechaNacimiento);
            pPersona.Controls.Add(mtDni);
            pPersona.Controls.Add(tNombre);
            pPersona.Controls.Add(label4);
            pPersona.Controls.Add(label3);
            pPersona.Controls.Add(label1);
            pPersona.Location = new Point(12, 12);
            pPersona.Name = "pPersona";
            pPersona.Size = new Size(307, 136);
            pPersona.TabIndex = 0;
            // 
            // rbEmpleado
            // 
            rbEmpleado.AutoSize = true;
            rbEmpleado.Location = new Point(209, 108);
            rbEmpleado.Name = "rbEmpleado";
            rbEmpleado.Size = new Size(78, 19);
            rbEmpleado.TabIndex = 11;
            rbEmpleado.Text = "Empleado";
            rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // rbEstudiante
            // 
            rbEstudiante.AutoSize = true;
            rbEstudiante.Checked = true;
            rbEstudiante.Location = new Point(112, 108);
            rbEstudiante.Name = "rbEstudiante";
            rbEstudiante.Size = new Size(80, 19);
            rbEstudiante.TabIndex = 10;
            rbEstudiante.TabStop = true;
            rbEstudiante.Text = "Estudiante";
            rbEstudiante.UseVisualStyleBackColor = true;
            // 
            // rbPersona
            // 
            rbPersona.AutoSize = true;
            rbPersona.Location = new Point(13, 108);
            rbPersona.Name = "rbPersona";
            rbPersona.Size = new Size(67, 19);
            rbPersona.TabIndex = 9;
            rbPersona.Text = "Persona";
            rbPersona.UseVisualStyleBackColor = true;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtFechaNacimiento.Location = new Point(92, 68);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(97, 23);
            dtFechaNacimiento.TabIndex = 8;
            dtFechaNacimiento.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtFechaNacimiento.Leave += dtFechaNacimiento_Leave;
            // 
            // mtDni
            // 
            mtDni.Location = new Point(92, 10);
            mtDni.Mask = "00,000,000";
            mtDni.Name = "mtDni";
            mtDni.Size = new Size(197, 23);
            mtDni.TabIndex = 7;
            mtDni.Leave += mtDni_Leave;
            // 
            // tNombre
            // 
            tNombre.Location = new Point(92, 39);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(197, 23);
            tNombre.TabIndex = 5;
            tNombre.KeyPress += tNombre_KeyPress;
            tNombre.Leave += tNombre_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 76);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nac.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 13);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // pLista
            // 
            pLista.BackColor = Color.PeachPuff;
            pLista.Controls.Add(lCantidad);
            pLista.Controls.Add(lbPersonas);
            pLista.Controls.Add(cbFiltros);
            pLista.Location = new Point(325, 12);
            pLista.Name = "pLista";
            pLista.Size = new Size(194, 220);
            pLista.TabIndex = 10;
            // 
            // lCantidad
            // 
            lCantidad.AutoSize = true;
            lCantidad.Location = new Point(12, 191);
            lCantidad.Name = "lCantidad";
            lCantidad.Size = new Size(58, 15);
            lCantidad.TabIndex = 13;
            lCantidad.Text = "Cantidad:";
            // 
            // lbPersonas
            // 
            lbPersonas.FormattingEnabled = true;
            lbPersonas.HorizontalExtent = 450;
            lbPersonas.HorizontalScrollbar = true;
            lbPersonas.ItemHeight = 15;
            lbPersonas.Location = new Point(12, 39);
            lbPersonas.Name = "lbPersonas";
            lbPersonas.Size = new Size(170, 139);
            lbPersonas.TabIndex = 12;
            // 
            // cbFiltros
            // 
            cbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "TODOS", "Estudiantes", "NO Estudiantes" });
            cbFiltros.Location = new Point(12, 10);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(170, 23);
            cbFiltros.TabIndex = 11;
            cbFiltros.SelectedIndexChanged += cbFiltros_SelectedIndexChanged;
            // 
            // pEstudiante
            // 
            pEstudiante.BackColor = Color.PaleGreen;
            pEstudiante.Controls.Add(tCarrera);
            pEstudiante.Controls.Add(label7);
            pEstudiante.Controls.Add(mtLegajo);
            pEstudiante.Controls.Add(label6);
            pEstudiante.Location = new Point(12, 154);
            pEstudiante.Name = "pEstudiante";
            pEstudiante.Size = new Size(307, 78);
            pEstudiante.TabIndex = 13;
            pEstudiante.Visible = false;
            // 
            // tCarrera
            // 
            tCarrera.Location = new Point(98, 41);
            tCarrera.Name = "tCarrera";
            tCarrera.Size = new Size(181, 23);
            tCarrera.TabIndex = 10;
            tCarrera.KeyPress += tCarrera_KeyPress;
            tCarrera.Leave += tCarrera_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 49);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 11;
            label7.Text = "Carrera:";
            // 
            // mtLegajo
            // 
            mtLegajo.Location = new Point(98, 8);
            mtLegajo.Mask = "000000";
            mtLegajo.Name = "mtLegajo";
            mtLegajo.Size = new Size(81, 23);
            mtLegajo.TabIndex = 10;
            mtLegajo.Leave += mtLegajo_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 11);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Legajo:";
            // 
            // bMostrar
            // 
            bMostrar.Location = new Point(12, 238);
            bMostrar.Name = "bMostrar";
            bMostrar.Size = new Size(75, 23);
            bMostrar.TabIndex = 14;
            bMostrar.Text = "Mostrar";
            bMostrar.UseVisualStyleBackColor = true;
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(216, 238);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 23);
            bGuardar.TabIndex = 15;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(444, 238);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(75, 23);
            bCerrar.TabIndex = 16;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 271);
            Controls.Add(bCerrar);
            Controls.Add(bGuardar);
            Controls.Add(bMostrar);
            Controls.Add(pEstudiante);
            Controls.Add(pLista);
            Controls.Add(pPersona);
            Name = "FPersonas";
            Text = "Personas";    
            pPersona.ResumeLayout(false);
            pPersona.PerformLayout();
            pLista.ResumeLayout(false);
            pLista.PerformLayout();
            pEstudiante.ResumeLayout(false);
            pEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pPersona;
        private TextBox tNombre;
        private Label label4;
        private Label label3;
        private Label label1;
        private MaskedTextBox mtDni;
        private DateTimePicker dtFechaNacimiento;
        private Panel pLista;
        private ListBox lbPersonas;
        private ComboBox cbFiltros;
        private Panel pEstudiante;
        private Label label6;
        private Label lCantidad;
        private TextBox tCarrera;
        private Label label7;
        private MaskedTextBox mtLegajo;
        private Button bMostrar;
        private Button bGuardar;
        private Button bCerrar;
        private ErrorProvider errorProvider;
        private RadioButton rbEmpleado;
        private RadioButton rbEstudiante;
        private RadioButton rbPersona;
    }
}