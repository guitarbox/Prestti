using GeeksBankAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBankAPI.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class GeekBankController : DefaultController
    {
        [HttpGet]
        public decimal[] ObtenerFibo()
        {
            return fibo;
        }
        
        [HttpPost]
        public async Task<ActionResult> Calcular(Request request)
        {
            //Extraigo la información que envía el usuario
            Response response = new Response();
            response.Numero1 = request.Numero1;
            response.Numero2 = request.Numero2;
            response.Usuario = request.Usuario;
            response.IpOrigen = request.IpOrigen;

            response.Suma = request.Numero1 + request.Numero2;
            response.ExisteEnFibo = fibo.Contains(response.Suma);

            //Almaceno en la BD lo ocurrido
            await BL.BLRequest.CrearRequest(new DAL.Request()
            {
                Numero1 = response.Numero1,
                Numero2 = response.Numero2,
                Resultado = response.Suma,
                Usuario = response.Usuario,
                EncontradoEnSecuencia = response.ExisteEnFibo,
                FechaCreacion = DateTime.Now,
                IpOrigen = response.IpOrigen
            });

            return Ok(response);
        }
    }
}
