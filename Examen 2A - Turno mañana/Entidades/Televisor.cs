using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public enum ETipo { Tubo, Plasma, Led }
    public class Televisor : Producto
    {
        public ETipo tipo;

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Televisor)
            {
                retorno = this == (Televisor)obj;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"Tipo: {this.tipo}");


            return sb.ToString();
        }

        public Televisor(string modelo, string marca, EPais pais, ETipo tipo)
            :base(modelo, marca, pais)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Televisor a, Televisor b)
        {
            return ((Producto)a) == ((Producto)b) && a.tipo == b.tipo;
        }

        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }

        public static explicit operator double (Televisor tv)
        {
            return tv.Precio;
        }
    }
}
