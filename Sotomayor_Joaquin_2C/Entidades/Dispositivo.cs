using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }
        public static bool InstalarApp(Aplicacion app)
        {
            if(app.SistemaOperativo == sistemaOperativo)
            {
                return (appInstaladas + app);
            }
            return false;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sistema Operativo:{sistemaOperativo.ToString()}\n");
            foreach(Aplicacion aplicacion in appInstaladas)
            {
                sb.AppendLine(aplicacion.ObtenerInformacionApp());
            }
            return sb.ToString();
        }
    }
}
