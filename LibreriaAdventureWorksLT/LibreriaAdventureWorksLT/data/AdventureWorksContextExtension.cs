using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksNS.Data
{
    public static class AdventureWorksContextExtension
    {
        public static IServiceCollection AdventureWorksDBContext(
            this IServiceCollection services, 
            string strCnx = "Data Source=DESKTOP-S0NQNAG;Initial Catalog=AdventureWorksLT2019;Integrated Security=false;User=sa;Password=GalileoPrueba;")
        {
            services.AddDbContext<AdventureWorksDB>(options => options.UseSqlServer(strCnx));
            return services;
        }
    }
}
