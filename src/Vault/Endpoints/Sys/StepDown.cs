﻿using System.Threading;
using System.Threading.Tasks;

namespace Vault.Endpoints.Sys
{
    public partial class SysEndpoint
    {
        public Task StepDown()
        {
            return StepDown(CancellationToken.None);
        }

        public Task StepDown(CancellationToken ct)
        {
            return _client.PutVoid($"{UriPathBase}/step-down", ct);
        }
    }
}
