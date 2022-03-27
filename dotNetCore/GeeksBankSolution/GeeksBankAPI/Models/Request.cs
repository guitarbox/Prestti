using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBankAPI.Models
{
    public class Request
    {
        public string Usuario { get; set; }
        public string IpOrigen { get; set; }
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
    }
}
