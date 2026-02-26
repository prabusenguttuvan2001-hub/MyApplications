using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.ImplementationWithoutDI
{
    internal class Amazon
    {
        public void MessageProcess()
        {
            SendSMS sms = new SendSMS();
            sms.SendMessageMethod();
        }
    }
}
