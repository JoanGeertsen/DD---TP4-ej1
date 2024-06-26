﻿namespace DD_TP3_ej1
{
    internal class Persona : IComparable<Persona> //Asumo que podemos usar el comparador para aprovechar la Lista
    {
        #region Atributos
        protected string nombre;
        protected string dni;
        protected string fechaNacimiento;
        private static string dniPorDefecto = "44.444.444";
        #endregion

        #region Constructores
        public Persona(string dni)
        {
            this.dni = (dni != null && dni.Length == 10) ? dni : dniPorDefecto;
            nombre = ""; fechaNacimiento = "";
        }

        public Persona(string dni, string nombre, string fechaNacimiento)
        { 
            this.dni = (dni != null && dni.Length == 10) ? dni : dniPorDefecto;
            this.nombre = (nombre != null) ? nombre : "";        
            this.fechaNacimiento = (fechaNacimiento != null) ? fechaNacimiento : "";
        }
        #endregion

        #region Property
        public string Dni
        {
            get { return dni; }
            set { dni = (value != null && value.Length == 10) ? value : dniPorDefecto; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = (value != null) ? value : ""; }
        }    

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = (value != null) ? value : ""; }
        }
        #endregion       

        #region Consultas
        public override string ToString()
        {
            return $" {nombre}\n DNI: {dni}\n Fecha de nacimiento: {fechaNacimiento}";
        }

        public override bool Equals(Object obj)
        {
            bool igual = false;

            if (obj == null)
                igual = (this == null);
            else if (this.GetType() == obj.GetType())
            {
                Persona p = (Persona) obj;
                igual = (dni == p.Dni);
            }

            return igual;
        }

        public override int GetHashCode()
        {
            return int.Parse(dni.Replace(".", ""));
        }
        public int CompareTo(Persona p)
        {
            int toReturn = 1;
            if (p != null)
                toReturn = dni.CompareTo(p.Dni);
            return toReturn;
        }
        #endregion
    }
}