using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Implementation
{
    internal class EMailService : IMessageService
    {
        public void SendMessageMethod()
        {
            Console.WriteLine("SMS was Sent!");
        }
    }
}
