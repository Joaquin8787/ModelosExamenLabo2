using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
 
    public class Pedido
    {
        private List<Producto> listaProductos;
        private string nombre;
        private string direccion;
        private string numeroTelefono;
        private double precioFinal = 0;

        public List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
        static Pedido()
        {
        
        }
        public Pedido(string nombre, string direccion, string numeroTelefono)
        {
            this.listaProductos = new List<Producto>();
            this.nombre = nombre;
            this.direccion = direccion;
            this.numeroTelefono = numeroTelefono;
        }
        public static bool operator + (List<Pedido> listaPedidos, Pedido pedidoNuevo)
        {
            if(listaPedidos is not null && pedidoNuevo is not null)
            {
                       listaPedidos.Add(pedidoNuevo);
                       return true;
            }
            return false;
        }
        public static double GeneradorPrecioFinal(List<Producto> listaProducto)
        {
            double precioFinal = 0;
            foreach(Producto producto in listaProducto)
            {
                precioFinal += (producto.Precio * producto.Cantidad);
            }
            return precioFinal;
        }
        /*public static bool operator ==(Pedido p1, Pedido p2)
        {
            return p1.IdPedido == p2.IdPedido;

        }
        public static bool operator !=(Pedido p1, Pedido p2)
        {
            return !(p1 == p2);

        }
        */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"ID:{idPedido}");
            sb.AppendLine($"Nombre contacto: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Numero telefonico: {this.numeroTelefono}");
            foreach (Producto producto in this.listaProductos)
            {
                sb.Append(producto.MostrarInformacion());
                precioFinal += (producto.Precio * producto.Cantidad);
            }
            sb.AppendLine($"Precio final: {this.precioFinal}");
            return sb.ToString();
        }
    }
}