using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Calce
    {
        Ajustado,Normal,Ancho
    }
    public class Jean : Prenda
    {
        private Calce calce;
        public Jean(string modelo, Talles talle,Color colorPrimario,Calce calce)
            : base(modelo, talle, colorPrimario)
        {
            this.calce = calce;
        }
        public override string Tamanio()
        {
            string mensaje = "";
            if (this.talle == Talles.Chico)
            {
                mensaje = "Cintura 100 y Pierna 104";
            }
            else
            {
                mensaje = "Cintura 116 y Pierna 112";
            }
            return mensaje;
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.Append($"- {this.calce}");
            return sb.ToString();
        }

    }
}
