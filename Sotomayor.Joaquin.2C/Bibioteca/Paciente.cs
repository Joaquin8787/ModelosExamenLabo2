using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteca
{
    public class Paciente : Persona
    {
        public string diagnostico;
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en: {barrioRecidencia}");
            sb.AppendLine($"{Diagnostico}");
            return sb.ToString();
       
        }
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
        :base(nombre, apellido, nacimiento,barrioRecidencia)
        {

        }
    }
}
