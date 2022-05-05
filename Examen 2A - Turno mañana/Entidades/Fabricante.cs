using System;

namespace Entidades.Primer.Parcial
{
    public enum EPais { Argentina, China, Holanda, USA, Corea}
    public class Fabricante
    {
        private string marca;
        private EPais pais;


        public Fabricante(string marca, EPais pais)
        {
            this.pais = pais;
            this.marca = marca;
        }

        public static implicit operator string (Fabricante f)
        {
            return $"{f.marca} - {f.pais}";
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {
            return a.marca == b.marca && a.pais == b.pais;
        }
        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }
    }
}
