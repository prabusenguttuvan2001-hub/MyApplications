    

namespace DOTNET_LEARNING_ASSESSMENT.CircuitBreakerPattern
{
    internal class CircuitBreaker
    {
        private int _failureCount = 0;
        private readonly int _failureThreshold = 3;
        private DateTime _lastFailureTime;
        private readonly TimeSpan _openTime = TimeSpan.FromSeconds(5);
        private bool _isOpen = false;

        public void Execute(Action action)
        {
            if (_isOpen)
            {
                if (DateTime.Now - _lastFailureTime > _openTime)
                {
                    Console.WriteLine("Trying again (Half-Open)...");
                    _isOpen = false;
                }
                else
                {
                    Console.WriteLine("Circuit is OPEN. Call blocked.");
                    return;
                }
            }

            try
            {
                action();
                _failureCount = 0;
            }
            catch
            {
                _failureCount++;
                _lastFailureTime = DateTime.Now;
                Console.WriteLine("Call failed");

                if (_failureCount >= _failureThreshold)
                {
                    _isOpen = true;
                    Console.WriteLine("Circuit opened!");
                }
            }
        }
    }

}
