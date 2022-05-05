using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected double precio;

        public double Precio
        {
            get
            {
                if(this.precio == 0)
                {
                    this.precio = generadorDePrecios.Next(10500, 125001);
                }

                return this.precio;
            }
        }

        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fabricante: {(string)p.fabricante}");
            sb.AppendLine($"Modelo: {p.modelo}");
            sb.AppendLine($"Precio: {p.Precio}");



            return sb.ToString();
        }

        static Producto()
        {
            Producto.generadorDePrecios = new Random();
        }

        public Producto(string modelo, Fabricante fabricante)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
        }

        public Producto(string modelo, string marca, EPais pais) 
            : this(modelo, new Fabricante(marca, pais))
        {
            
        }

        public static bool operator ==(Producto a, Producto b)
        {
            return a.modelo == b.modelo && a.fabricante == b.fabricante;

        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        public static explicit operator string(Producto p)
        {
           // Console.WriteLine($"Entro: {p.modelo}");
           // Console.ReadKey();
            return Producto.Mostrar(p);
        }
    }
}
