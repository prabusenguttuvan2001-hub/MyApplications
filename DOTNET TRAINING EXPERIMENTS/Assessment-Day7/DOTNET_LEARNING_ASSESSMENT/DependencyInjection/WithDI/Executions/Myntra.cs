using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Executions
{
    internal class Myntra
    {
        private readonly IMessageService _message;

        public Myntra(IMessageService message)
        {
            _message = message;
        }

        public void MessageProcess()
        {
            _message.SendMessageMethod();
        }

    }
}
