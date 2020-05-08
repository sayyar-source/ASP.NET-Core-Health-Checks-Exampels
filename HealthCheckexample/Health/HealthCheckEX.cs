using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HealthCheckexample.Health
{
    public class HealthCheckEX : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {

            var health = await CheckConnection();
            if(health)
            {
                return HealthCheckResult.Healthy("healthed");
            }
            else
            {
                return HealthCheckResult.Unhealthy("Unhealthy");
            }
        }

        private async Task<bool> CheckConnection()
        {
            var client = new HttpClient();
           var response=await client.GetAsync("http://uporoje.ir/");
            if(response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
