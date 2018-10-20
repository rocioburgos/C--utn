using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        private string html;
        private Uri direccion;

        public Descargador(Uri direccion)
        {
            this.html = "";
            this.direccion = direccion;
        }

        public void IniciarDescarga()
        {
            try
            {
                
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged +=WebClientDownloadProgressChanged ;
                cliente.DownloadStringCompleted += WebClientDownloadCompleted;

                cliente.DownloadStringAsync(direccion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public delegate void  Progreso(int progreso);

        public event Progreso progreso;

        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progreso(e.ProgressPercentage);   
        }

        public delegate void FinDescarga(string fin);
        public event FinDescarga finalDescarga;
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            this.html= e.Result;

            this.finalDescarga(this.html);

        }


    }
}
