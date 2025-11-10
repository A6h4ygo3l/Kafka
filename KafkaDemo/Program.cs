using System.Threading.Tasks;

namespace KafkaDemo
{
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "produce")
            {
                await Producer.ProduceMessage();
            }
            else
            {
                Consumer.ConsumeMessages();
            }
        }
    }
}