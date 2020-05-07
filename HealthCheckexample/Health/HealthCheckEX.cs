using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthCheckexample.Health
{
    public class HealthCheckEX : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {

            var health = true;
            if(health)
            {
                return Task.FromResult(
                                HealthCheckResult.Healthy("healthed"));
            }
            else
            {
                return Task.FromResult(
                               HealthCheckResult.Unhealthy("Unhealthy"));
            }
        }
    }
}
