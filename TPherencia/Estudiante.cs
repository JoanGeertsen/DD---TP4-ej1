using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej1
{
    internal class Estudiante : Persona
    {
        #region Atributos
        private string legajo;
        private string carrera; 
        private static string legajoPorDefecto = "444444";
        #endregion

        #region Constructores
        public Estudiante(string documento, string legajo) : base(documento)
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            carrera = "";
        }

        public Estudiante(string documento, string nombre, string fechaNacimiento,
            string legajo, string carrera) : base(documento, nombre, fechaNacimiento)
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            this.carrera = (carrera != null) ? carrera : "";            
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
            get { return carrera; }
            set { carrera = (value != null) ? value : ""; }
        }     
        #endregion

        #region Consultas
        public override string ToString()
        {
            return base.ToString() + $"\n Legajo: {legajo} \n{carrera}";
        }

        public override bool Equals(Object obj)
        {
            bool igual = false;

            if (obj == null)
                igual = (this == null);
            else if (this.GetType() == obj.GetType())
            {
                Estudiante e = (Estudiante)obj;
                igual = (dni == e.Dni || legajo == e.Legajo);
            }

            return igual;
        }
        #endregion
    }
}
