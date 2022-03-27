using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBankAPI.BL
{
    public class BLRequest
    {
        public static async Task CrearRequest(DAL.Request request)
        {
            using (DAL.DBContext ctx = new DAL.DBContext())
            {
                await ctx.Request.AddAsync(request);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
