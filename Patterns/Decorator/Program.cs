using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new DefaultMessage();
            SMSMessage decorator0 = new SMSMessage(simple);
            Console.WriteLine("Client: я хочу получать уведомления по SMS");
            client.ClientCode(decorator0);
            Console.WriteLine();


            VKMessage decorator1 = new VKMessage(simple);
            TelegMessage decorator2 = new TelegMessage(decorator1);
            Console.WriteLine("Cleint: я хочу получать уведомления в SMS, VK, Telegram");
            client.ClientCode(decorator2);

            

        }
    }
}
