using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) 
            : this(nombre, sistemaOperativo, tamanioMb,new List<string>()) //ESTO
        {
        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb,List<string> listaCanciones) 
            : base(nombre, sistemaOperativo, tamanioMb)
        {
            if(listaCanciones is null)
            {
                this.listaCanciones = new List<string>(); //ESTO
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
            
        }

        protected override int Tamanio
        {
            get
            { //SIN THIS
                int tamanioTotal = listaCanciones.Count * 2;
                return tamanioMb + tamanioTotal;
            }
        }
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine($"Lista de Canciones:\n");
            foreach (string s in listaCanciones)
            {
                sb.AppendLine($"{s}");
            }
            return sb.ToString();
        }
    }
}
