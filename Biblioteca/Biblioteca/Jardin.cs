using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo,Arenozo
        }
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        //EspacioOcupado retornará el espacio total ocupado por todas las plantas del Jardín.
        private int EspacioOcupado()
        {
            int espacioTotalOcupado = 0;
            foreach(Planta planta in plantas)
            {
                espacioTotalOcupado += planta.Tamanio;
            }
            return espacioTotalOcupado;
        }
        //EspacioOcupado(Planta) retornará el total ocupado + el tamaño de la plata recibida como parámetro.
        private int EspacioOcupado(Planta planta)
        {
            return (EspacioOcupado() + planta.Tamanio);
        }
        static Jardin()
        {
            Jardin.suelo = Jardin.Tipo.Terrozo;
        }
        private Jardin()
        {
            plantas = new List<Planta>();
        }
        public Jardin(int espacioTotal)
            :this() //LLAMA AL PRIVADO DE ARRIBA, TE VAS A DAR CUENTA PORQUE ES PRIVADO
        {
            this.espacioTotal = espacioTotal;
        }
        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(jardin is not null && planta is not null && jardin.espacioTotal >= jardin.EspacioOcupado(planta)){
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del Jardin: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {EspacioOcupado()} de {this.espacioTotal}");
            foreach(Planta planta in plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }
            return sb.ToString();
        }
    }
}
