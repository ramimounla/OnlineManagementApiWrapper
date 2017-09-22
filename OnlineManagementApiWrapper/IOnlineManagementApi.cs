using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using OnlineManagementApiWrapper.DTO;

namespace OnlineManagementApiWrapper
{
    [Headers("Content-Type: application/json")]
    public interface IOnlineManagementApi
    {
        [Get("/api/v1/Instances")]
        Task<List<Instance>> GetInstances();

        [Get("/api/v1/Instances/{id}")]
        Task<Instance> GetInstance( [AliasAs("id")] string instanceId);

        [Post("/api/v1/InstanceBackups")]
        Task<string> BackupInstance( [Body] BackupRequest backupRequest);

        [Get("/api/v1/InstanceBackups?instanceId={id}")]
        Task<List<Backup>> GetInstanceBackups([AliasAs("id")] string instanceId);
    }
}
