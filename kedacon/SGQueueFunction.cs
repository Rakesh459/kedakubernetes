using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace kedacon
{
    public class SGQueueFunction
    {
        private readonly ILogger<SGQueueFunction> _logger;

        public SGQueueFunction(ILogger<SGQueueFunction> logger)
        {
            _logger = logger;
        }

        [Function(nameof(SGQueueFunction))]
        public void Run([QueueTrigger("testqueue", Connection = "QueueCS")] string message, FunctionContext functionContext)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {message}");
        }
    }
}
