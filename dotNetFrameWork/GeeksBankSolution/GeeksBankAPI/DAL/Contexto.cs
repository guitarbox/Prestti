using GeeksBankAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeeksBankAPI.DAL
{
    public class Contexto
    {
        public static void AlmacenarEnBD(Request request)
        {
            using (var ctx = new db_a427b7_presttiEntities())
            {
                ctx.Request.Add(request);
                ctx.SaveChanges();
            }
        }
    }
}