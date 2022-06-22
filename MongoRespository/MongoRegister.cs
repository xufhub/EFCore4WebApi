using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoRespository
{
    public static class MongoRegister
    {
        public static void DIMongoDbContext(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IAppMongoDbContext), typeof(AppMongoDbContext));
        }
    }
}
