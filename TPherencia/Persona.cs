using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DD_TP3_ej1
{    
    internal class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected string documento;
        protected string fechaNacimiento;
        private static string documentoPorDefecto="44.444.444";
        #endregion

        #region Constructores
        public Persona(string documento) 
        {
            this.documento = (documento.Length == 10) ? documento: documentoPorDefecto;            
        }

        public Persona(String documento, string nombre, string apellido, string fechaNacimiento) 
        { //Las comprobaciones son temporales, hay que cambiarlas
            this.documento = (documento.Length == 10) ? documento : documentoPorDefecto;
            this.nombre = (nombre!=null) ? nombre : "";
            this.apellido = (apellido != null) ? apellido : "";
            this.fechaNacimiento = (fechaNacimiento != null) ? fechaNacimiento : "";
        }
        #endregion

        #region Static       
        #endregion
    }
}
