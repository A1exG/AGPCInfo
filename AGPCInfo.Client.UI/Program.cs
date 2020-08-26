using AGPCInfo.Client.Library.Api;
using AGPCInfo.Client.Library.Helpers;
using AGPCInfo.Client.Library.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AGPCInfo.Client.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что будем делать?");
            Console.WriteLine("М - Настройка ПК");
            Console.WriteLine("C - Конфигурация");
            Console.WriteLine("C - Браузер");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.M:
                    Console.WriteLine("Настройка ПК");

                    Console.ReadLine();
                    break;
                case ConsoleKey.C:
                    Console.WriteLine("Конфигурация");
                    Console.WriteLine("S - Отправить конфигурацию");

                    var sendKey = Console.ReadKey();
                    switch (sendKey.Key)
                    {
                        case ConsoleKey.S:
                            ConfigHelper config = new ConfigHelper();
                            PCInfoHelper infoHelper = new PCInfoHelper(config);
                            PCConfiguration pcConfiguration = new PCConfiguration(infoHelper);

                            var pc = pcConfiguration.GetConfiguration();

                            APIHelper helper = new APIHelper();
                            PCEndpoint endpoint = new PCEndpoint(helper);

                            Task task = endpoint.CreatePCConfigurationAsync(pc);


                            Console.WriteLine("Данные отправлены!");
                            Console.ReadLine();
                            break;
                        
                        default:
                            Console.WriteLine("Что-то не так наверно");
                            break;
                    }

                    Console.ReadLine();
                    break;
                case ConsoleKey.Clear:
                    Console.WriteLine("Браузер");

                    



                    Console.ReadLine();
                    break;
                
                default:
                    break;
            }

            


        }
    }
}
