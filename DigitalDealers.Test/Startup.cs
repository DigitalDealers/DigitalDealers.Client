using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalDealers.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalDealers.Test
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public async void ConfigureServices(IServiceCollection services)
        {
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                List<string> columns = new List<string>
                {
                    "Key",
                    "Serial Number"
                };

                List<string> keys = new List<string>();
                keys.Add("5638202516");
                keys.Add("5638202517");
                keys.Add("5638202518");

                using (var client = new DigitalDealersClient(""))
                {
                    var result = await client.Searches.ExecuteSearchWithKeys(keys.ToArray(), 681, null, 0, 10);
                    var lookup = result.GetByColumns();
                    await context.Response.WriteAsync(lookup.ToString());
                }
 
            });
        }
    }
}
