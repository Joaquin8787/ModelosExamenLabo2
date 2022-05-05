using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum SistemaOperativo
{
    ANDROID,IOS
}
namespace Entidades
{
    public  abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
        }
        protected abstract int Tamanio
        {
            get;
        }

       protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        { 
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int tamanioMayor = int.MinValue;
            Aplicacion aplicacionMasPesada = null;
            foreach(Aplicacion aplicacion in listaApp)
            {
                if(aplicacion.Tamanio > tamanioMayor)
                {
                    tamanioMayor = aplicacion.Tamanio;
                    aplicacionMasPesada = aplicacion;
                }
            }
            return aplicacionMasPesada;
        }
        public static bool operator !=(List<Aplicacion> listaApp,Aplicacion app)
        {
            return !(listaApp == app);
        }
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp is not null && app is not null)
            {
                foreach (Aplicacion aplicacion in listaApp)
                {
                    if (aplicacion.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema Operativo: {SistemaOperativo}");
            sb.AppendLine($"Tamanio Ocupado: {Tamanio}");
            return sb.ToString();
        }
        //ToString es la sobrecarga de la clase OBJECT
        public override string ToString()
        {
            return this.nombre;
        }


    }
}
