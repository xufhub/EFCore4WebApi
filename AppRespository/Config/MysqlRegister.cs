using Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppRespository
{
    public static class MysqlRegister
    {
        public static void DIMysqlDbContext(this IServiceCollection services)
        {
            string connectionString = AppSetting.Configuration["Db:Mysql:ConnectionString"];
            services.AddDbContext<DbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}
