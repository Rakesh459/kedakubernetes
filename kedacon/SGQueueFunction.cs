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
        public async Task Run([QueueTrigger("testqueue", Connection = "QueueCS")] string message, FunctionContext functionContext)
        {
             await Task.Delay(TimeSpan.FromSeconds(1));
            _logger.LogInformation($"C# Queue trigger function processed: {message}");
        }
    }
}
