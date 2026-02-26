using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Interface;

namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Implementation
{
    internal class SMSService : IMessageService
    {
        public void SendMessageMethod()
        {
            Console.WriteLine("SMS was Sent!");
        }
    }
}
