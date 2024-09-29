using Microsoft.Extensions.Hosting;
using Microsoft.Azure.ServiceBus;
using System.Text;

namespace azureservicebus
{
    public class TopicConsumer : BackgroundService
    {
        private readonly SubscriptionClient _client;

        public TopicConsumer()
        {
            _client = new SubscriptionClient("Endpoint=sb://dio-service-bus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=T5qt3Bn3jj7QVERxt6JHe+cqvotiqwmi6+ASbKL4dJY=",
                "topic1", "subscribe1");
            Console.WriteLine("Topic reading from service bus started");
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _client.RegisterMessageHandler(ProcessMessage,
                new MessageHandlerOptions(ProcessError)
                {
                    // MaxConcurrentCalls = 1,
                    MaxConcurrentCalls = 5,
                    AutoComplete = false
                }
            );

            return Task.CompletedTask;
        }

        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            await _client.CloseAsync();
            Console.WriteLine("Closing connection to Azure Service Bus");
        }

        private async Task ProcessMessage(Message message, CancellationToken token)
        {
            var body = Encoding.UTF8.GetString(message.Body);
            Console.WriteLine($"[New message on queue received] {body}");
            await _client.CompleteAsync(message.SystemProperties.LockToken);
            // await _client.DeadLetterAsync(message.SystemProperties.LockToken, "DeadLetterReason", "DeadLetterErrorDescription");
        }

        private Task ProcessError(ExceptionReceivedEventArgs e)
        {
            Console.WriteLine("[Error] " +
                e.Exception.GetType().FullName + " " +
                e.Exception.Message);
            return Task.CompletedTask;
        }
    }
}