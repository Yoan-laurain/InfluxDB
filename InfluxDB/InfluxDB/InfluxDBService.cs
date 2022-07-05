using System;
using System.Threading.Tasks;
using InfluxDB.Client;
using Microsoft.Extensions.Configuration;

namespace InfluxDB
{
    namespace app.Services
    {
        public class InfluxDBService
        {
            private readonly string _url = "http://api.sudododevelopers.xyz:8086/";
            private readonly string _token = "24kmVoDNYb4Kz6B_at4OUOCyMEwx3am_KprTxUcI6PqkekDsiLLfro0aNepZ4-xINIFklTfyuQ33YLq1h2949w==";

            /*public InfluxDBService(IConfiguration configuration)
            {
                _token = configuration.GetConnectionString("InfluxDB:Token");
            }*/

            public void Write(Action<WriteApi> action)
            {
                var client = InfluxDBClientFactory.Create(_url, _token);
                var write = client.GetWriteApi();
                action(write);
            }

            public async Task<T> QueryAsync<T>(Func<QueryApi, Task<T>> action)
            {
                var client = InfluxDBClientFactory.Create(_url, _token);
                var query = client.GetQueryApi();
                return await action(query);
            }
        }
    }
}
