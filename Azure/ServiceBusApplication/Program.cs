using System;
using System.Text;
using Microsoft.Azure.ServiceBus;

namespace ServiceBusApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://servicebusg3.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=jDqSjk+0tQjlCWLUfg5HatRnn94lH3Fj+WZDBeuH/Vw=";
            var queueName = "sbququq";
            var client = new QueueClient(connectionString, queueName);
            Console.WriteLine("Please enter the message");
            string msg = Console.ReadLine();
            client.SendAsync(new Message(UTF8Encoding.Unicode.GetBytes(msg)));
            Console.WriteLine("Message sent successfully");
            Console.ReadKey();
        }
    }
}
