using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public enum EProducto { PrecioDeTelevisores, PrecioDeCelulares, PrecioTotal }
    public class Deposito
    {
        private int capacidad;
        private List<Producto> productos;

        public double PrecioDeCelulares
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeCelulares);
            }
        }


        public double PrecioDeTelevisores
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeTelevisores);
            }
        }


        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioTotal);
            }
        }

        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        private Deposito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad del deposito: {d.capacidad} (Ocupado: {d.productos.Count})");
            sb.AppendLine($"Total por televisores: {d.PrecioDeTelevisores}");
            sb.AppendLine($"Total por celulares: {d.PrecioDeCelulares}");
            sb.AppendLine($"Total: {d.PrecioTotal}");
            sb.AppendLine("**************************");
            sb.AppendLine("Listado de productos:");
            sb.AppendLine("**************************");

            foreach (Producto producto in d.productos)
            {
                sb.AppendLine(producto.ToString());
            }

            return sb.ToString();
        }

        public double ObtenerPrecio(EProducto tipo)
        {
            double retorno = 0;

            foreach(Producto producto in this.productos)
            {
                if(tipo == EProducto.PrecioTotal ||
                    (tipo == EProducto.PrecioDeTelevisores && producto is Televisor) ||
                    (tipo == EProducto.PrecioDeCelulares && producto is Celular))
                {
                    retorno += producto.Precio;
                }
            }

            


            return retorno;
        }

        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }


        public static bool operator ==(Deposito d, Producto p)
        {
            bool retorno = false;

            if(d is not null && p is not null)
            {

                foreach(Producto producto in d.productos)
                {
                    if(producto.Equals(p))
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static Deposito operator +(Deposito d, Producto p)
        {
            if(d is not null && p is not null && d.capacidad > d.productos.Count )             
            {
                if ( d != p)
                {
                    d.productos.Add(p);
                }
                else
                {
                    Console.WriteLine("El producto ya se encuentr en el deposito!");

                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en el deposito!");
            }


            return d;

        }
    }
}
