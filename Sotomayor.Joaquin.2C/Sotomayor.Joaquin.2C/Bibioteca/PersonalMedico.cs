using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteca
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consulta;
        private bool esResidente;

        internal override string FichaExtra()
        {
            string esRecidente = esResidente ? "SI" : "NO";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizo la residencia? {esRecidente}");
            sb.AppendLine("ATENCIONES: ");
            foreach(Consulta consulta in consulta)
            {
                sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
        }
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente)
            :base(nombre, apellido, nacimiento)
        {
            this.esResidente = esRecidente;
            consulta = new List<Consulta>();
        }

        //El operador + agregará nuevas consultas a la lista,
        //tomando como fecha de inicio de la misma el
        //método Now de la clase DateTime.
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            
            if(doctor is not null && paciente is not null)
            {
                Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
                doctor.consulta.Add(nuevaConsulta);
                return nuevaConsulta;
            } 
            return null;
        }
    }
}
