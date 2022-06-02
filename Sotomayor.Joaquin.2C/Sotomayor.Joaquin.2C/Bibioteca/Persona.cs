using System;
using System.Text;

namespace Bibioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;
        
        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.apellido},{this.nombre}");
                
                return sb.ToString();
            }
        }
        internal abstract string FichaExtra();
        public string FichaPersona(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{p.ToString()}");
            sb.AppendLine($"EDAD:{p.Edad}");
            sb.AppendLine(FichaExtra());
            return sb.ToString();
        }
        public Persona(string nombre,string apellido,DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            :this(nombre,apellido,nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
