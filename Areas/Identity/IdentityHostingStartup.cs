using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ValuationCalculator.Areas.Identity.Data;
using ValuationCalculator.Data;

[assembly: HostingStartup(typeof(ValuationCalculator.Areas.Identity.IdentityHostingStartup))]
namespace ValuationCalculator.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ValuationCalculatorContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ValuationCalculatorDatabase")));

                services.AddDefaultIdentity<ValuationCalculatorUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ValuationCalculatorContext>();
            });
        }
    }
}