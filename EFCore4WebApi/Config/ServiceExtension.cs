using AppRespository;
using Common;
using Microsoft.Extensions.DependencyInjection;
using MongoRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore4WebApi
{
    public static class ServiceExtension
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            AppSetting.Init(services);
            services.DIMysqlDbContext();
            services.DIMongoDbContext();
            services.AddServicePack();
        }
    }
}
