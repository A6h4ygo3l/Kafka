using Confluent.Kafka;
using System;

namespace KafkaDemo
{
    internal static class Consumer
    {
        public static void ConsumeMessages()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "demo-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Null, string>(config).Build();
            consumer.Subscribe("demo-topic");

            Console.WriteLine("Waiting for messages...");
            while (true)
            {
                var cr = consumer.Consume();
                Console.WriteLine($"Received: {cr.Message.Value}");
            }
        }
    }
}
