using System;
using System.Collections.Generic;
using System.Text;
using TMS.API.Core.Interfaces;
using TMS.API.Core.Models;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace TMS.API.Core.Services
{
    public class RequestService : IRequestService, IRequestCore
    {
        public string url = "https://api.spacexdata.com/";

        public async Task<Cores> GetCoreInfoAsync()
        {
            return await url.AppendPathSegments("v4", "launches", "latest")
                .GetJsonAsync<Cores>();
        }

        public async Task<Example> GetExampleReqAsync()
        {
            return await url.AppendPathSegments("v4", "launches", "latest")
                .GetJsonAsync<Example>();

        }
    }
}
