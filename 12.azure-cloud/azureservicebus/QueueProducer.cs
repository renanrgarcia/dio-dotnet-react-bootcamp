using System.Text;
using Microsoft.Azure.ServiceBus;

namespace azureservicebus
{
    public class QueueProducer
    {
        private readonly QueueClient _client;

        public QueueProducer()
        {
            _client = new QueueClient("Endpoint", "queue1");
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
                    // await _client.ScheduleMessageAsync(
                    //     new Message(Encoding.UTF8.GetBytes("Number: " + i)),
                    //     DateTime.Now.AddMinutes(1));
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