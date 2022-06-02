using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tienda
    {
        private List<Prenda> prendas;

        public List<Prenda> Prendas
        {
            get { return prendas; }
        }
      public Tienda()
        {
            prendas = new List<Prenda>();
        }

        public static Tienda operator -(Tienda tienda, Prenda prenda)
        {
            if(tienda is not null && prenda is not null)
            {
                foreach (Prenda prenda2 in tienda.Prendas)
                {
                    if (prenda == prenda2)
                    {
                        prenda.Stock--;
                    }
                }
            }
            return tienda;
        }
            
        public static Tienda operator +(Tienda tienda, Prenda prenda)
        {
            if(prenda is not null)
            {
               foreach(Prenda prenda2 in tienda.Prendas)
                {
                    if(prenda != prenda2)
                    {
                     tienda.prendas.Add(prenda2);
                    }
                    else
                    {
                    prenda.Stock++;
                    }
                   
                }
                
            }
            return tienda;
        }

    }
}
