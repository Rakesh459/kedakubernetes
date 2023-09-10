// See https://aka.ms/new-console-template for more information
using Azure.Storage.Queues;

Console.WriteLine("Hello, World!");

var qa = "";
var dev = "";

// Instantiate a QueueClient to create and interact with the queue
QueueClient queueClient = new QueueClient(dev,
    "testqueue", new QueueClientOptions { MessageEncoding = QueueMessageEncoding.Base64});

foreach (var item in Enumerable.Range(1,1000))
{
await queueClient.SendMessageAsync("test message "+ item);

}