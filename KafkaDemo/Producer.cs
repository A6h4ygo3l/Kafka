using Confluent.Kafka;
using System;
using System.Threading.Tasks;

namespace KafkaDemo
{
    internal static class Producer
    {
        public static async Task ProduceMessage()
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            try
            {
                var result = await producer.ProduceAsync("demo-topic", new Message<Null, string> { Value = "Hello Kafka!" });
                Console.WriteLine($"Message sent to {result.TopicPartitionOffset}");
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Error: {e.Error.Reason}");
            }
        }
    }
}
