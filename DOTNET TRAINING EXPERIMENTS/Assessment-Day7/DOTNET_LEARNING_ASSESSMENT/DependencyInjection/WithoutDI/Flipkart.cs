using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.ImplementationWithoutDI
{
    internal class Flipkart
    {
        public void MessageProcess()
        {
            SendSMS sms = new SendSMS();
            sms.SendMessageMethod();
        }

        //static void Main(string[] args)
        //{
        //    Flipkart fb = new Flipkart();
        //    Amazon am = new Amazon();
        //    Myntra myn = new Myntra();

        //    myn.MessageProcess();
        //    am.MessageProcess();
        //    fb.MessageProcess();
        //}

    }
}
