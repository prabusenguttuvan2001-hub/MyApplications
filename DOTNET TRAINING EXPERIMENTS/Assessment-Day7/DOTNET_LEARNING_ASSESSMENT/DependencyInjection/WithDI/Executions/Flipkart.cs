using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Executions
{
    internal class Flipkart
    {
        private readonly IMessageService _message;

        public Flipkart(IMessageService message)
        {
            _message = message;
        }

        public void MessageProcess()
        {
            _message.SendMessageMethod();
        }

    }
}
