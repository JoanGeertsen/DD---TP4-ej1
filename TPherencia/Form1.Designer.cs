namespace TPherencia
{
    partial class Form1
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
            pPersona = new Panel();
            dtFechaNacimiento = new DateTimePicker();
            mtDni = new MaskedTextBox();
            tApellido = new TextBox();
            tNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            label5 = new Label();
            cbFiltros = new ComboBox();
            lbPersonas = new ListBox();
            panel2 = new Panel();
            label6 = new Label();
            mtLegajo = new MaskedTextBox();
            label7 = new Label();
            tCarrera = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbCantidad = new Label();
            label8 = new Label();
            bBuscar = new Button();
            bGuardar = new Button();
            bCancelar = new Button();
            pPersona.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pPersona
            // 
            pPersona.BackColor = Color.PaleTurquoise;
            pPersona.Controls.Add(checkBox1);
            pPersona.Controls.Add(dtFechaNacimiento);
            pPersona.Controls.Add(mtDni);
            pPersona.Controls.Add(tApellido);
            pPersona.Controls.Add(tNombre);
            pPersona.Controls.Add(label4);
            pPersona.Controls.Add(label3);
            pPersona.Controls.Add(label2);
            pPersona.Controls.Add(label1);
            pPersona.Location = new Point(12, 12);
            pPersona.Name = "pPersona";
            pPersona.Size = new Size(298, 147);
            pPersona.TabIndex = 0;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtFechaNacimiento.Location = new Point(92, 92);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(97, 23);
            dtFechaNacimiento.TabIndex = 8;
            // 
            // mtDni
            // 
            mtDni.Location = new Point(92, 63);
            mtDni.Mask = "00.000.000";
            mtDni.Name = "mtDni";
            mtDni.Size = new Size(197, 23);
            mtDni.TabIndex = 7;
            // 
            // tApellido
            // 
            tApellido.Location = new Point(92, 35);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(197, 23);
            tApellido.TabIndex = 6;
            // 
            // tNombre
            // 
            tNombre.Location = new Point(92, 6);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(197, 23);
            tNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 100);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nac.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 66);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 37);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(92, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Estudiante";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(lbCantidad);
            panel1.Controls.Add(lbPersonas);
            panel1.Controls.Add(cbFiltros);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(316, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 255);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 6);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "Filtro:";
            // 
            // cbFiltros
            // 
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Location = new Point(12, 24);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(170, 23);
            cbFiltros.TabIndex = 11;
            cbFiltros.Text = "TODOS";
            // 
            // lbPersonas
            // 
            lbPersonas.FormattingEnabled = true;
            lbPersonas.ItemHeight = 15;
            lbPersonas.Location = new Point(12, 53);
            lbPersonas.Name = "lbPersonas";
            lbPersonas.Size = new Size(170, 169);
            lbPersonas.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(tCarrera);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(mtLegajo);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 102);
            panel2.TabIndex = 13;
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
            // mtLegajo
            // 
            mtLegajo.Location = new Point(98, 8);
            mtLegajo.Mask = "000000";
            mtLegajo.Name = "mtLegajo";
            mtLegajo.Size = new Size(81, 23);
            mtLegajo.TabIndex = 10;
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
            // tCarrera
            // 
            tCarrera.Location = new Point(98, 41);
            tCarrera.Name = "tCarrera";
            tCarrera.Size = new Size(181, 23);
            tCarrera.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(98, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(97, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(12, 231);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(58, 15);
            lbCantidad.TabIndex = 13;
            lbCantidad.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 75);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 12;
            label8.Text = "Fecha Ingreso:";
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(12, 273);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 14;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;            
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(216, 273);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 23);
            bGuardar.TabIndex = 15;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            bCancelar.Location = new Point(435, 273);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(75, 23);
            bCancelar.TabIndex = 16;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 304);
            Controls.Add(bCancelar);
            Controls.Add(bGuardar);
            Controls.Add(bBuscar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pPersona);
            Name = "Form1";
            Text = "Personas";
            pPersona.ResumeLayout(false);
            pPersona.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pPersona;
        private TextBox tNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtDni;
        private TextBox tApellido;
        private DateTimePicker dtFechaNacimiento;
        private CheckBox checkBox1;
        private Panel panel1;
        private ListBox lbPersonas;
        private ComboBox cbFiltros;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Label lbCantidad;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox tCarrera;
        private Label label7;
        private MaskedTextBox mtLegajo;
        private Button bBuscar;
        private Button bGuardar;
        private Button bCancelar;
    }
}