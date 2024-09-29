using azureservicebus;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace azure_service_bus;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting application");
        await Start();
    }

    public static async Task Start()
    {
        System.Console.WriteLine("Service Bus Applcation");
        System.Console.WriteLine("Press 1 to produce messages on the queue");
        System.Console.WriteLine("Press 2 to produce messages on the topic");
        System.Console.WriteLine("Press 3 to read messages");
        var input = Console.ReadLine();
        if (input == "1")
        {
            await new QueueProducer().ProduceMessage();
            await Start();
        }
        else if (input == "2")
        {
            await new TopicProducer().ProduceMessage();
            await Start();
        }
        else
            CreateHostBuilder().Build().Run();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<QueueConsumer>();
                services.AddHostedService<TopicConsumer>();
            }
    );
}