using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace ServiceBusReceiveApp
{
    class Program
    {
        static string connectionString = "Endpoint=sb://servicebusg3.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=jDqSjk+0tQjlCWLUfg5HatRnn94lH3Fj+WZDBeuH/Vw=";
        static string queueName = "sbququq";
        static IQueueClient client;
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
            
        }
        static async Task MainAsync()
        {
            client = new QueueClient(connectionString,queueName);
            Console.WriteLine("The message is ");
            RegisterMessageHandler();
            Console.ReadKey();
            await client.CloseAsync();

        }
        static void RegisterMessageHandler()
        {
            var messageHandlerOptions = new MessageHandlerOptions(MessageExceptionHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };
            client.RegisterMessageHandler(MessageProcess, messageHandlerOptions);
        }
        static async Task MessageProcess(Message message,CancellationToken token)
        {
            Console.WriteLine(Encoding.UTF8.GetString(message.Body));
            await client.CompleteAsync(message.SystemProperties.LockToken);
        }
        static Task MessageExceptionHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            Console.WriteLine(exceptionReceivedEventArgs.Exception.Message);
            Console.WriteLine(exceptionReceivedEventArgs.ExceptionReceivedContext.Action);
            return Task.CompletedTask;
        }
    }
}
