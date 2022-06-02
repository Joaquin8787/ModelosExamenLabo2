using System;
using System.Drawing;
using System.Text;

namespace Biblioteca
{
    public enum Talles
    {
        Chico, Grande
    }
    public abstract class Prenda
    {
        protected Color colorPrimario;
        protected string modelo;
        protected int stock = 1;
        protected Talles talle;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.modelo} - {talle} - {this.Tamanio()} - Color Color {colorPrimario} - {this.Stock}");
            return sb.ToString();
        }
        public Prenda(string modelo)
        {
            this.modelo = modelo;
        }
        public Prenda(string modelo, Talles talle)
            :this(modelo)
        {
            this.talle = talle;
        }
        public Prenda(string modelo, Talles talle, Color colorPrimario)
            : this(modelo,talle)
        {
            this.colorPrimario = colorPrimario;
        }
        public abstract string Tamanio();

        public static bool operator ==(Prenda prenda1, Prenda prenda2)
        {
            if(prenda1 is not null && prenda2 is not null)
            {
                if(prenda1.talle == prenda2.talle && prenda1.modelo == prenda2.modelo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Prenda prenda1, Prenda prenda2)
        {
            return !(prenda1 == prenda2);
        }


    }
}
