using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Implementation;
using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Executions
{
    internal class MainClass
    {
        //static void Main()
        //{
        //    // Create Service Collection
        //    var services = new ServiceCollection();

        //    // Register services
        //    services.AddScoped<IMessageService, EMailService>(); // choose Email or SMS
        //    services.AddScoped<Flipkart>();
        //    //services.AddScoped<Amazon>();
        //    //services.AddScoped<Myntra>();

        //    // Build Service Provider (DI Container)
        //    var serviceProvider = services.BuildServiceProvider();

        //    // Resolve root object
        //    var a = serviceProvider.GetRequiredService<Flipkart>();

        //    // Use it
        //    a.MessageProcess();
        //}
    }
}
