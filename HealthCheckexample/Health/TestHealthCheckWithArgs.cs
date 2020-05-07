using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthCheckexample.Health
{
    public class TestHealthCheckWithArgs : IHealthCheck
    {
        public TestHealthCheckWithArgs(int a,string s,bool b)
        {
            A = a;
            S = s;
            B = b;
        }
        public int A { get; set; }
        public string S { get; set; }
        public bool B { get; set; }
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
           if(A>10 && S!=string.Empty && B==true)
            {
                return Task.FromResult(HealthCheckResult.Healthy("Healthy"));

            }
            return Task.FromResult(HealthCheckResult.Unhealthy("Unhealthy"));
        }
    }
}
