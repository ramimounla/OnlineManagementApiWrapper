using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineManagementApiWrapper;
using OnlineManagementApiWrapper.DTO;
using Refit;
using System.Net.Http;

namespace OnlineManagementApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAll(Task.Run(async () => await RetrieveInstancesAsync()));

            Console.WriteLine("End of application");
            Console.ReadLine();
        }

        public static async Task RetrieveInstancesAsync()
        {
            //TODO add authentication bearer here
            var bearerString = "bearer ";

            var httpClient = new HttpClient
            {
                //TODO change the service URL if not located in the Oceania region
                BaseAddress = new Uri("https://admin.services.crm6.dynamics.com"),
                DefaultRequestHeaders = {
                    { "Authorization", bearerString },
                    { "Accept-Language", "en-US" }
                }
            };

            var onlineManagementApi = RestService.For<IOnlineManagementApi>(httpClient);

            var instances = await onlineManagementApi.GetInstances();

            foreach (var instance in instances)
            {
                Console.WriteLine(instance.Id);
                Console.WriteLine(instance.FriendlyName);
                Console.WriteLine();

                var instanceDetail = await onlineManagementApi.GetInstance(instance.Id);
                Console.WriteLine(instanceDetail.FriendlyName);
                Console.WriteLine();

                var backupRequest = new BackupRequest
                {
                    InstanceId = instanceDetail.Id,
                    Label = "First API backup",
                    Notes = "This is a backup using the Online Management API wrapper",
                    IsAzureBackup = "false"
                };


                var backups = await onlineManagementApi.GetInstanceBackups(instanceDetail.Id);

                foreach(var backup in backups)
                {
                    Console.WriteLine(backup.Label);
                }

                var result = await onlineManagementApi.BackupInstance(backupRequest);
                Console.WriteLine(result);
                Console.WriteLine();

                break;
            }
        }
    }
}
