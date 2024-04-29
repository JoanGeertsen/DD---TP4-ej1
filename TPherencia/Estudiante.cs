using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej1
{
    internal class Estudiante: Persona
    {
        #region Atributos
        private string legajo;
        private string carrera;
        private string fechaDeIngreso;
        private static string legajoPorDefecto = "444444";
        #endregion

        #region Constructores
        public Estudiante(string documento, string legajo): base(documento) 
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
        }

        public Estudiante(String documento, string nombre, string apellido, string fechaNacimiento,
            string legajo, string carrera, string fechaDeIngreso): base(documento, nombre, apellido, fechaNacimiento) 
        {
            this.legajo = (legajo.Length == 6) ? legajo : legajoPorDefecto;
            this.carrera = (carrera != null) ? carrera : "";
            this.fechaDeIngreso = (fechaDeIngreso != null) ? fechaDeIngreso : "";            
        }
        #endregion


    }
}
