using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthCheckexample.Health
{
    public class HealthCheckWithArgs : IHealthCheck
    {
        public HealthCheckWithArgs(int i, string s,bool b)
        {
            I = i;
            S = s;
            B = b;
        }
        public int I { get; set; }
        public string S { get; set; }
        public bool B { get; set; }
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            if(I>10 && S!=string.Empty && B==true)
            {
                return Task.FromResult(HealthCheckResult.Healthy("Healthed"));
            }
            return Task.FromResult(HealthCheckResult.Unhealthy("Unhealthy"));
        }
    }
}
