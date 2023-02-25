using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System;
using DemoMVC.Controllers;
namespace DemoMVC
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            MemberInfo typeInfo = typeof(HomeController);
            var attributes = typeInfo.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine("testsssss");
                Console.WriteLine("test:" + attributes[i]);
            
            }
            CreateHostBuilder(args).Build().Run();
           
        }
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults((webBuilder) =>
            {
                webBuilder.UseStartup<Startup>();
            });
        }
    }
}




