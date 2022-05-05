using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public enum EGama {Baja, Media, Alta };
    public class Celular : Producto
    {
        public EGama gama;

        public Celular(string modelo, Fabricante fabricante, EGama gama)
            : base(modelo, fabricante)
        {
            this.gama = gama;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Celular)
            {
                retorno =  this == (Celular)obj;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{(string)this}");
            sb.AppendLine($"Gama: {this.gama}");

            return sb.ToString();
        }

        public static bool operator ==(Celular a, Celular b)
        {
            return ((Producto)a) == ((Producto)b) && a.gama == b.gama;
        }

        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        public static implicit operator Double(Celular celu)
        {
            return celu.Precio;
        }
    }
}
