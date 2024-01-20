// See https://aka.ms/new-console-template for more information
using Azure.Storage.Queues;

Console.WriteLine("Hello, World!");

var dev = "DefaultEndpointsProtocol=https;AccountName=rakeshstorage;AccountKey=TwmFOxOQud1v2R4FofbgzuKoZRIaFjoZWmYVmxYM8CHLFu7TLa0X7dkXa485QAKshljqGLRv+NGCUZ4cxAlF4A==;EndpointSuffix=core.windows.net";

// Instantiate a QueueClient to create and interact with the queue
QueueClient queueClient = new QueueClient(dev,
    "testqueue", new QueueClientOptions { MessageEncoding = QueueMessageEncoding.Base64});

foreach (var item in Enumerable.Range(1,500))
{
await queueClient.SendMessageAsync("test message "+ item);
    Console.WriteLine(item);

}