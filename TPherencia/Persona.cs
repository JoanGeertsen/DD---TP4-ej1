using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            nombre = ""; apellido = ""; fechaNacimiento="";
        }

        public Persona(String documento, string nombre, string apellido, string fechaNacimiento) 
        { //Las comprobaciones son temporales, hay que cambiarlas
            this.documento = (documento.Length == 10) ? documento : documentoPorDefecto;
            this.nombre = (nombre!=null) ? nombre : "";
            this.apellido = (apellido != null) ? apellido : "";
            this.fechaNacimiento = (fechaNacimiento != null) ? fechaNacimiento : "";
        }
        #endregion

        #region Property
        public string Documento
        {
            get { return documento; }
            set { documento = (documento.Length == 10) ? documento : documentoPorDefecto; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = (nombre != null) ? nombre : ""; }
        }

        public string Apellido
        {
            get { return Apellido; }
            set { Apellido = (Apellido != null) ? Apellido : ""; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = (fechaNacimiento != null) ? fechaNacimiento : ""; }
        }
        #endregion

        #region Static       
        #endregion

        #region Consulta
        public string mostrar()
        {
            return $"{nombre} {apellido}, {documento}, {fechaNacimiento}";
        }
        #endregion
    }
}
