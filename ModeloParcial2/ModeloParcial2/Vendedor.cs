using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        public string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float ganancia = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{vendedor.nombre.ToUpper()}");
            sb.AppendLine($"---------------------------------");
            foreach(Publicacion publicacion in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACION:\n{publicacion.ObtenerInformacion()}");
                ganancia += publicacion.Importe;
            }
            sb.AppendLine($"---------------------------------");
            sb.AppendLine($"Ganancia Total: ${ganancia}");
            return sb.ToString();

        }
        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre) : this() //Hago referencia al constructor de arriba
        {
            this.nombre = nombre;
        }
        //agregará siempre y cuando haya
        //stock suficiente para realizar una venta del producto,
        //agregando en ese caso la información de la venta a la lista y descontando stock de la publicación.
        public static bool operator + (Vendedor vendedor,Publicacion publicacion)
        {
            if(vendedor is not null && publicacion is not null)
            {
                if (publicacion.HayStock)
                {
                    vendedor.ventas.Add(publicacion);
                    publicacion.Stock--;
                    return true;
                }
                
            }
            return false;
        }
    }
}
