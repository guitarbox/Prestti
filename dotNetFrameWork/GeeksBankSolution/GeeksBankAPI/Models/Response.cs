using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeeksBankAPI.Models
{
    public class Response
    {
        public string Usuario { get; set; }
        public string IpOrigen { get; set; }
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Suma { get; set; }
        public bool ExisteEnFibo { get; set; }
    }
}