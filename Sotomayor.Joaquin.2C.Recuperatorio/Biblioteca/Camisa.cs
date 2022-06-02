using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Biblioteca
{
    public class Camisa : Prenda
    {
        private Color colorSecundario;

        public Camisa(string modelo, Talles talle, Color colorPrimario, Color colorSecundario)
            :base(modelo, talle, colorPrimario)
        {
            this.colorSecundario = colorSecundario;
        }
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.Append($" - Con vivos {this.colorSecundario}");
            return sb.ToString();
        }
        public override string Tamanio()
        {
            string mensaje = "";
            if(this.talle == Talles.Chico)
            {
                mensaje = "Pecho 49 y Manga 67";
            }
            else
            {
                mensaje = "Pecho 53 y Manga 69";
            }
            return mensaje;
        }

    }
}
