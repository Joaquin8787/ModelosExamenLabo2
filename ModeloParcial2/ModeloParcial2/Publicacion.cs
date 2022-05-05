using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected abstract bool EsColor
        {
            get;
        }

        public virtual bool HayStock
        {
            get
            {
                if (stock > 0 && importe > 0)
                {
                    return true;
                }
                return false;
            }

        }
        public float Importe
        {
            get
            {
                return importe;
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
            }
        }
                public virtual string ObtenerInformacion()
            {
                StringBuilder sb = new StringBuilder();
                string esColor = EsColor ? "SI" : "NO";
                sb.AppendLine($"Nombre: {nombre}");
                sb.AppendLine($"Stock: {stock.ToString()} ");
                sb.AppendLine($"Es Color: {EsColor}");
                sb.AppendLine($"Importe: {importe.ToString()}");
                return sb.ToString();
            }

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        public Publicacion(string nombre, int stock)
            :this(nombre)
        {
            Stock = stock;

        }
        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock)
        {
            this.importe = importe;
        }


        public override string ToString()
        {
            return nombre;
        }

    }
}
