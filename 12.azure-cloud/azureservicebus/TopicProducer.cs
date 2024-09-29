using System.Text;
using Microsoft.Azure.ServiceBus;

namespace azureservicebus
{
    public class TopicProducer
    {
        private readonly TopicClient _client;

        public TopicProducer()
        {
            _client = new TopicClient("Endpoint=sb://dio-service-bus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=T5qt3Bn3jj7QVERxt6JHe+cqvotiqwmi6+ASbKL4dJY=",
                "topic1");
        }

        public async Task ProduceMessage()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    System.Console.WriteLine(
                        "Sending message: " + i);
                    await _client.SendAsync(
                    new Message(Encoding.UTF8.GetBytes("Number: " + i)));

                }
                System.Console.WriteLine("All messages sent");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("[Error] " +
                e.GetType().FullName + " " +
                e.Message);
            }
            finally
            {
                if (_client != null)
                {
                    await _client.CloseAsync();
                    System.Console.WriteLine("Closing connection to Azure Service Bus");
                }
            }
        }
    }
}