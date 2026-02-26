using DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Interface;


namespace DOTNET_LEARNING_ASSESSMENT.DependencyInjection.WithDI.Executions
{
    internal class Amazon
    {
        private readonly IMessageService _message;

        public Amazon(IMessageService message)
        {
            _message = message;
        } 

        public void MessageProcess()
        {
            _message.SendMessageMethod();
        }
    }
}
