using GeeksBankAPI.DAL;
using GeeksBankAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GeeksBankAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GeekBankController : DefaultController
    {
        [HttpPost]
        [Route("api/GeekBank")]
        public JObject Calcular([FromBody] JObject Token)
        {
            try
            {
                //Extraigo la información que envía el usuario
                Response response = new Response();                
                response.Numero1 = Convert.ToDecimal(Token["numero1"].ToString());
                response.Numero2 = Convert.ToDecimal(Token["numero2"].ToString());
                response.Usuario = Token["usuario"].ToString();
                response.IpOrigen = Token["ipOrigen"].ToString();
                response.Suma = response.Numero1 + response.Numero2;                
                response.ExisteEnFibo = fibo.Contains(response.Suma);
                
                //Armo la respuesta que da el servicio
                SetDataResponse(response);
                
                //Almaceno en la BD lo ocurrido
                Contexto.AlmacenarEnBD(new GeeksBankAPI.Request()
                {
                    Numero1 = response.Numero1,
                    Numero2 = response.Numero2,
                    Resultado = response.Suma,
                    Usuario = response.Usuario,
                    EncontradoEnSecuencia = response.ExisteEnFibo,
                    FechaCreacion = DateTime.Now,
                    IpOrigen = response.IpOrigen
                });
            }
            catch (Exception ex)
            {
                SetMsgErrorResponse(ex);
            }

            return response;
        }
        
        [HttpGet]
        [Route("api/GeekBank")]
        public JObject ObtenerFibo()
        {
            try
            {                
                SetDataResponse(fibo);
            }
            catch (Exception ex)
            {
                SetMsgErrorResponse(ex);
            }

            return response;
        }
    }

    
}