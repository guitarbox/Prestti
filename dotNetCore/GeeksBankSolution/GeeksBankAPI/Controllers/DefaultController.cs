using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBankAPI.Controllers
{
    public class DefaultController : Controller
    {
        public bool error = false;
        public string msgError = string.Empty;        

        //Se declara el arreglo de decimales ya que los números de la serie fibonacci hasta 100 son muy grandes
        public decimal[] fibo = new decimal[100];

        public DefaultController()
        {
            //Llenamos el vector y lo almacenamos en memoria
            CargarFibo();
        }

        /***
         * Carga el arreglo con los primeros n números de la serie de fibonacci, donde n es el tamaño del arreglo declarado
         ***/
        private void CargarFibo()
        {
            decimal a = 0, b = 1;
            int cont = 0;
            fibo[cont] = a; cont++;
            fibo[cont] = b; cont++;
            while (cont < fibo.Length)
            {
                decimal c = a + b;
                fibo[cont] = c;
                a = b;
                b = c;
                cont++;
            }
        }

        public string GetExceptionMessage(Exception ex)
        {
            return $"{ex.Message} => { (ex.InnerException != null ? GetExceptionMessage(ex.InnerException) : "") }";
        }
    }
}
