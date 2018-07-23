using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie;
using System.IO;
//using Microsoft.AspNetCore.Mvc.
//using Microsoft.AspNetCore.Hosting.Internal;

namespace MvcMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            //var host = CreateWebHostBuilder(args).Build();

            //using (var scope = host.Services.CreateScope())

            host.Run();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) => 
           
            
    }
}
