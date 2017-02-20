using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace ConsoleApplication
{
    public class Startup{
        public void Configure(IApplicationBuilder app){
            app.Run(
                context => 
                { 
                    //Control log or Writeline
                    return context.Response.WriteAsync("Hello drew on the web");
                 }
            );
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();
            
            host.Run();
            
            /* Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name} welcome to .net core 1.0"); */
           
        }
    }
}
