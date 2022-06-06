using AppDenpendency;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EFCore4WebApi
{
    public static class ServiceRegister
    {
        public static void AddServicePack(this IServiceCollection services)
        {
            var projectDlls = new string[] { 
                "AppRespository.dll",
                "AppService.dll",
                "EFCore4WebApi.dll"
            };
            var list = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly).ToList();

            var assemblys = list.Where(file_path =>
            {
                return File.Exists(file_path) && projectDlls.Any(p => p == Path.GetFileName(file_path));
            }).Select(Assembly.LoadFrom).ToArray(); ;


            var tt = assemblys.SelectMany(a => a.GetTypes().Where(t => typeof(IAppDenpendency).IsAssignableFrom(t))).ToArray();

            var typeClassList = tt.Where(a => a.IsClass && !a.IsAbstract && !a.IsInterface).ToList();
            typeClassList.ForEach(t =>
            {
                var interfaceType = tt.FirstOrDefault(a => a.Name == $"I{t.Name}" && a.IsInterface);
                if (interfaceType != null)
                {
                    services.AddScoped(interfaceType, t);
                }
            });
        }
    }
}
