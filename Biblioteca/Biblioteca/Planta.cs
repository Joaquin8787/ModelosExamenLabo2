using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public int Tamanio
        {
            get { return tamanio; }
        }
        public abstract bool TieneFlores
        {
            get;
        }
        public abstract bool TieneFruto
        {
            get;
        }
        public Planta(string nombre,int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        public virtual string ResumenDeDatos()
        {
            string tieneFlores = TieneFlores ? "SI" : "NO";
            string tieneFruto = TieneFruto ? "SI" : "NO";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} tiene un tamanio de {this.tamanio}");
            sb.AppendLine($"Tiene flores:{tieneFlores}");
            sb.AppendLine($"Tiene fruto:{tieneFruto}");
            return sb.ToString();
        }

    }
}
