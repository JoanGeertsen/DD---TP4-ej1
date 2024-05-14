using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DD_TP4_ej1
{
    internal class Empleado: Persona
    {
        #region Atributos
        private string legajo;
        private string cargo;
        private static string legajoPorDefecto = "444444";
        #endregion

        #region Constructor 
        public Empleado(string documento, string nombre, string fechaNacimiento,
            string legajo, string carrera, string fechaDeIngreso) : base(documento, nombre, fechaNacimiento)
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            this.cargo = (carrera != null) ? carrera : "";
        }
        #endregion

        #region Property        
        public string Legajo
        {
            get { return legajo; }
            set { legajo = (value.Length == 6) ? value : legajoPorDefecto; }
        }

        public string Carrera
        {
            get { return cargo; }
            set { cargo = (value != null) ? value : ""; }
        }
        #endregion      

        #region Consultas
        public override string ToString()
        {

            return base.ToString() + $"Cargo: {cargo} Legajo: {Legajo} ";
        }

        public bool esIgual(Empleado empleado)
        {
            return (Legajo == empleado.Legajo);

        }
        #endregion
    }
}
