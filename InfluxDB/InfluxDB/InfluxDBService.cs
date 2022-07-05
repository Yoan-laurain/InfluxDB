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
            private readonly string _token = "tJbAwoN6Jd26K-w7TRSAkOo6FWFv4GVpiYky2cGLqYAjKnBZeOG9s1JEeEA-rR8MGaFgrjrrUtRlobGsTkxkxA==";
            private readonly string _tokenNato = "3bNtM0FlYXHVPBYkqCRKF2bpk9Afx5KYGLBGLzEsjdj2HWz0qE2taCw-xuo6yrD3CcPL2Eu7Psjrkd-m_FNurw==";

            /*public InfluxDBService(IConfiguration configuration)
            {
                _token = configuration.GetConnectionString("InfluxDB:Token");
            }*/

            public void Write(Action<WriteApi> action)
            {
                var client = InfluxDBClientFactory.Create("http://localhost:8086", _tokenNato);
                var write = client.GetWriteApi();
                action(write);
                Console.WriteLine("ICI");
            }

            public async Task<T> QueryAsync<T>(Func<QueryApi, Task<T>> action)
            {
                var client = InfluxDBClientFactory.Create("http://localhost:8086", _tokenNato);
                var query = client.GetQueryApi();
                return await action(query);
            }
        }
    }
}
