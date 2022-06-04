using System;
using System.Collections.Generic;
using System.Text;


namespace Biblioteca
{
    public abstract class Producto
    {
        protected string tipo;
        protected double precio;
        protected int cantidad;
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value > 0)
                {
                    cantidad = value;
                }
            }
        }
        public Producto(string tipo, double precio,int cantidad)
        {
            this.tipo = tipo;
            Precio = precio;
            this.cantidad = cantidad;   
        }
        internal abstract string MostrarInformacionParticular();
        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {this.tipo}");
            sb.Append($"{MostrarInformacionParticular()}");
            sb.AppendLine($"Precio: {this.Precio}");
            return sb.ToString();
        }
        public static Pedido operator +(Pedido listaProducto, Producto productoNuevo)
        {
            if (listaProducto is not null && productoNuevo is not null)
            {
                listaProducto.ListaProductos.Add(productoNuevo);
                return listaProducto;
            }
            return null;
        }
    }
}
