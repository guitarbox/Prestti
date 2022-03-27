using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeeksBankAPI.DAL
{
    public partial class Request
    {
        public int IdRequest { get; set; }
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }
        public bool EncontradoEnSecuencia { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IpOrigen { get; set; }
    }
}
