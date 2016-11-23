using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace CityInfo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder() //instance to run a web host
                .UseKestrel() //decoupled cross-platform web server
                .UseContentRoot(Directory.GetCurrentDirectory()) //specifies the main folder for the app's content
                .UseIISIntegration()  
                .UseStartup<Startup>() 
                .Build();

            host.Run(); //runs web application
        }
    }
}
