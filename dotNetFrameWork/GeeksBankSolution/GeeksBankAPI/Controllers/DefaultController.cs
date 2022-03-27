using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GeeksBankAPI.Controllers
{
    public class DefaultController : ApiController
    {
        public bool error = false;
        public string msgError = string.Empty;
        public JObject response = new JObject();

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
            while(cont < fibo.Length)
            {
                decimal c = a + b;
                fibo[cont] = c;
                a = b;
                b = c;
                cont++;
            }
        }

        /*Métodos genéricos usados para cargar la respuesta JSON que entrega el API*/
        public void SetErrorResponse(bool Error)
        {
            if (response.ContainsKey("error"))
            {
                response["error"] = Error;
            }
            else
            {
                response.Add("error", JToken.FromObject(Error));
            }
        }

        public void SetMsgErrorResponse(Exception ex)
        {
            if (response.ContainsKey("msgError"))
            {
                response["msgError"] = GetExceptionMessage(ex);
            }
            else
            {
                response.Add("msgError", JToken.FromObject(GetExceptionMessage(ex)));
            }
            SetErrorResponse(true);
        }

        public void SetValidTokendResponse(bool ValidToken)
        {
            if (response.ContainsKey("validToken"))
            {
                response["validToken"] = ValidToken;
            }
            else
            {
                response.Add("validToken", JToken.FromObject(ValidToken));
            }
        }

        public void SetDataResponse(object Data)
        {
            if (response.ContainsKey("data"))
            {
                if (Data != null)
                    response.Add("data", JToken.FromObject(Data));
                else
                    response.Add("data", null);
            }
            else
            {
                if (Data != null)
                    response.Add("data", JToken.FromObject(Data));
                else
                    response.Add("data", null);
            }
        }

        public string GetExceptionMessage(Exception ex)
        {
            return $"{ex.Message} => { (ex.InnerException != null ? GetExceptionMessage(ex.InnerException) : "") }";
        }
    }
}